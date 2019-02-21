using Server.Common.Constants;
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
                    plew.WriteInt(chr.Storages.ItemID(InventoryType.ItemType.Equip, i));
                    plew.WriteByte(chr.Storages.Fusion(InventoryType.ItemType.Equip, i));
                    plew.WriteByte(chr.Storages.Level1(InventoryType.ItemType.Equip, i));
                    plew.WriteByte(chr.Storages.Level2(InventoryType.ItemType.Equip, i));
                    plew.WriteByte(chr.Storages.Level3(InventoryType.ItemType.Equip, i));
                    plew.WriteByte(chr.Storages.Level4(InventoryType.ItemType.Equip, i));
                    plew.WriteByte(chr.Storages.Level5(InventoryType.ItemType.Equip, i));
                    plew.WriteByte(chr.Storages.Level6(InventoryType.ItemType.Equip, i));
                    plew.WriteByte(chr.Storages.Level7(InventoryType.ItemType.Equip, i));
                    plew.WriteByte(chr.Storages.Level8(InventoryType.ItemType.Equip, i));
                    plew.WriteByte(chr.Storages.Level9(InventoryType.ItemType.Equip, i));
                    plew.WriteByte(chr.Storages.Level10(InventoryType.ItemType.Equip, i));
                    plew.WriteByte(0);
                    plew.WriteShort(chr.Storages.Spirit(InventoryType.ItemType.Equip, i)); // 封印量 v2 + 16
                    plew.WriteShort(chr.Storages.IsLocked(InventoryType.ItemType.Equip, i)); // Lock v2 + 18
                    plew.WriteInt(chr.Storages.Quantity(InventoryType.ItemType.Equip, i));
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
                plew.WriteInt(chr.Storages.getStorages()[0].Money < 0 ? 0 : chr.Storages.getStorages()[0].Money);
                plew.WriteInt(0);

                c.Send(plew);
            }
        }
    }
}
