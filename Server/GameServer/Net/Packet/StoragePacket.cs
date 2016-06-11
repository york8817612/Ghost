using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Net;

namespace Server.Packet
{
    public static class StoragePacket
    {
        public static void getStoreInfo(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.STORE_INFO))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(0);
                for (byte i = 0; i < 40; i++)
                {
                    plew.WriteInt(chr.Storages.GetItemID(0, i));
                    plew.WriteHexString("00 00 00 00 00 00 00 00 FF FF FF FF 00 00 00 00");
                    plew.WriteShort(chr.Storages.GetItemQuantity(0, i));
                    plew.WriteHexString("00 00 00 00 00 00 00 00 00 00");
                    plew.WriteShort(0); // 力量
                    plew.WriteShort(0); // 精力
                    plew.WriteShort(0);
                    plew.WriteShort(0); // 防禦力
                    plew.WriteShort(0); // 提煉回數
                    plew.WriteHexString("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");
                }
                c.Send(plew);
            }
        }

        public static void getStoreMoney(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.STORE_MONEYINFO))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(chr.Storages.getStorages()[0].Money);
                plew.WriteInt(0);

                c.Send(plew);
            }
        }
    }
}
