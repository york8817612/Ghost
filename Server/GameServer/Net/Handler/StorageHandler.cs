using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Net;
using Server.Packet;

namespace Server.Handler
{
    public static class StorageHandler
    {
        public static void MoveItemToStorage(InPacket lea, Client gc)
        {
            int SourceType = lea.ReadShort();
            int SourceSlot = lea.ReadShort();
            int TargetType = lea.ReadShort();
            int TargetSlot = lea.ReadShort();
            int Quantity = lea.ReadInt();
            var chr = gc.Character;
            Storage Target = chr.Storages.GetItem((byte)TargetType, (byte)TargetSlot);
            Item Source = chr.Items.getItem((byte)SourceType, (byte)SourceSlot);

            if (Target != null || Source.ItemID / 100000 == 86 || Source.ItemID / 100000 == 87 || Source.ItemID / 100000 == 92 || Source.ItemID / 100000 == 94 || Source.ItemID / 100000 == 95)
                return;

            chr.Storages.Add(new Storage(Source.ItemID, Quantity, Source.Spirit, Source.Level1, Source.Level2, Source.Level3, Source.Level4, Source.Level5, Source.Level6, Source.Level7, Source.Level8, Source.Level9, Source.Level10, Source.Fusion, Source.IsLocked, Source.Icon, Source.Term, TargetType, TargetSlot, 0));
            chr.Items.Remove((byte)SourceType, (byte)SourceSlot, Quantity);
            chr.Save();
            StoragePacket.getStoreInfo(gc);
            InventoryHandler.UpdateInventory(gc, (byte)SourceType);
        }

        public static void MoveItemToBag(InPacket lea, Client gc)
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

            if (Item == null)
            {
                chr.Items.Add(new Item(Source.ItemID, (short)Quantity, Source.Spirit, Source.Level1, Source.Level2, Source.Level3, Source.Level4, Source.Level5, Source.Level6, Source.Level7, Source.Level8, Source.Level9, Source.Level10, Source.Fusion, Source.IsLocked, Source.Icon, Source.Term, (byte)TargetType, (byte)TargetSlot));
            }
            else
            {
                if (Source.ItemID != Item.ItemID)
                    return;

                int QuantityTemp = Item.Quantity;
                chr.Items.Remove((byte)TargetType, (byte)TargetSlot);
                chr.Items.Add(new Item(Item.ItemID, (short)(QuantityTemp + Quantity), Item.Spirit, Item.Level1, Item.Level2, Item.Level3, Item.Level4, Item.Level5, Item.Level6, Item.Level7, Item.Level8, Item.Level9, Item.Level10, Item.Fusion, Item.IsLocked, Item.Icon, Item.Term, (byte)TargetType, (byte)TargetSlot));
            }

            chr.Storages.Remove((byte)Source.Type, (byte)Source.Slot, Quantity);

            chr.Save();
            StoragePacket.getStoreInfo(gc);
            InventoryHandler.UpdateInventory(gc, (byte)TargetType);
        }

        public static void SaveStorageMoney(InPacket lea, Client gc)
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

        public static void GiveStorageMoney(InPacket lea, Client gc)
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
