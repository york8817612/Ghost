using Server.Common.IO.Packet;
using Server.Ghost;

namespace Server.Handler
{
    public static class NpcShopHandler
    {
        public static void Buy_Req(InPacket lea, Client gc)
        {
            lea.ReadInt();
            int ItemID = lea.ReadInt();
            int Quantity = lea.ReadInt();
        }
    }
}
