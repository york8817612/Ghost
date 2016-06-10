using Server.Accounts;
using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Net;
using System;
using System.Net.Sockets;

namespace Server.Ghost
{
    public sealed class Client : Session
    {
        public Account Account { get; private set; }
        public byte WorldID { get; private set; }
        public byte GameID { get; private set; }
        public int RetryLoginCount { get; set; }

        public Client(Socket socket) : base(socket)
        {
            this.RetryLoginCount = 0;
        }

        protected override void Register()
        {
            CharServer.Clients.Add(this);
        }


        protected override void Unregister()
        {
            if (this.Account != null)
            {
                this.Account.LoggedIn = 0;

                this.Account.Save();
            }
            // TODO: Save character.
            CharServer.Clients.Remove(this);
        }

        protected bool IsServerAlive
        {
            get
            {
                return CharServer.IsAlive;
            }
        }

        protected override void Dispatch(InPacket inPacket)
        {
            try
            {
                Log.Hex("Received (0x{0:X2}) packet from {1}: ", inPacket.Content, inPacket.OperationCode, this.Title);

                if (inPacket.OperationCode == (ushort)ClientOpcode.SERVER)
                {
                    var Header = inPacket.ReadShort(); // 讀取包頭
                    inPacket.ReadInt(); // 原始長度 + CRC
                    inPacket.ReadInt();

                    switch ((ClientOpcode)Header)
                    {
                        case ClientOpcode.MYCHAR_INFO_REQ:
                            CharHandler.MyChar_Info_Req(inPacket, this);
                            break;
                        case ClientOpcode.CREATE_MYCHAR_REQ:
                            CharHandler.Create_MyChar_Req(inPacket, this);
                            break;
                        case ClientOpcode.CHECK_SAMENAME_REQ:
                            CharHandler.Check_SameName_Req(inPacket, this);
                            break;
                        case ClientOpcode.DELETE_MYCHAR_REQ:
                            CharHandler.Delete_MyChar_Req(inPacket, this);
                            break;
                    }
                }
            }
            catch (HackException e)
            {
                Log.Warn("Hack from {0}: \n{1}", this.Account.Username, e.ToString());
            }
            catch (Exception e)
            {
                Log.Error("Unhandled exception from {0}: \n{1}", this.Title, e.ToString());
            }
        }

        public void SetAccount(Account Account)
        {
            this.Account = Account;
        }
    }
}
