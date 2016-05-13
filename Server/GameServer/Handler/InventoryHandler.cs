using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Ghost;

namespace Server.Handler
{
    class InventoryHandler
    {
        public static void MoveItem_Req(InPacket lea, Client gc)
        {
            byte sourceType = lea.ReadByte();
            byte sorceSlot = lea.ReadByte();
            byte targetType = lea.ReadByte();
            byte targetSlot = lea.ReadByte();
            int count = lea.ReadInt();
            Item source = gc.Character.Items.GetItem(sourceType, sorceSlot);
            Item target = gc.Character.Items.GetItem(targetType, targetSlot);

            if (targetType == 0x63 && targetSlot == 0x63)
            {
                InventoryPacket.charDropItem(gc, 0, source.ItemID, gc.Character.PlayerX, gc.Character.PlayerY, count);
                gc.Character.Items.RemoveItem(sourceType, sorceSlot);
            }
            else
            {
                if (gc.Character.Items.GetItem(targetType, targetSlot) == null)
                {
                    source.type = targetType;
                    source.slot = targetSlot;
                }
                else
                {   // 交換位置(swap)
                    gc.Character.Items.RemoveItem(sourceType, sorceSlot);
                    gc.Character.Items.RemoveItem(targetType, targetSlot);
                    byte swapSlot = source.slot;
                    source.slot = target.slot;
                    target.slot = swapSlot;
                    gc.Character.Items.Add(source);
                    gc.Character.Items.Add(target);
                }
            }

            switch (sourceType)
            {
                case 0:
                    getAvatar(gc);
                    switch (targetType)
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
                    if (targetType == 0)
                        getAvatar(gc);
                    InventoryPacket.getInvenEquip1(gc);
                    break;
                case 2:
                    if (targetType == 0)
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

        public static void getAvatar(Client gc)
        {
            InventoryPacket.getInvenEquip(gc);
            StatusPacket.getStatusInfo(gc);
            InventoryPacket.getAvatar(gc);
        }

        public static void UseWater_Req(InPacket lea, Client gc)
        {
            int updateHp = lea.ReadInt();
            short updateMp = lea.ReadShort();
            short updateMaxFury = lea.ReadShort();
            lea.ReadShort();
            StatusPacket.updateHpMp(gc, updateHp, updateMp, updateMaxFury);
        }

        public static void InvenUseSpendShout_Req(InPacket lea, Client gc)
        {
            byte slot = lea.ReadByte();
            string message = lea.ReadString(60);
            lea.ReadInt();
            lea.ReadByte();
            lea.ReadByte();
            if (slot >= 0 && slot < 24 && message.Length < 60)
            {
                gc.Character.Items.RemoveItem(InventoryType.ItemType.Spend3, slot);
                MapPacket.InvenUseSpendShout(gc, message);
                InventoryPacket.getInvenSpend3(gc);
            }
        }

        public static void pickupItem(InPacket lea, Client gc)
        {
            int unk1 = lea.ReadInt();
            int itemid = lea.ReadInt();
            int unk2 = lea.ReadInt();
            int type = InventoryType.getItemType(itemid);
            byte solt = gc.Character.Items.GetNextFreeSlot((InventoryType.ItemType) type);
            Item oItem = new Item(itemid, solt, (byte)type, 1);
            gc.Character.Items.Add(oItem);
            InventoryPacket.clearDropItem(gc, 11, 0, itemid, 1);
            switch (type)
            {
                case 0:
                    getAvatar(gc);
                    switch (type)
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
                    if (type == 0)
                        getAvatar(gc);
                    InventoryPacket.getInvenEquip1(gc);
                    break;
                case 2:
                    if (type == 0)
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
