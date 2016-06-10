using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Net;
using Server.Packet;

namespace Server.Handler
{
    public static class StorageHandler
    {
        public static void moveItemToStorage(InPacket lea, Client gc)
        {
            int SourceType = lea.ReadShort();
            int SourceSlot = lea.ReadShort();
            int TargetType = lea.ReadShort();
            int TargetSlot = lea.ReadShort();
            int Quantity = lea.ReadInt();
            var chr = gc.Character;
            Item Source = chr.Items.GetItem((byte)SourceType, (byte)SourceSlot);
            chr.Storages.Add(new Storage(Source.ItemID, Quantity, TargetType, TargetSlot, 0));
            chr.Items.Remove((byte)SourceType, (byte)SourceSlot, Quantity);
            InventoryPacket.getStoreInfo(gc);
            InventoryHandler.UpdateInventory(gc, (byte)SourceType);
        }

        public static void saveStorageMoney(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            int money = lea.ReadInt();
            int unk = lea.ReadInt();

            chr.Storages.getStorages()[0].Money += money;
            chr.Storages.getStorages()[0].Save();
            chr.Money -= money;
            chr.Save();
            InventoryPacket.getInvenMoney(gc, chr.Money, -money);
            InventoryPacket.getStoreMoney(gc);
        }

        public static void giveStorageMoney(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            int money = lea.ReadInt();
            int unk = lea.ReadInt();

            chr.Storages.getStorages()[0].Money -= money;
            chr.Storages.getStorages()[0].Save();
            chr.Money += money;
            chr.Save();
            InventoryPacket.getInvenMoney(gc, chr.Money, money);
            InventoryPacket.getStoreMoney(gc);
        }
    }
}
