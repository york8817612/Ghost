using Server.Accounts;
using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Common.Utilities;
using Server.Interoperability;
using System;
using System.Net.Sockets;

namespace Server.Ghost
{
    public sealed class Client : Session
    {
        public byte WorldID { get; private set; }
        public byte GameID { get; private set; }
        public Account Account { get; private set; }
        public string[] MacAddresses { get; private set; }
        public long SessionID { get; private set; }
        public int RetryLoginCount { get; set; }

        public World World
        {
            get
            {
                return LoginServer.Worlds[this.WorldID];
            }
            set
            {
                this.WorldID = value.ID;
            }
        }

        public InteroperabilityClient Game
        {
            get
            {
                return this.World[this.GameID];
            }
            set
            {
                this.GameID = value.InternalID;
            }
        }

        public Client(Socket socket)
            : base(socket)
        {
            this.SessionID = Randomizer.NextLong();
            this.RetryLoginCount = 0;
        }

        protected override void Register()
        {
            LoginServer.Clients.Add(this);

            Log.Inform("Accepted connection from {0}.", this.Title);
        }

        protected override void Unregister()
        {
            if (this.Account != null)
            {
                this.Account.LoggedIn = 0;

                this.Account.Save();
            }

            LoginServer.Clients.Remove(this);

            Log.Inform("Lost connection from {0}.", this.Title);
        }


        protected override void Dispatch(InPacket inPacket)
        {
            try
            {
                if (inPacket.OperationCode == (ushort)ClientOpcode.LOGIN_SERVER)
                {
                    inPacket.ReadUShort(); // 原始長度
                    var Header = inPacket.ReadByte(); // 讀取包頭

                    Log.Hex("Received (0x{0:X2}) packet from {1}: ", inPacket.Content, Header, this.Title);

                    switch ((LoginClientOpcode)Header)
                    {
                        case LoginClientOpcode.LOGIN_REQ:
                            LoginHandler.Login_Req(inPacket, this);
                            break;
                        case LoginClientOpcode.SERVERLIST_REQ:
                            LoginHandler.ServerList_Req(inPacket, this);
                            break;
                        case LoginClientOpcode.GAME_REQ:
                            LoginHandler.Game_Req(inPacket, this);
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error("Unhandled Packet Exception from {0}: \n{1}", this.Title, e.ToString());
            }
        }

        public void SetAccount(Account Account)
        {
            this.Account = Account;
        }
    }
}