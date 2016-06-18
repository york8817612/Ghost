using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Net;
using Server.Packet;

namespace Server.Handler
{
    public static class CashShopHandler
    {
        public static void CashShopList_Req(InPacket lea, Client c)
        {
            var chr = c.Character;
            //if (chr.MapX != 77 && chr.MapY != 1)
            //    return;
            //CashShopPacket.CashShopList1(c); // 人物
            //CashShopPacket.CashShopList2(c); // 裝備
            //CashShopPacket.CashShopList3(c); // 能力
            //CashShopPacket.CashShopList4(c); // 靈物
            //CashShopPacket.CashShopList5(c); // 寶牌
            //CashShopPacket.CashShopList6(c);
            //CashShopPacket.CashShopList7(c); // 紅利積點
            //CashShopPacket.CashShopList8(c);
            //CashShopPacket.CashShopList9(c);
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
                chr.Pets.Add(new Pet(Source.ItemID, 0, "", 1, 100, 100, 0, (byte)InventoryType.ItemType.Pet5, chr.Pets.GetNextFreeSlot(InventoryType.ItemType.Pet5), chr.Pets.GetNextFreeSlot(InventoryType.ItemType.Pet5)));
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

        public static void BuyCommodity_Req(InPacket lea, Client c)
        {
            int ItemID = lea.ReadInt();
            string Name = lea.ReadString(62);
            var chr = c.Character;
            chr.Items.Add(new Item(ItemID, true, 0, -1, (byte)InventoryType.ItemType.Cash, chr.Items.GetNextFreeSlot(InventoryType.ItemType.Cash)));
            chr.Items.Save();
            CashShopPacket.BuyCommodity(c);
            InventoryPacket.getInvenCash(c);
        }
    }
}
