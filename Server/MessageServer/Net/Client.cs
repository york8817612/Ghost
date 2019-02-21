using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Common.Security;
using Server.Common.Utilities;
using Server.Ghost;
using System;
using System.Net.Sockets;

namespace Server.Net
{
    public sealed class Client : Session
    {
        public int CharacterID = 1;
        public long SessionID { get; private set; }

        public Client(Socket socket) : base(socket) { }

        protected override void Register()
        {
            MessageServer.Clients.Add(this);
            this.SessionID = Randomizer.NextLong();
            MessengerPacket.GameLog(this, this.CharacterID);
            this.CharacterID++;
            Log.Inform("Accepted connection from {0}.", this.Title);
        }


        protected override void Unregister()
        {
            // TODO: Save character.
            MessageServer.Clients.Remove(this);
        }

        protected bool IsServerAlive
        {
            get
            {
                return MessageServer.IsAlive;
            }
        }

        protected override void Dispatch(InPacket inPacket)
        {
            try
            {
                PacketCrypt pd = new PacketCrypt(0);

                byte[] ii;
                if (inPacket.Array[0] == 0x4D && inPacket.Array[1] == 0x0)
                {
                    ii = inPacket.Array;
                }
                else
                {
                    ii = pd.Decrypt(inPacket.Array);
                }
                InPacket ip = new InPacket(ii);

                if (ip.OperationCode == (ushort)ClientOpcode.SERVER)
                {
                    var Header = ip.ReadShort();

                    Log.Hex("Received (0x{0:X2}) packet from {1}: ", ip.Content, Header, this.Title);

                    switch (Header)
                    {
                        case 0x0C:
                            FriendPacket.FriendList(this);
                            break;
                    }
                }
            }
            catch (HackException e)
            {
                // TODO: Register offense using the exception's message.
                Log.Warn("Hack exception from {0}: \n{1}", this.Title, e.ToString());
            }
            catch (Exception e)
            {
                Log.Error("Unhandled exception from {0}: \n{1}", this.Title, e.ToString());
            }
        }
    }
}
