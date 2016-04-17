using Server.Common.Collections;
using Server.Common.Constants;
using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Common.Security;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace Server.Interoperability
{
    public sealed class InteroperabilityClient : ClientHandler<InteroperabilityMessage, InteroperabilityMessage, BlankCryptograph>
    {
        private byte _id;
        private ServerUtilities.ServerType _type;

        public byte WorldID { get; private set; }
        public IPEndPoint RemoteEndPoint { get; private set; }

        public PendingQueue<int> LoadProportionPool = new PendingQueue<int>();

        public byte InternalID
        {
            get
            {
                return (byte)(this.ExternalID - 1);
            }
        }

        public byte ExternalID
        {
            get
            {
                return _id;
            }
            set
            {
                this._id = value;

                // TODO: Update ID packet (?).
            }
        }

        public World World
        {
            get
            {
                return LoginServer.Worlds[this.WorldID];
            }
        }

        public int LoadProportion
        {
            get
            {
                using (OutPacket outPacket = new OutPacket(InteroperabilityMessage.LoadProportionRequest))
                {
                    this.Send(outPacket);
                }

                return this.LoadProportionPool.Dequeue();
            }
        }

        public InteroperabilityClient(Socket socket) : base(socket) { }

        protected override void Register()
        {
            InteroperabilityServer.Servers.Add(this);
        }

        protected override void Prepare(params object[] args)
        {
            this.RemoteEndPoint = this.Socket.RemoteEndPoint as IPEndPoint;
        }

        protected override void Terminate()
        {
            switch (this._type)
            {
                case ServerUtilities.ServerType.Char:
                    {
                        if (LoginServer.Worlds.Contains(this.WorldID))
                        {
                            if (this.World.CharServer == this)
                            {
                                this.World.CharServer = null;

                                Log.Warn("Unregistered Char {0}.", this.World.Name);
                            }
                        }
                    }
                    break;

                case ServerUtilities.ServerType.Game:
                    {
                        if (LoginServer.Worlds.Contains(this.WorldID))
                        {
                            if (this.World.Contains(this))
                            {
                                this.World.Remove(this);

                                Log.Warn("Unregistered Game {0}-{1}.", this.World.Name, this.ExternalID);
                            }

                            foreach (InteroperabilityClient game in this.World)
                            {
                                if (game.ExternalID > this.ExternalID)
                                {
                                    game.ExternalID--;
                                }
                            }
                        }
                    }
                    break;

                case ServerUtilities.ServerType.Message:
                    {
                        if (LoginServer.Worlds.Contains(this.WorldID))
                        {
                            if (this.World.MessageServer == this)
                            {
                                this.World.MessageServer = null;

                                Log.Warn("Unregistered Message {0}.", this.World.Name);
                            }
                        }
                    }
                    break;

                case ServerUtilities.ServerType.Shop:
                    {
                        if (LoginServer.Worlds.Contains(this.WorldID))
                        {
                            if (this.World.ShopServer == this)
                            {
                                this.World.ShopServer = null;

                                Log.Warn("Unregistered Shop {0}.", this.World.Name);
                            }
                        }
                    }
                    break;
            }
        }

        protected override void Unregister()
        {
            InteroperabilityServer.Servers.Remove(this);
        }

        protected override bool IsServerAlive
        {
            get
            {
                return LoginServer.IsAlive;
            }
        }

        protected override void Dispatch(InPacket inPacket)
        {
            switch ((InteroperabilityMessage)inPacket.OperationCode)
            {
                case InteroperabilityMessage.RegistrationRequest:
                    this.OnRegistrationRequest(inPacket);
                    break;

                case InteroperabilityMessage.LoadProportionResponse:
                    this.LoadProportionPool.Enqueue(inPacket.ReadInt());
                    break;

                case InteroperabilityMessage.CharacterEntriesResponse:
                    this.OnCharacterEntriesResponse(inPacket);
                    break;

                case InteroperabilityMessage.CharacterNameCheckResponse:
                    this.OnCharacterNameCheckResponse(inPacket);
                    break;

                case InteroperabilityMessage.CharacterCreationResponse:
                    this.OnCharacterCreationResponse(inPacket);
                    break;

                case InteroperabilityMessage.CharPortRequest:
                    this.OnCharPortRequest();
                    break;

                case InteroperabilityMessage.GamePortRequest:
                    this.OnGamePortRequest(inPacket);
                    break;

                case InteroperabilityMessage.MessagePortRequest:
                    this.OnMessagePortRequest();
                    break;

                case InteroperabilityMessage.ShopPortRequest:
                    this.OnShopPortRequest();
                    break;
            }
        }

        private void OnRegistrationRequest(InPacket inPacket)
        {
            ServerUtilities.ServerType type = (ServerUtilities.ServerType)inPacket.ReadByte();
            string securityCode = inPacket.ReadString();
            IPEndPoint endPoint = new IPEndPoint(inPacket.ReadIPAddress(), inPacket.ReadUShort());
            World world = LoginServer.Worlds.Next(type);

            bool worked = false;

            using (OutPacket outPacket = new OutPacket(InteroperabilityMessage.RegistrationResponse))
            {
                if (securityCode != LoginServer.SecurityCode)
                {
                    outPacket.WriteByte((byte)ServerUtilities.ServerRegistrationResponse.InvalidCode);

                    Log.Error(ServerUtilities.RegistrationResponseResolver.Explain(ServerUtilities.ServerRegistrationResponse.InvalidCode));
                }
                else if (world == null)
                {
                    outPacket.WriteByte((byte)ServerUtilities.ServerRegistrationResponse.WorldsFull);

                    Log.Error(ServerUtilities.RegistrationResponseResolver.Explain(ServerUtilities.ServerRegistrationResponse.WorldsFull));
                }
                else
                {
                    if (world.HostIP.ToString() != endPoint.Address.ToString())
                    {
                        outPacket.WriteByte((byte)ServerUtilities.ServerRegistrationResponse.InvalidIP);

                        Log.Error(ServerUtilities.RegistrationResponseResolver.Explain(ServerUtilities.ServerRegistrationResponse.InvalidIP));
                    }
                    else
                    {
                        this._type = type;
                        this.RemoteEndPoint = endPoint;
                        this.WorldID = world.ID;

                        switch (this._type)
                        {
                            case ServerUtilities.ServerType.Char:
                                {
                                    this.World.CharServer = this;

                                    outPacket.WriteByte((byte)ServerUtilities.ServerRegistrationResponse.Valid);
                                    outPacket.WriteByte(this.WorldID);

                                    worked = true;
                                }
                                break;

                            case ServerUtilities.ServerType.Game:
                                {
                                    this.World.Add(this);
                                    this._id = (byte)this.World.Count;

                                    outPacket.WriteByte((byte)ServerUtilities.ServerRegistrationResponse.Valid);
                                    outPacket.WriteByte(this.WorldID);
                                    outPacket.WriteByte(this.ExternalID);
                                    outPacket.WriteString(this.World.ScrollingHeader);
                                    outPacket.WriteInt(this.World.Rates.Experience);
                                    outPacket.WriteInt(this.World.Rates.QuestExperience);
                                    outPacket.WriteInt(this.World.Rates.PartyQuestExperience);
                                    outPacket.WriteInt(this.World.Rates.Meso);
                                    outPacket.WriteInt(this.World.Rates.Loot);

                                    worked = true;
                                }
                                break;

                            case ServerUtilities.ServerType.Message:
                                {
                                    this.World.MessageServer = this;

                                    outPacket.WriteByte((byte)ServerUtilities.ServerRegistrationResponse.Valid);
                                    outPacket.WriteByte(this.WorldID);

                                    worked = true;
                                }
                                break;

                            case ServerUtilities.ServerType.Shop:
                                {
                                    this.World.ShopServer = this;

                                    outPacket.WriteByte((byte)ServerUtilities.ServerRegistrationResponse.Valid);
                                    outPacket.WriteByte(this.WorldID);

                                    worked = true;
                                }
                                break;
                        }
                    }
                }

                this.Send(outPacket);
            }

            if (worked)
            {
                switch (this._type)
                {
                    case ServerUtilities.ServerType.Char:
                        {
                            Log.Success("Registered Char {0} at {1}.", this.World.Name, this.RemoteEndPoint);
                        }
                        break;

                    case ServerUtilities.ServerType.Game:
                        {
                            Log.Success("Registered Game {0}-{1} at {2}.", this.World.Name, this.ExternalID, this.RemoteEndPoint);
                        }
                        break;

                    case ServerUtilities.ServerType.Message:
                        {
                            Log.Success("Registered Message {0} at {1}.", this.World.Name, this.RemoteEndPoint);
                        }
                        break;

                    case ServerUtilities.ServerType.Shop:
                        {
                            Log.Success("Registered Shop {0} at {1}.", this.World.Name, this.RemoteEndPoint);
                        }
                        break;
                }
            }
            else
            {
                Log.Warn("Server registration failed.");

                this.Stop();
            }
        }

        private void OnCharacterEntriesResponse(InPacket inPacket)
        {
            int accountId = inPacket.ReadInt();

            List<byte[]> entries = new List<byte[]>();

            while (inPacket.Available > 0)
            {
                entries.Add(inPacket.ReadBytes(inPacket.ReadInt()));
            }

            this.World.CharacterListPool.Enqueue(accountId, entries);
        }

        private void OnCharacterNameCheckResponse(InPacket inPacket)
        {
            string name = inPacket.ReadString();
            bool taken = inPacket.ReadBool();

            this.World.CharacterNamePool.Enqueue(name, taken);
        }

        private void OnCharacterCreationResponse(InPacket inPacket)
        {
            int accountId = inPacket.ReadInt();
            byte[] info = inPacket.ReadBytes(inPacket.Available);

            this.World.CharacterCreationPool.Enqueue(accountId, info);
        }

        private void OnCharPortRequest()
        {
            using (OutPacket outPacket = new OutPacket(InteroperabilityMessage.CharPortResponse))
            {
                if (this.World.CharServer != null)
                {
                    InteroperabilityClient chr = this.World.CharServer;

                    outPacket.WriteUShort((ushort)chr.RemoteEndPoint.Port);
                }
                else
                {
                    outPacket.WriteUShort();
                }

                this.Send(outPacket);
            }
        }

        private void OnGamePortRequest(InPacket inPacket)
        {
            byte id = inPacket.ReadByte();

            using (OutPacket outPacket = new OutPacket(InteroperabilityMessage.GamePortResponse))
            {
                outPacket.WriteByte(id);

                if (this.World.Contains(id))
                {
                    InteroperabilityClient game = this.World[id];

                    outPacket.WriteUShort((ushort)game.RemoteEndPoint.Port);
                }
                else
                {
                    outPacket.WriteUShort();
                }

                this.Send(outPacket);
            }
        }

        private void OnMessagePortRequest()
        {
            using (OutPacket outPacket = new OutPacket(InteroperabilityMessage.MessagePortResponse))
            {
                if (this.World.MessageServer != null)
                {
                    InteroperabilityClient message = this.World.MessageServer;

                    outPacket.WriteUShort((ushort)message.RemoteEndPoint.Port);
                }
                else
                {
                    outPacket.WriteUShort();
                }

                this.Send(outPacket);
            }
        }

        private void OnShopPortRequest()
        {
            using (OutPacket outPacket = new OutPacket(InteroperabilityMessage.ShopPortResposne))
            {
                if (this.World.ShopServer != null)
                {
                    InteroperabilityClient shop = this.World.ShopServer;

                    outPacket.WriteUShort((ushort)shop.RemoteEndPoint.Port);
                }
                else
                {
                    outPacket.WriteUShort();
                }

                this.Send(outPacket);
            }
        }
    }
}
