using Server.Common.Constants;
using Server.Common.Data;
using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;
using System.Collections.Generic;

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
            string Name = lea.ReadString(62);
            var chr = c.Character;

            if (CashShopFactory.GetItemData(ItemID) == null)
                return;

            c.Account.GamePoints -= CashShopFactory.GetItemData(ItemID).BargainPrice;
            chr.Items.Add(new Item(ItemID, (ItemID / 100000) == 92 ? false : true, 0, -1, (byte)InventoryType.ItemType.Cash, chr.Items.GetNextFreeSlot(InventoryType.ItemType.Cash)));
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
            Item Source = chr.Items.GetItem((byte)InventoryType.ItemType.Cash, (byte)Slot);

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
            } else if (Source.ItemID / 100000 == 92)
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

        public static void CheckName_Req(InPacket lea, Client c)
        {
            string Name = lea.ReadString(20);
            bool IsExist = Database.Exists("Characters", "name = '{0}'", Name);
            CashShopPacket.CheckName(c, IsExist ? 1 : 0);
        }
    }
}
