using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Common.Security;
using Server.Common.Constants;
using System;
using System.Net;
using Server.Common.Collections;
using static Server.Common.Constants.ServerUtilities;
using Server.Ghost.Characters;
using Server.Ghost;

namespace Server.Interoperability
{
    public sealed class InteroperabilityClient : ServerHandler<InteroperabilityMessage, InteroperabilityMessage, BlankCryptograph>
    {
        private PendingKeyedQueue<byte, ushort> GamePortPool = new PendingKeyedQueue<byte, ushort>();
        private PendingQueue<ushort> ShopPortPool = new PendingQueue<ushort>();

        public InteroperabilityClient(IPEndPoint remoteEndPoint, string code) : base(remoteEndPoint, "Login server", new object[] { code }) { }

        protected override bool IsServerAlive
        {
            get
            {
                return GameServer.IsAlive;
            }
        }

        protected override void StopServer()
        {
            GameServer.Stop();
        }

        public static void Main()
        {
            try
            {
                GameServer.LoginServerConnection = new InteroperabilityClient(new IPEndPoint(
                    Settings.GetIPAddress("IP", "Interconnection"),
                    Settings.GetInt("Port", "Interconnection")),
                    Settings.GetString("SecurityCode", "Interconnection"));

                GameServer.LoginServerConnection.Loop();
            }
            catch (Exception e)
            {
                Log.Error("Server connection failed: \n{0}", e.ToString());

                GameServer.Stop();
            }
        }

        protected override void Initialize(params object[] args)
        {
            using (OutPacket outPacket = new OutPacket(InteroperabilityMessage.RegistrationRequest))
            {
                outPacket.WriteByte((byte)ServerType.Game);
                outPacket.WriteString((string)args[0]);
                outPacket.WriteBytes(GameServer.RemoteEndPoint.Address.GetAddressBytes());
                outPacket.WriteUShort((ushort)GameServer.RemoteEndPoint.Port);

                this.Send(outPacket);
            }
        }

        protected override void Dispatch(InPacket inPacket)
        {
            try
            {
                switch ((InteroperabilityMessage)inPacket.OperationCode)
                {
                    case InteroperabilityMessage.RegistrationResponse:
                        this.OnRegistrationResponse(inPacket);
                        break;

                    case InteroperabilityMessage.LoadProportionRequest:
                        this.OnLoadProportionRequest();
                        break;

                    case InteroperabilityMessage.GamePortRequest:
                        this.OnGamePortResponse(inPacket);
                        break;

                    case InteroperabilityMessage.ShopPortResposne:
                        this.OnShopPortResponse(inPacket);
                        break;
                }
            }
            catch (Exception e)
            {
                Log.Error("Unhandled exception from Interoperability: \n{0}", e.ToString());
            }
        }

        private void OnRegistrationResponse(InPacket inPacket)
        {
            ServerRegistrationResponse response = (ServerRegistrationResponse)inPacket.ReadByte();

            switch (response)
            {
                case ServerRegistrationResponse.Valid:
                    {
                        GameServer.WorldID = inPacket.ReadByte();
                        GameServer.ChannelID = inPacket.ReadByte();

                        GameServer.ScrollingHeader = inPacket.ReadString();
                        GameServer.Rates = new Rates()
                        {
                            Experience = inPacket.ReadInt(),
                            QuestExperience = inPacket.ReadInt(),
                            PartyQuestExperience = inPacket.ReadInt(),

                            Meso = inPacket.ReadInt(),
                            Loot = inPacket.ReadInt(),
                        };

                        Log.Success("Registered Game as {0}-{1} at {2}.", WorldNameResolver.GetName(GameServer.WorldID), GameServer.ChannelID, GameServer.RemoteEndPoint);
                        Log.Inform("Rates: {0}x / {1}x / {2}x / {3}x / {4}x.",
                                           GameServer.Rates.Experience,
                                           GameServer.Rates.QuestExperience,
                                           GameServer.Rates.PartyQuestExperience,
                                           GameServer.Rates.Meso,
                                           GameServer.Rates.Loot);
                    }
                    break;

                default:
                    throw new NetworkException(RegistrationResponseResolver.Explain(response));
            }
        }

        private void OnLoadProportionRequest()
        {
            using (OutPacket outPacket = new OutPacket(InteroperabilityMessage.LoadProportionResponse))
            {
                outPacket.WriteInt(GameServer.Clients.Count);

                this.Send(outPacket);
            }
        }

        private void OnGamePortResponse(InPacket inPacket)
        {
            byte id = inPacket.ReadByte();
            ushort port = inPacket.ReadUShort();

            this.GamePortPool.Enqueue(id, port);
        }

        private void OnShopPortResponse(InPacket inPacket)
        {
            ushort port = inPacket.ReadUShort();

            this.ShopPortPool.Enqueue(port);
        }

        public ushort GetGamePort(byte id)
        {
            using (OutPacket outPacket = new OutPacket(InteroperabilityMessage.GamePortRequest))
            {
                outPacket.WriteByte(id);

                this.Send(outPacket);
            }

            return this.GamePortPool.Dequeue(id);
        }

        public ushort GetShopPort()
        {
            using (OutPacket outPacket = new OutPacket(InteroperabilityMessage.ShopPortRequest))
            {
                this.Send(outPacket);
            }

            return this.ShopPortPool.Dequeue();
        }
    }
}
