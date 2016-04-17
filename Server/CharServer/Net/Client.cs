using Server.Accounts;
using Server.Characters;
using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Net;
using System;
using System.Net.Sockets;

namespace Server.Net
{
    public sealed class Client : Session
    {
        public Account Account { get; private set; }
        public byte WorldID { get; private set; }
        public byte GameID { get; private set; }

        public Client(Socket socket) : base(socket) { }

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

                if (inPacket.OperationCode == (ushort)ClientMessage.SERVER)
                {
                    var hand = inPacket.ReadShort(); // 讀取包頭
                    inPacket.ReadUShort(); // 原始長度

                    switch ((ClientMessage)hand)
                    {
                        case ClientMessage.MYCHAR_INFO_REQ:
                            CharHandler.MyChar_Info_Req(inPacket, this);
                            break;
                        case ClientMessage.CREATE_MYCHAR_REQ:
                            CharHandler.Create_MyChar_Req(inPacket, this);
                            break;
                        case ClientMessage.CHECK_SAMENAME_REQ:
                            CharHandler.Check_SameName_Req(inPacket, this);
                            break;
                        case ClientMessage.DELETE_MYCHAR_REQ:
                            CharHandler.Delete_MyChar_Req(inPacket, this);
                            break;
                    }
                }
            }
            catch (HackException e)
            {
                // TODO: Register offense using the exception's message.
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
