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
                // 個人接收
                foreach (Item Item in chr.Trader.Trade.Item)
                {
                    byte Type = Item.Type;
                    byte Slot = chr.Items.GetNextFreeSlot((InventoryType.ItemType)Type);
                    chr.Items.Add(new Item(Item.ItemID, Type, Slot, chr.Trader.Trade.TargetQuantity[m]));
                    InventoryHandler.UpdateInventory(c, Item.Type);
                    m++;
                }
                // 對方接收
                foreach (Item Item in chr.Trade.Item)
                {
                    byte Type = Item.Type;
                    byte Slot = chr.Trader.Items.GetNextFreeSlot((InventoryType.ItemType)Type);
                    chr.Trader.Items.Add(new Item(Item.ItemID, Type, Slot, chr.Trade.TargetQuantity[l]));
                    InventoryHandler.UpdateInventory(chr.Trader.Client, Item.Type);
                    l++;
                }
            }
            catch
            { // 交易失敗
                // 個人
                foreach (Item Item in chr.Trade.Item)
                {
                    Item i = chr.Items.GetItem(Item.Type, Item.Slot);
                    if (i != null)
                    {
                        // 合併消費物品、其他物品
                        if (chr.Trade.SourceQuantity[j] + chr.Trade.TargetQuantity[j] <= 100)
                        {
                            chr.Items.Remove(Item.Type, Item.Slot);
                            chr.Items.Add(new Item(Item.ItemID, Item.Type, Item.Slot, chr.Trade.SourceQuantity[j]));
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
                    Item i = chr.Trader.Items.GetItem(Item.Type, Item.Slot);
                    if (i != null)
                    {
                        // 合併消費物品、其他物品
                        if (chr.Trader.Trade.SourceQuantity[k] + chr.Trader.Trade.TargetQuantity[k] <= 100)
                        {
                            chr.Trader.Items.Remove(Item.Type, Item.Slot);
                            chr.Trader.Items.Add(new Item(Item.ItemID, Item.Type, Item.Slot, chr.Trader.Trade.SourceQuantity[k]));
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
            foreach (Item Item in chr.Trade.Item)
            {
                Item i = chr.Items.GetItem(Item.Type, Item.Slot);
                if (i != null)
                {
                    // 合併消費物品、其他物品
                    if (chr.Trade.SourceQuantity[j] + chr.Trade.TargetQuantity[j] <= 100)
                    {
                        chr.Items.Remove(Item.Type, Item.Slot);
                        chr.Items.Add(new Item(Item.ItemID, Item.Type, Item.Slot, chr.Trade.SourceQuantity[j]));
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
                Item i = chr.Trader.Items.GetItem(Item.Type, Item.Slot);
                if (i != null)
                {
                    // 合併消費物品、其他物品
                    if (chr.Trader.Trade.SourceQuantity[k] + chr.Trader.Trade.TargetQuantity[k] <= 100)
                    {
                        chr.Trader.Items.Remove(Item.Type, Item.Slot);
                        chr.Trader.Items.Add(new Item(Item.ItemID, Item.Type, Item.Slot, chr.Trader.Trade.SourceQuantity[k]));
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
            Item Source = chr.Items.GetItem((byte)SourceType, (byte)SourceSlot);
            chr.Trade.SourceQuantity.Add(Source.Quantity);

            if (SourceType == 0x64 && SourceSlot == 0x64)
            {   // Money欄位
                chr.Money -= Quantity;
                chr.Trade.Money = Quantity;
                InventoryPacket.getInvenMoney(c, chr.Money, -Quantity);
            }

            if (Source != null)
            {
                chr.Trade.Item.Add(Source);
                chr.Trade.TargetQuantity.Add((short)Quantity);
                chr.Items.Remove((byte)SourceType, (byte)SourceSlot, Quantity);
                InventoryHandler.UpdateInventory(c, (byte)SourceType);
            }

            TradePacket.TradePutItem(c);
            TradePacket.TradePutItem(chr.Trader.Client);
        }

        public static void TradeSuccessful(InPacket lea, Client c)
        {
            var chr = c.Character;
            TradePacket.TradeSuccessful(c);
            TradePacket.TradeSuccessful(chr.Trader.Client);
        }
    }
}
