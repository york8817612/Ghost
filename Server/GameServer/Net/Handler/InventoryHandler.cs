using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Ghost.Characters;
using Server.Net;
using Server.Packet;

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
            var chr = gc.Character;

            if (targetType == 0x63 && targetSlot == 0x63)
            {
                if (sourceType == 0xFF && sorceSlot == 0xFF)
                    return;
                Map map = Maps.GetMap(chr.MapX, chr.MapY);
                InventoryPacket.charDropItem(gc, map.DropOriginalID, source.ItemID, gc.Character.PlayerX,(short)(gc.Character.PlayerY - 50), count);
                map.DropItem.Add(map.DropOriginalID, source);
                map.DropOriginalID++;
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
                foreach (Character all in Maps.AllCharacters)
                {
                    MapPacket.InvenUseSpendShout(all.Client, message);
                }
                InventoryPacket.getInvenSpend3(gc);
            }
        }

        public static void PickupItem(InPacket lea, Client gc)
        {
            int OriginalID = lea.ReadInt();
            int ItemID = lea.ReadInt();
            lea.ReadInt();
            int Type = InventoryType.getItemType(ItemID);
            byte Slot = gc.Character.Items.GetNextFreeSlot((InventoryType.ItemType) Type);
            var chr = gc.Character;

            Item oItem = new Item(ItemID, Slot, (byte)Type, 1);
            Map map = Maps.GetMap(chr.MapX, chr.MapY);
            if (!map.DropItem.ContainsKey(OriginalID))
                return;
            chr.Items.Add(oItem);
            InventoryPacket.clearDropItem(gc, chr.CharacterID, OriginalID, ItemID, 1);
            map.DropItem.Remove(OriginalID);
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
