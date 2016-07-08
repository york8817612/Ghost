using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Net;

namespace Server.Ghost
{
    public static class FriendPacket
    {
        public static void FriendList(Client c)
        {
            using (var plew = new OutPacket(MessengerServerOpcode.FRIEND_LIST))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                for (int i = 0; i < 30; i++)
                {
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                    plew.WriteInt(1);
                    plew.WriteInt(-1);
                    plew.WriteInt(-1); // (byte)
                }
                c.Send(plew);
            }
        }

        public static void FriendAdd(Client c)
        {
            using (var plew = new OutPacket(MessengerServerOpcode.FRIEND_ADD))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(0);
                c.Send(plew);
            }
        }

        public static void FriendOnline(Client c)
        {
            using (var plew = new OutPacket(MessengerServerOpcode.FRIEND_ONLINE))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteString("", 20); // 玩家名稱
                c.Send(plew);
            }
        }
    }
}
