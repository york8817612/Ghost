using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;

namespace Server.Handler
{
    public static class PlayerShopHandler
    {
        public static void OpenShop_Req(InPacket lea, Client c)
        {
            int Slots = 6;
            PlayerShopPacket.OpenShop(c, Slots);
        }

        public static void SellStart_Req(InPacket lea, Client c)
        {
            string Name = lea.ReadString(40);
            var chr = c.Character;

            //if (!(chr.MapX == 1 && chr.MapY == 51) && !(chr.MapX == 1 && chr.MapY == 52) && !(chr.MapX == 1 && chr.MapY == 53) && !(chr.MapX == 1 && chr.MapY == 54) && !(chr.MapX == 1 && chr.MapY == 55))
            //    return;

            Map map = MapFactory.GetMap(chr.MapX, chr.MapY);
            CharacterShop PlayerShop = new CharacterShop(Name);
            for (int i = 0; i < 12; i++)
            {
                int SourceType = lea.ReadShort();
                int SourceSlot = lea.ReadShort();
                int Quantity = lea.ReadInt();
                int Price = lea.ReadInt();
                Item Source = chr.Items.getItem((byte)SourceType, (byte)SourceSlot);
                if (Source != null)
                {
                    PlayerShop.Add(new ShopData(Source.ItemID, Quantity, SourceType, SourceSlot, (byte)i, Source.Spirit, Source.Level1, Source.Level2, Source.Level3, Source.Level4, Source.Level5, Source.Level6, Source.Level7, Source.Level8, Source.Level9, Source.Level10, Source.Fusion, Source.IsLocked, Source.Icon, Source.Term, Price));
                }
            }
            chr.Shop = PlayerShop;
            foreach (Character All in map.Characters)
            {
                PlayerShopPacket.SellStart(All.Client, chr, Name);
            }
        }

        public static void SellEnd_Req(InPacket lea, Client c)
        {
            var chr = c.Character;
            Map map = MapFactory.GetMap(chr.MapX, chr.MapY);
            foreach (Character All in map.Characters)
            {
                PlayerShopPacket.SellEnd(All.Client, chr);
            }
            chr.Shop = null;
        }

        public static void ShopInfo_Req(InPacket lea, Client c)
        {
            int CharacterID = lea.ReadInt();
            Map map = MapFactory.GetMap(c.Character.MapX, c.Character.MapY);
            Character Seller = null;
            foreach (Character chr in map.Characters)
            {
                if (chr.CharacterID == CharacterID)
                    Seller = chr;
            }
            PlayerShopPacket.ShopInfo(c, Seller, CharacterID);
        }

        public static void Buy_Req(InPacket lea, Client c)
        {
            int CharacterID = lea.ReadInt();
            int ItemID = lea.ReadInt();
            int Slot = lea.ReadShort();
            int Quantity = lea.ReadShort();
            var chr = c.Character;

            try
            {
                Map map = MapFactory.GetMap(chr.MapX, chr.MapY);
                Character Seller = null;
                foreach (Character find in map.Characters)
                {
                    if (find.CharacterID == CharacterID)
                        Seller = find;
                }

                ShopData Item = Seller.Shop.Find(i => ItemID == i.ItemID && Slot == i.TargetSlot);
                byte Type = InventoryType.getItemType(ItemID);
                byte FreeSlot = chr.Items.GetNextFreeSlot((InventoryType.ItemType)Type);

                if (Item.Quantity < Quantity || Item == null)
                {
                    PlayerShopPacket.Buy(c, 0);
                    return;
                }

                chr.Money -= (Item.Price * Quantity);
                InventoryPacket.getInvenMoney(c, chr.Money, -(Item.Price * Quantity));
                chr.Items.Add(new Item(Item.ItemID, (short)Quantity, Item.Spirit, Item.Level1, Item.Level2, Item.Level3, Item.Level4, Item.Level5, Item.Level6, Item.Level7, Item.Level8, Item.Level9, Item.Level10, Item.Fusion, Item.IsLocked, Item.Icon, Item.Term, Type, FreeSlot));
                InventoryHandler.UpdateInventory(c, Type);
                //Seller.Shop.Remove(Item);
                Seller.Items.Remove((byte)Item.SourceType, (byte)Item.SourceSlot);
                Seller.Items.Add(new Item(Item.ItemID, (short)(Item.Quantity - Quantity), Item.Spirit, Item.Level1, Item.Level2, Item.Level3, Item.Level4, Item.Level5, Item.Level6, Item.Level7, Item.Level8, Item.Level9, Item.Level10, Item.Fusion, Item.IsLocked, Item.Icon, Item.Term, (byte)Item.SourceType, (byte)Item.SourceSlot));
                Item.Quantity = Item.Quantity - Quantity;
                Seller.Shop.Money += (Item.Price * Quantity);
                Seller.Money += (Item.Price * Quantity);
                PlayerShopPacket.ShopInfo(c, Seller, CharacterID);
                InventoryHandler.UpdateInventory(Seller.Client, (byte)Item.SourceType);
                PlayerShopPacket.SellInfo(Seller.Client);
                InventoryPacket.getInvenMoney(Seller.Client, Seller.Money, Item.Price * Quantity);

                PlayerShopPacket.Buy(c, 1);
            }
            catch
            {
                PlayerShopPacket.Buy(c, 0);
                return;
            }
        }
    }
}