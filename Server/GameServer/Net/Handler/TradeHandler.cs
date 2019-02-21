using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;

namespace Server.Handler
{
    public static class TradeHandler
    {
        public static void TradeInvite(InPacket lea, Client c)
        {
            int CharacterID = lea.ReadInt();
            Map map = MapFactory.GetMap(c.Character.MapX, c.Character.MapY);

            foreach (Character chr in map.Characters)
            {
                if (chr.CharacterID == CharacterID)
                {
                    c.Character.Trader = chr;
                    chr.Trader = c.Character;
                    TradePacket.TradeInvite(chr.Client, c.Character.CharacterID);
                    break;
                }
            }
        }

        public static void TradeInviteResponses(InPacket lea, Client c)
        {
            int Respons = lea.ReadInt();
            var chr = c.Character;

            if (Respons == 1)
            {
                chr.Trade = new CharacterTrade();
                chr.Trader.Trade = new CharacterTrade();
            }

            if (Respons == 1)
                TradePacket.TradeInviteResponses(c, Respons);

            TradePacket.TradeInviteResponses(c.Character.Trader.Client, Respons);
        }

        public static void TradeReady(InPacket lea, Client c)
        {
            var chr = c.Character;
            TradePacket.TradeReady(chr.Trader.Client);
            TradePacket.TradeInviteResponses(chr.Trader.Client, 2);
            TradePacket.TradeConfirm(chr.Trader.Client);
        }

        public static void TradeConfirm(InPacket lea, Client c)
        {
            var chr = c.Character;
            int j = 0;
            int k = 0;
            int m = 0;
            int l = 0;

            try
            { // 交易成功

                // Item

                // 個人接收
                foreach (Item Item in chr.Trader.Trade.Item)
                {
                    byte Type = Item.Type;
                    byte Slot = chr.Items.GetNextFreeSlot((InventoryType.ItemType)Type);
                    chr.Items.Add(new Item(Item.ItemID, chr.Trader.Trade.TargetQuantity[m], Item.Spirit, Item.Level1, Item.Level2, Item.Level3, Item.Level4, Item.Level5, Item.Level6, Item.Level7, Item.Level8, Item.Level9, Item.Level10, Item.Fusion, Item.IsLocked, Item.Icon, Item.Term, Type, Slot));
                    InventoryHandler.UpdateInventory(c, Item.Type);
                    m++;
                }
                // 對方接收
                foreach (Item Item in chr.Trade.Item)
                {
                    byte Type = Item.Type;
                    byte Slot = chr.Trader.Items.GetNextFreeSlot((InventoryType.ItemType)Type);
                    chr.Trader.Items.Add(new Item(Item.ItemID, chr.Trade.TargetQuantity[l], Item.Spirit, Item.Level1, Item.Level2, Item.Level3, Item.Level4, Item.Level5, Item.Level6, Item.Level7, Item.Level8, Item.Level9, Item.Level10, Item.Fusion, Item.IsLocked, Item.Icon, Item.Term, Type, Slot));
                    InventoryHandler.UpdateInventory(chr.Trader.Client, Item.Type);
                    l++;
                }

                // Money

                // 個人
                chr.Money += chr.Trader.Trade.Money;
                // 對方
                chr.Trader.Money += chr.Trade.Money;
                // 個人
                if (chr.Trader.Trade.Money > 0)
                    InventoryPacket.getInvenMoney(c, chr.Money, chr.Trader.Trade.Money);
                // 對方
                if (chr.Trade.Money > 0)
                    InventoryPacket.getInvenMoney(chr.Trader.Client, chr.Trader.Money, chr.Trade.Money);
            }
            catch
            { // 交易失敗

                // Item

                // 個人
                foreach (Item Item in chr.Trade.Item)
                {
                    Item i = chr.Items.getItem(Item.Type, Item.Slot);
                    if (i != null)
                    {
                        // 合併消費物品、其他物品
                        if (chr.Trade.SourceQuantity[j] + chr.Trade.TargetQuantity[j] <= 100)
                        {
                            chr.Items.Remove(Item.Type, Item.Slot);
                            chr.Items.Add(new Item(Item.ItemID, chr.Trade.SourceQuantity[j], Item.Spirit, Item.Level1, Item.Level2, Item.Level3, Item.Level4, Item.Level5, Item.Level6, Item.Level7, Item.Level8, Item.Level9, Item.Level10, Item.Fusion, Item.IsLocked, Item.Icon, Item.Term, Item.Type, Item.Slot));
                        }
                        else
                        {
                            chr.Items.Add(Item);
                        }
                    }
                    else
                    {
                        chr.Items.Add(Item);
                    }
                    InventoryHandler.UpdateInventory(c, Item.Type);
                    j++;
                }
                // 對方
                foreach (Item Item in chr.Trader.Trade.Item)
                {
                    Item i = chr.Trader.Items.getItem(Item.Type, Item.Slot);
                    if (i != null)
                    {
                        // 合併消費物品、其他物品
                        if (chr.Trader.Trade.SourceQuantity[k] + chr.Trader.Trade.TargetQuantity[k] <= 100)
                        {
                            chr.Trader.Items.Remove(Item.Type, Item.Slot);
                            chr.Trader.Items.Add(new Item(Item.ItemID, chr.Trader.Trade.SourceQuantity[k], Item.Spirit, Item.Level1, Item.Level2, Item.Level3, Item.Level4, Item.Level5, Item.Level6, Item.Level7, Item.Level8, Item.Level9, Item.Level10, Item.Fusion, Item.IsLocked, Item.Icon, Item.Term, Item.Type, Item.Slot));
                        }
                        else
                        {
                            chr.Trader.Items.Add(Item);
                        }
                    }
                    else
                    {
                        chr.Trader.Items.Add(Item);
                    }
                    InventoryHandler.UpdateInventory(chr.Trader.Client, Item.Type);
                    k++;
                }

                // Money

                // 個人
                chr.Money += chr.Trade.Money;
                // 對方
                chr.Trader.Money += chr.Trader.Trade.Money;
                // 個人
                if (chr.Trade.Money > 0)
                    InventoryPacket.getInvenMoney(c, chr.Money, chr.Trade.Money);
                // 對方
                if (chr.Trader.Trade.Money > 0)
                    InventoryPacket.getInvenMoney(chr.Trader.Client, chr.Trader.Money, chr.Trader.Trade.Money);

                TradePacket.TradeFail(c);
                TradePacket.TradeFail(chr.Trader.Client);
                return;
            }
            TradePacket.TradeSuccessful(c);
            TradePacket.TradeSuccessful(chr.Trader.Client);
        }

        public static void TradeCancel(InPacket lea, Client c)
        {
            var chr = c.Character;
            int j = 0;

            // 個人
            chr.Money += chr.Trade.Money;
            // 對方
            chr.Trader.Money += chr.Trader.Trade.Money;
            // 個人
            if (chr.Trade.Money > 0)
                InventoryPacket.getInvenMoney(c, chr.Money, chr.Trade.Money);
            // 對方
            if (chr.Trader.Trade.Money > 0)
                InventoryPacket.getInvenMoney(chr.Trader.Client, chr.Trader.Money, chr.Trader.Trade.Money);

            // 個人
            foreach (Item Item in chr.Trade.Item)
            {
                Item i = chr.Items.getItem(Item.Type, Item.Slot);
                if (i != null)
                {
                    // 合併消費物品、其他物品
                    if (chr.Trade.SourceQuantity[j] + chr.Trade.TargetQuantity[j] <= 100)
                    {
                        chr.Items.Remove(Item.Type, Item.Slot);
                        chr.Items.Add(new Item(Item.ItemID, chr.Trade.SourceQuantity[j], Item.Spirit, Item.Level1, Item.Level2, Item.Level3, Item.Level4, Item.Level5, Item.Level6, Item.Level7, Item.Level8, Item.Level9, Item.Level10, Item.Fusion, Item.IsLocked, Item.Icon, Item.Term, Item.Type, Item.Slot));
                    }
                    else
                    {
                        chr.Items.Add(Item);
                    }
                }
                else
                {
                    chr.Items.Add(Item);
                }
                InventoryHandler.UpdateInventory(c, Item.Type);
                j++;
            }

            int k = 0;
            // 對方
            foreach (Item Item in chr.Trader.Trade.Item)
            {
                Item i = chr.Trader.Items.getItem(Item.Type, Item.Slot);
                if (i != null)
                {
                    // 合併消費物品、其他物品
                    if (chr.Trader.Trade.SourceQuantity[k] + chr.Trader.Trade.TargetQuantity[k] <= 100)
                    {
                        chr.Trader.Items.Remove(Item.Type, Item.Slot);
                        chr.Trader.Items.Add(new Item(Item.ItemID, chr.Trader.Trade.SourceQuantity[k], Item.Spirit, Item.Level1, Item.Level2, Item.Level3, Item.Level4, Item.Level5, Item.Level6, Item.Level7, Item.Level8, Item.Level9, Item.Level10, Item.Fusion, Item.IsLocked, Item.Icon, Item.Term, Item.Type, Item.Slot));
                    }
                    else
                    {
                        chr.Trader.Items.Add(Item);
                    }
                }
                else
                {
                    chr.Trader.Items.Add(Item);
                }
                InventoryHandler.UpdateInventory(chr.Trader.Client, Item.Type);
                k++;
            }

            TradePacket.TradeCancel(chr.Trader.Client);
            chr.Trade = null;
            chr.Trader = null;
        }

        public static void TradePutItem(InPacket lea, Client c)
        {
            var chr = c.Character;
            int SourceType = lea.ReadShort();
            int SourceSlot = lea.ReadShort();
            int Quantity = lea.ReadInt();

            if (SourceType == 0x64 && SourceSlot == 0x64)
            {   // Money欄位
                chr.Money -= Quantity;
                chr.Trade.Money = Quantity;
                InventoryPacket.getInvenMoney(c, chr.Money, -Quantity);
                TradePacket.TradePutItem(c);
                TradePacket.TradePutItem(chr.Trader.Client);
                return;
            }

            Item Source = chr.Items.getItem((byte)SourceType, (byte)SourceSlot);
            chr.Trade.SourceQuantity.Add(Source.Quantity);

            if (Source != null)
            {
                chr.Trade.Item.Add(Source);
                chr.Trade.TargetQuantity.Add((short)Quantity);
                chr.Items.Remove((byte)SourceType, (byte)SourceSlot, Quantity);
                InventoryHandler.UpdateInventory(c, (byte)SourceType);
                TradePacket.TradePutItem(c);
                TradePacket.TradePutItem(chr.Trader.Client);
            }
        }

        public static void TradeSuccessful(InPacket lea, Client c)
        {
            var chr = c.Character;
            TradePacket.TradeSuccessful(c);
            TradePacket.TradeSuccessful(chr.Trader.Client);
        }

        public static void TradeEventItem(InPacket lea, Client c)
        {
            lea.ReadShort(); // 活動ID ?
            byte Type = lea.ReadByte();
            byte Slot = lea.ReadByte();
            int Quantity = lea.ReadInt();
            var chr = c.Character;

            Item Item = null;
            foreach (Item im in chr.Items.getItems())
            {
                if (im.Type == 4 && im.ItemID == 8990049 && im.Quantity >= Quantity)
                {
                    Item = im;
                    break;
                }
            }

            if (Item == null && Quantity <= 100)
                return;

            switch (Quantity)
            {
                case 5:
                    chr.Rank += 1;
                    StatusPacket.UpdateFame(c, 1);
                    break;
                case 8:
                    chr.Rank += 2;
                    StatusPacket.UpdateFame(c, 2);
                    break;
                case 12:
                    chr.Rank += 3;
                    StatusPacket.UpdateFame(c, 3);
                    break;
                case 20:
                    chr.Items.Add(new Item(8510071, (byte)InventoryType.ItemType.Equip2, chr.Items.GetNextFreeSlot(InventoryType.ItemType.Equip2)));
                    InventoryHandler.UpdateInventory(c, 2);
                    InventoryPacket.ClearDropItem(c, chr.CharacterID, -1, 8510071);
                    break;
                case 30:
                    chr.Items.Add(new Item(8510081, (byte)InventoryType.ItemType.Equip2, chr.Items.GetNextFreeSlot(InventoryType.ItemType.Equip2)));
                    InventoryHandler.UpdateInventory(c, 2);
                    InventoryPacket.ClearDropItem(c, chr.CharacterID, -1, 8510081);
                    break;
                case 40:
                    chr.Items.Add(new Item(8510091, (byte)InventoryType.ItemType.Equip2, chr.Items.GetNextFreeSlot(InventoryType.ItemType.Equip2)));
                    InventoryHandler.UpdateInventory(c, 2);
                    InventoryPacket.ClearDropItem(c, chr.CharacterID, -1, 8510091);
                    break;
                case 50:
                    chr.Items.Add(new Item(8510101, (byte)InventoryType.ItemType.Equip2, chr.Items.GetNextFreeSlot(InventoryType.ItemType.Equip2)));
                    InventoryHandler.UpdateInventory(c, 2);
                    InventoryPacket.ClearDropItem(c, chr.CharacterID, -1, 8510101);
                    break;
                case 60:
                    chr.Money += 2000000;
                    InventoryPacket.getInvenMoney(c, chr.Money, 2000000);
                    break;
                case 100:
                    chr.Money += 4000000;
                    InventoryPacket.getInvenMoney(c, chr.Money, 4000000);
                    break;
                case 200:
                    chr.Money += 8200000;
                    InventoryPacket.getInvenMoney(c, chr.Money, 8200000);
                    break;
                case 300:
                    chr.Money += 13000000;
                    InventoryPacket.getInvenMoney(c, chr.Money, 13000000);
                    break;
                case 500:
                    chr.Money += 24000000;
                    InventoryPacket.getInvenMoney(c, chr.Money, 24000000);
                    break; 
            }

            if (Quantity > 100)
            {
                Item Target1 = null;
                Item Target2 = null;
                Item Target3 = null;
                Item Target4 = null;
                Item Target5 = null;
                int i = 0;
                foreach (Item Target in chr.Items.getItems())
                {
                    if (i == 0 && Target.ItemID == 8990049 && Target.Quantity == 100)
                    {
                        Target1 = Target;
                        i++;
                    }
                    else if (i == 1 && Target.ItemID == 8990049 && Target.Quantity == 100)
                    {
                        Target2 = Target;
                        i++;
                    }
                    else if (i == 2 && (Quantity == 300 || Quantity == 500) && Target.ItemID == 8990049 && Target.Quantity == 100)
                    {
                        Target3 = Target;
                        i++;
                    }
                    else if (i == 3 && Quantity == 500 && Target.ItemID == 8990049 && Target.Quantity == 100)
                    {
                        Target4 = Target;
                        i++;
                    }
                    else if (i == 4 && Quantity == 500 && Target.ItemID == 8990049 && Target.Quantity == 100)
                    {
                        Target5 = Target;
                        i++;
                    }
                    else if (i == 5)
                    {
                        break;
                    }
                }
                if (Target1 != null)
                    chr.Items.Remove(Target1.Type, Target1.Slot, 100);
                if (Target2 != null)
                    chr.Items.Remove(Target2.Type, Target2.Slot, 100);
                if (Target3 != null)
                    chr.Items.Remove(Target3.Type, Target3.Slot, 100);
                if (Target4 != null)
                    chr.Items.Remove(Target4.Type, Target4.Slot, 100);
                if (Target5 != null)
                    chr.Items.Remove(Target5.Type, Target5.Slot, 100);
            }
            else
            {
                chr.Items.Remove(Type, Slot, Quantity);
            }
            InventoryHandler.UpdateInventory(c, Type);
        }
    }
}
