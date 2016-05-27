using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Common.Security;
using Server.Common.Utilities;
using Server.Ghost.Accounts;
using Server.Ghost.Characters;
using Server.Packet;
using System;
using System.Net;
using System.Net.Sockets;
using static Server.Common.Constants.ServerUtilities;

namespace Server.Net
{
    public sealed class Client : Session
    {
        public Account Account { get; private set; }
        public Character Character { get; private set; }
        public static int i { get; private set; }
        public int CharacterID { get; private set; }
        public string[] IP { get; private set; }
        public long SessionID { get; private set; }

        public Client(Socket socket, UdpClient udp) : base(socket, udp) { }

        protected override void Register()
        {
            GameServer.Clients.Add(this);
            this.CharacterID = ++i;
            this.SessionID = Randomizer.NextLong();
            //
            string[] IP = base.Title.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);
            this.IP = IP;
            //
            GamePacket.Game_Log_Ack(this, CharacterID, this.IP);
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
                //Log.Hex("Received packet from {0}: ", inPacket.Array, this.Title);
                PacketCrypt pd = new PacketCrypt(SessionID);

                byte[] ii;
                if (inPacket.Array[0] == 0x4D && inPacket.Array[1] == 0x0)
                {
                    ii = inPacket.Array;
                }
                else {
                    ii = pd.Decrypt(inPacket.Array);
                }
                InPacket ip = new InPacket(ii);

                if (ip.OperationCode == (ushort)ClientOpcode.SERVER)
                {
                    GameServerHandler.ServerHandlerReceive(ip, this);
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
