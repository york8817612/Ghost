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
                    plew.WriteByte(0); // 合成所剩回數
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                    plew.WriteHexString("00 00 00"); // 物理攻擊力+ v2 + 13
                    plew.WriteShort(0); // 封印量 v2 + 16
                    plew.WriteShort(0); // Lock v2 + 18
                    plew.WriteInt(chr.Storages.GetItemQuantity(0, i));
                    plew.WriteInt(0);
                    plew.WriteInt(-1);
                    plew.WriteInt(0); // 力量
                    plew.WriteInt(0);
                    plew.WriteInt(0); // 提煉所剩回數
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                    plew.WriteShort(0); // 未知
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                    plew.WriteShort(0);
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                    plew.WriteInt(0);
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
