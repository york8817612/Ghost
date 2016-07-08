using Server.Common.Constants;
using Server.Common.Data;
using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;

namespace Server.Handler
{
    public static class CashShopHandler
    {
        public static void CashShopList_Req(InPacket lea, Client c)
        {
        }

        public static void BuyCommodity_Req(InPacket lea, Client c)
        {
            int ItemID = lea.ReadInt();
            string ItemName = lea.ReadString(62);
            short Quantity = 1;
            bool IsLocked = true;

            var chr = c.Character;

            if (CashShopFactory.GetItemData(ItemID) == null)
                return;

            if (ItemID == 8842002)
                Quantity = 10;

            if (ItemID == 8841001 || ItemID == 8841002 || ItemID == 8841003 || ItemID == 8841004 || ItemID == 8841005)
                Quantity = 20;

            if (ItemID == 8890031 || ItemID == 8890037) // 鞭炮 + 心花怒放
                Quantity = 100;

            if (ItemID / 100000 == 92 || ItemID == 8890031 || ItemID == 8890037) // 寵物 + 鞭炮 + 心花怒放
                IsLocked = false;

            // 購買日誌
            dynamic datum = new Datum("BuyCommodityLog");
            datum.name = chr.Name;
            datum.itemID = ItemID;
            datum.itemName = ItemName;
            datum.Insert();

            c.Account.GamePoints -= CashShopFactory.GetItemData(ItemID).BargainPrice;
            c.Account.Save();

            chr.Items.Add(new Item(ItemID, IsLocked, 0, -1, (byte)InventoryType.ItemType.Cash, chr.Items.GetNextFreeSlot(InventoryType.ItemType.Cash), Quantity));
            chr.Items.Save();
            CashShopPacket.BuyCommodity(c);
            CashShopPacket.MgameCash(c);
            CashShopPacket.GuiHonCash(c);
            InventoryPacket.getInvenCash(c);
        }

        public static void Gifts_Req(InPacket lea, Client c)
        {
            int ItemID = lea.ReadInt();
            string ItemName = lea.ReadString(62);
            string CharacterName = lea.ReadString(20);
            int Type = 1;

            if (CashShopFactory.GetItemData(ItemID) == null)
                return;

            c.Account.GamePoints -= CashShopFactory.GetItemData(ItemID).BargainPrice;
            c.Account.Save();

            dynamic datum = new Datum("gifts");
            datum.name = CharacterName;
            datum.itemID = ItemID;
            datum.itemName = ItemName;
            datum.receive = 0;
            datum.Insert();

            CashShopPacket.Gifts(c, Type);
            CashShopPacket.MgameCash(c);
            CashShopPacket.GuiHonCash(c);
        }

        public static void CommodityToInventory_Req(InPacket lea, Client c)
        {
            var chr = c.Character;
            int Slot = lea.ReadInt();
            Item Source = chr.Items.getItem((byte)InventoryType.ItemType.Cash, (byte)Slot);

            if (Source.ItemID / 100000 == 90)
            {   // 頭髮
                chr.Hair = Source.ItemID;
                chr.Items.Remove(Source.Type, Source.Slot);
                chr.Items.Save();
                CashShopPacket.CommodityToInventory(c);
                InventoryPacket.getInvenCash(c);
                InventoryHandler.UpdateInventory(c, (byte)InventoryType.ItemType.Equip);
                return;
            }
            else if (Source.ItemID / 100000 == 91)
            {   // 眼睛
                chr.Eyes = Source.ItemID;
                chr.Items.Remove(Source.Type, Source.Slot);
                chr.Items.Save();
                CashShopPacket.CommodityToInventory(c);
                InventoryPacket.getInvenCash(c);
                InventoryHandler.UpdateInventory(c, (byte)InventoryType.ItemType.Equip);
                return;
            }
            else if (Source.ItemID / 100000 == 92 || Source.ItemID == 7820501)
            {
                // 寵物
                chr.Pets.Add(new Pet(Source.ItemID, 0, "", 1, 100, 100, 0, (byte)InventoryType.ItemType.Pet5, chr.Pets.GetNextFreeSlot(InventoryType.ItemType.Pet5)));
                chr.Items.Remove(Source.Type, Source.Slot);
                chr.Pets.Save();
                chr.Items.Save();
                CashShopPacket.CommodityToInventory(c);
                InventoryPacket.getInvenCash(c);
                InventoryHandler.UpdateInventory(c, (byte)InventoryType.ItemType.Pet5);
                return;
            }

            byte TargetType = InventoryType.getItemType(Source.ItemID);
            byte TargetSlot = chr.Items.GetNextFreeSlot((InventoryType.ItemType)InventoryType.getItemType(Source.ItemID));
            Source.Type = TargetType;
            Source.Slot = TargetSlot;
            chr.Items.Save();
            CashShopPacket.CommodityToInventory(c);
            InventoryPacket.getInvenCash(c);
            InventoryHandler.UpdateInventory(c, TargetType);
        }

        public static void MgameCash_Req(InPacket lea, Client c)
        {
            CashShopPacket.MgameCash(c);
            CashShopPacket.GuiHonCash(c);
        }

        public static void AbilityRecover_Req(InPacket lea, Client c)
        {
            short Slot = lea.ReadShort();
            short Type = lea.ReadShort();
            var chr = c.Character;

            switch (Type)
            {
                case 0: // 力量還原本
                    if (chr.Str < 4)
                        return;
                    chr.Str--;
                    chr.AbilityBonus++;
                    chr.Items.Remove(3, (byte)Slot, 1);
                    break;
                case 1: // 精力還原本
                    if (chr.Dex < 4)
                        return;
                    chr.Dex--;
                    chr.AbilityBonus++;
                    chr.Items.Remove(3, (byte)Slot, 1);
                    break;
                case 2: // 氣力還原本
                    if (chr.Vit < 4)
                        return;
                    chr.Vit--;
                    chr.AbilityBonus++;
                    chr.Items.Remove(3, (byte)Slot, 1);
                    break;
                case 3: // 智力還原本
                    if (chr.Int < 4)
                        return;
                    chr.Int--;
                    chr.AbilityBonus++;
                    chr.Items.Remove(3, (byte)Slot, 1);
                    break;
            }
            InventoryHandler.UpdateInventory(c, 3);
            StatusPacket.getStatusInfo(c);
        }

        public static void CheckName_Req(InPacket lea, Client c)
        {
            string Name = lea.ReadString(20);
            bool IsExist = Database.Exists("Characters", "name = '{0}'", Name);
            CashShopPacket.CheckName(c, IsExist ? 1 : 0);
        }

        public static void Dismantle_Req(InPacket lea, Client c)
        {
            int Type = lea.ReadInt();
            int Slot = lea.ReadInt();
            var chr = c.Character;
            Item Item = chr.Items.getItem((byte)Type, (byte)Slot);
            Item.IsLocked = 0;
            InventoryHandler.UpdateInventory(c, (byte)Type);
        }
    }
}
