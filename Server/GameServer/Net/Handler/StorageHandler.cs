using Server.Common.Constants;
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
            Storage Target = chr.Storages.GetItem((byte)TargetType, (byte)TargetSlot);
            Item Source = chr.Items.getItem((byte)SourceType, (byte)SourceSlot);

            if (Target != null)
                return;

            chr.Storages.Add(new Storage(Source.ItemID, Quantity, TargetType, TargetSlot, 0));
            chr.Items.Remove((byte)SourceType, (byte)SourceSlot, Quantity);
            chr.Save();
            StoragePacket.getStoreInfo(gc);
            InventoryHandler.UpdateInventory(gc, (byte)SourceType);
        }

        public static void moveItemToBag(InPacket lea, Client gc)
        {
            int SourceType = lea.ReadShort();
            int SourceSlot = lea.ReadShort();
            int TargetSlot = lea.ReadShort();
            lea.ReadShort();
            int Quantity = lea.ReadInt();
            var chr = gc.Character;

            Storage Source = chr.Storages.GetItem((byte)SourceType, (byte)SourceSlot);
            int TargetType = InventoryType.getItemType(Source.ItemID);
            Item Item = chr.Items.getItem((byte)TargetType, (byte)TargetSlot);

            chr.Storages.Remove((byte)Source.Type, (byte)Source.Slot, Quantity);

            if (Item == null)
            {
                chr.Items.Add(new Item(Source.ItemID, (byte)TargetType, (byte)TargetSlot, (short)Quantity));
            }
            else
            {
                int QuantityTemp = Item.Quantity;
                chr.Items.Remove((byte)TargetType, (byte)TargetSlot);
                chr.Items.Add(new Item(Item.ItemID, (byte)TargetType, (byte)TargetSlot, (short)(QuantityTemp + Quantity)));
            }

            chr.Save();
            StoragePacket.getStoreInfo(gc);
            InventoryHandler.UpdateInventory(gc, (byte)TargetType);
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
            StoragePacket.getStoreMoney(gc);
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
            StoragePacket.getStoreMoney(gc);
        }
    }
}
