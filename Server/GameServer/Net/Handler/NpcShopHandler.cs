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
                byte Slot = gc.Character.Items.GetNextFreeSlot((InventoryType.ItemType)Type);
                if ((Type == 3 && Quantity > 100) || (Type == 4 && Quantity > 100))
                    return;
                gc.Character.Money -= (money * Quantity);
                InventoryPacket.getInvenMoney(gc, gc.Character.Money, -(money * Quantity));
                Item oItem = new Item(ItemID, Slot, Type, (short)Quantity);
                gc.Character.Items.Add(oItem);
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
            Item source = gc.Character.Items.GetItem(Type, Slot);

            if (source != null)
            {
                gc.Character.Money += ((money / 5) * Quantity);
                InventoryPacket.getInvenMoney(gc, gc.Character.Money, money);
                gc.Character.Items.Remove(Type, Slot);
                InventoryHandler.UpdateInventory(gc, Type);
            }
        }
    }
}
