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

        public static void getAvatar(Client gc)
        {
            InventoryPacket.getInvenEquip(gc);
            StatusPacket.getStatusInfo(gc);
            InventoryPacket.getAvatar(gc);
        }

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
            if (gc.Character.Money >= money)
            {
                gc.Character.Money -= money;
                InventoryPacket.getInvenMoney(gc, gc.Character.Money, -money);
                byte Type = (byte)InventoryType.getItemType(ItemID);
                byte Slot = gc.Character.Items.GetNextFreeSlot((InventoryType.ItemType)Type);
                Item oItem = new Item(ItemID, Slot, Type, (short)Quantity);
                gc.Character.Items.Add(oItem);

                switch (Type)
                {
                    case 0:
                        getAvatar(gc);
                        switch (Type)
                        {
                            case 1:
                                InventoryPacket.getInvenEquip1(gc);
                                break;
                            case 2:
                                InventoryPacket.getInvenEquip2(gc);
                                break;
                        }
                        break;
                    case 1:
                        if (Type == 0)
                            getAvatar(gc);
                        InventoryPacket.getInvenEquip1(gc);
                        break;
                    case 2:
                        if (Type == 0)
                            getAvatar(gc);
                        InventoryPacket.getInvenEquip2(gc);
                        break;
                    case 3:
                        InventoryPacket.getInvenSpend3(gc);
                        break;
                    case 4:
                        InventoryPacket.getInvenOther4(gc);
                        break;
                    case 5:
                        InventoryPacket.getInvenPet5(gc);
                        break;
                }

            }
        }

        public static void Sell_Req(InPacket lea, Client gc)
        {
            int ItemID = lea.ReadInt();
            byte Type = lea.ReadByte();
            byte Slot = lea.ReadByte();
            short Quantity = lea.ReadShort();

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
                gc.Character.Money += (money / 5);
                InventoryPacket.getInvenMoney(gc, gc.Character.Money, money);
                gc.Character.Items.RemoveItem(Type, Slot);
                switch (Type)
                {
                    case 0:
                        getAvatar(gc);
                        switch (Type)
                        {
                            case 1:
                                InventoryPacket.getInvenEquip1(gc);
                                break;
                            case 2:
                                InventoryPacket.getInvenEquip2(gc);
                                break;
                        }
                        break;
                    case 1:
                        if (Type == 0)
                            getAvatar(gc);
                        InventoryPacket.getInvenEquip1(gc);
                        break;
                    case 2:
                        if (Type == 0)
                            getAvatar(gc);
                        InventoryPacket.getInvenEquip2(gc);
                        break;
                    case 3:
                        InventoryPacket.getInvenSpend3(gc);
                        break;
                    case 4:
                        InventoryPacket.getInvenOther4(gc);
                        break;
                    case 5:
                        InventoryPacket.getInvenPet5(gc);
                        break;
                }

            }
        }
    }
}
