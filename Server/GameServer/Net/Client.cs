using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Common.Security;
using Server.Common.Utilities;
using Server.Ghost.Accounts;
using Server.Ghost.Characters;
using System;
using System.Net.Sockets;
using static Server.Common.Constants.ServerUtilities;

namespace Server.Net
{
    public sealed class Client : Session
    {
        public Account Account { get; private set; }
        public Character Character { get; private set; }
        public long SessionID { get; private set; }

        public Client(Socket socket) : base(socket) { }

        protected override void Register()
        {
            GameServer.Clients.Add(this);
            this.SessionID = Randomizer.NextLong();
            GamePacket.Game_Log_Ack(this, GameServer.Clients.Count);
            Log.Inform("Accepted connection from {0}.", this.Title);
        }

        protected override void Unregister()
        {
            try
            {
                if (this.Character != null)
                {
                    this.Character.Save();
                }

                GameServer.Clients.Remove(this);

                Log.Inform("Lost connection from {0}.", this.Title);
            }
            catch (Exception e)
            {
                Log.Error("Unregister exception from {0}: \n{1}", this.Title, e.ToString());
            }
        }

        protected override void Dispatch(InPacket inPacket)
        {
            try
            {
                Log.Hex("Received packet from {0}: ", inPacket.Array, this.Title);
                PacketCrypt pd = new PacketCrypt(SessionID);

                byte[] ii = pd.Decrypt(inPacket.Array);
                byte[] pp = new byte[ii.Length + 1];
                Buffer.BlockCopy(ii, 1, pp, 0, ii.Length-1);
                InPacket ip = new InPacket(pp); 
                //byte[] ii = inPacket.Array;

                Log.Hex("Received packet from {0}: ", pp, this.Title);

                if (ip.OperationCode == (ushort)ClientMessage.SERVER)
                {
                    var hand = ip.ReadShort(); // 讀取包頭
                    ip.ReadUShort(); // 原始長度
                    ip.ReadUShort(); // CRC
                    ip.ReadInt();

                    switch ((ClientMessage)hand)
                    {
                        case ClientMessage.GAMELOG_REQ:
                            GameHandler.Game_Log_Req(ip, this);
                            break;
                        case ClientMessage.ENTER_WARP_ACK_REQ:
                            GameHandler.WarpToMap_Req(ip, this);
                            break;
                        case ClientMessage.CAN_WARP_ACK_REQ:
                            GameHandler.WarpToMapAuth_Req(ip, this);
                            break;
                    }
                }
            }
            catch (HackException e)
            {
                if (this.Character != null)
                {
                    // TODO: Register offense points in the database (?).

                    //Log.Warn("Taking Hack Action of {0} against {1}: \n{2}", e.Action, this.Character.Name, e.Message);

                    switch (e.Action)
                    {
                        case HackAction.Disconnection:
                            {
                                this.Dispose();
                            }
                            break;

                        case HackAction.ThirthyDays:
                            {

                            }
                            break;

                        case HackAction.NinetyDays:
                            {

                            }
                            break;

                        case HackAction.Permanent:
                            {

                            }
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

        public void SetCharacter(Character Character)
        {
            this.Character = Character;
        }
    }
}
