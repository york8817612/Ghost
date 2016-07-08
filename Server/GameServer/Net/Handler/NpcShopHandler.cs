using Server.Common.Constants;
using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;

namespace Server.Handler
{
    public static class NpcShopHandler
    {
        public static void Buy_Req(InPacket lea, Client gc)
        {
            lea.ReadInt();
            int ItemID = lea.ReadInt();
            int Quantity = lea.ReadInt();
            int money = 0;
            switch (ItemID / 100000)
            {
                case 75: // 耳環
                    money = ItemFactory.earringData[ItemID].Price;
                    break;
                case 79: // 武器
                case 80: // 武器
                    money = ItemFactory.weaponData[ItemID].Price;
                    break;
                case 81: // 衣服
                    money = ItemFactory.topData[ItemID].Price;
                    break;
                case 84: // 披風
                    money = ItemFactory.capeData[ItemID].Price;
                    break;
                case 86: // 帽子
                    money = ItemFactory.hatData[ItemID].Price;
                    break;
                case 87: // 面具
                    money = ItemFactory.maskData[ItemID].Price;
                    break;
                case 93: // 武器
                    money = ItemFactory.weaponData[ItemID].Price;
                    break;
                case 94: // 鬍子
                    money = ItemFactory.beardData[ItemID].Price;
                    break;
                case 95: // 服裝
                    money = ItemFactory.clothingData[ItemID].Price;
                    break;
                case 82: // 戒指
                    money = ItemFactory.ringData[ItemID].Price;
                    break;
                case 83: // 項鍊
                    money = ItemFactory.necklaceData[ItemID].Price;
                    break;
                case 85: // 封印箱
                    money = ItemFactory.soulData[ItemID].Price;
                    break;
                case 11: // 拼圖
                    money = ItemFactory.jigsawData[ItemID].Price;
                    break;
                case 88: // 消耗
                    money = ItemFactory.useData[ItemID].Price;
                    break;
                case 89: // 其他
                    money = ItemFactory.etcData[ItemID].Price;
                    break;
                default:
                    Log.Error("未知的物品型態:" + ItemID / 100000);
                    break;
            }
            if (gc.Character.Money >= (money * Quantity))
            {
                byte Type = (byte)InventoryType.getItemType(ItemID);

                if (ItemID >= 8880011 && ItemID <= 8880101) // 飛鏢
                    Quantity *= 100;

                Item finditem = null;
                foreach (Item it in gc.Character.Items)
                {
                    if (it.ItemID == ItemID)
                    {
                        finditem = it;
                    }
                }
                if (((Type == (byte)InventoryType.ItemType.Spend3) || (Type == (byte)InventoryType.ItemType.Other4)) && (finditem != null))
                {
                    // 合併消費物品跟其他物品
                    if ((finditem.Quantity + Quantity) > 100)
                    {
                        int newqu = Quantity - (100 - finditem.Quantity);
                        gc.Character.Items[(InventoryType.ItemType)finditem.Type, finditem.Slot].Quantity = (short)100;
                        byte Slot = gc.Character.Items.GetNextFreeSlot((InventoryType.ItemType)Type);
                        Item oItem = new Item(ItemID, Type, Slot, (short)newqu);
                        gc.Character.Items.Add(oItem);
                    }
                    else
                    {
                        gc.Character.Items[(InventoryType.ItemType)finditem.Type, finditem.Slot].Quantity += (short)Quantity;
                    }
                }
                else
                {
                    byte Slot = gc.Character.Items.GetNextFreeSlot((InventoryType.ItemType)Type);
                    Item oItem = new Item(ItemID, Type, Slot, (short)Quantity);
                    gc.Character.Items.Add(oItem);
                }

                gc.Character.Money -= (money * Quantity);
                InventoryPacket.getInvenMoney(gc, gc.Character.Money, -(money * Quantity));                
                InventoryHandler.UpdateInventory(gc, Type);
            }
        }

        public static void Sell_Req(InPacket lea, Client gc)
        {
            int ItemID = lea.ReadInt();
            byte Type = lea.ReadByte();
            byte Slot = lea.ReadByte();
            short Quantity = lea.ReadShort();
            if (Quantity > 100)
                return;

            int Money = 0;
            switch (ItemID / 100000)
            {
                case 75: // 耳環
                    Money = ItemFactory.earringData[ItemID].Price;
                    Money /= 5;
                    break;
                case 79: // 武器
                case 80: // 武器
                    Money = ItemFactory.weaponData[ItemID].Price;
                    Money /= 5;
                    break;
                case 81: // 衣服
                    Money = ItemFactory.topData[ItemID].Price;
                    Money /= 5;
                    break;
                case 84: // 披風
                    Money = ItemFactory.capeData[ItemID].Price;
                    Money /= 5;
                    break;
                case 86: // 帽子
                    Money = ItemFactory.hatData[ItemID].Price;
                    Money /= 5;
                    break;
                case 87: // 面具
                    Money = ItemFactory.maskData[ItemID].Price;
                    Money /= 5;
                    break;
                case 93: // 武器
                    Money = ItemFactory.weaponData[ItemID].Price;
                    Money /= 5;
                    break;
                case 94: // 鬍子
                    Money = ItemFactory.beardData[ItemID].Price;
                    Money /= 5;
                    break;
                case 95: // 服裝
                    Money = ItemFactory.clothingData[ItemID].Price;
                    Money /= 5;
                    break;
                case 82: // 戒指
                    Money = ItemFactory.ringData[ItemID].Price;
                    Money /= 5;
                    break;
                case 83: // 項鍊
                    Money = ItemFactory.necklaceData[ItemID].Price;
                    Money /= 5;
                    break;
                case 85: // 封印箱
                    Money = ItemFactory.soulData[ItemID].Price;
                    Money /= 5;
                    break;
                case 11: // 拼圖
                    Money = ItemFactory.jigsawData[ItemID].Price;
                    break;
                case 88: // 消耗
                    Money = ItemFactory.useData[ItemID].Price;
                    Money /= 5;
                    break;
                case 89: // 其他
                    Money = ItemFactory.etcData[ItemID].Price;
                    break;
                default:
                    Log.Error("未知的物品型態:" + ItemID / 100000);
                    break;
            }

            if (ItemID == 8880011 || ItemID == 8880021 || ItemID == 8880031 || ItemID == 8880041 || ItemID == 8880051 || ItemID == 8880061 || ItemID == 8880071 || ItemID == 8880081 || ItemID == 8880091 || ItemID == 8880101)
                Money = 0;

            Item Source = gc.Character.Items.getItem(Type, Slot);

            if (Source != null)
            {
                if (Source.Quantity > Quantity)
                {
                    if (Quantity <= 0)
                        return;
                    gc.Character.Items[(InventoryType.ItemType)Source.Type, Source.Slot].Quantity -= Quantity;
                }
                else
                {
                    if (Quantity > Source.Quantity)
                        return;
                    gc.Character.Items.Remove(Type, Slot);
                }
                gc.Character.Money += (Money * Quantity);
                InventoryPacket.getInvenMoney(gc, gc.Character.Money, Money);
                InventoryHandler.UpdateInventory(gc, Type);
            }
        }
    }
}
