using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;

namespace Server.Handler
{
    public static class InventoryHandler
    {
        public static void MoveItem_Req(InPacket lea, Client gc)
        {
            byte SourceType = lea.ReadByte();
            byte SorceSlot = lea.ReadByte();
            byte TargetType = lea.ReadByte();
            byte TargetSlot = lea.ReadByte();
            int Quantity = lea.ReadInt();
            Item Source = gc.Character.Items.GetItem(SourceType, SorceSlot);
            Item Target = gc.Character.Items.GetItem(TargetType, TargetSlot);
            var chr = gc.Character;

            if (TargetType == 0x63 && TargetSlot == 0x63)
            {
                if (SourceType == 0xFF && SorceSlot == 0xFF)
                    return;
                Map map = MapFactory.GetMap(chr.MapX, chr.MapY);
                InventoryPacket.charDropItem(gc, map.DropOriginalID, Source.ItemID, chr.PlayerX, (short)(chr.PlayerY - 50), Quantity);
                map.CharacterItem.Add(map.DropOriginalID, Source);
                map.DropOriginalID++;
                chr.Items.Remove(SourceType, SorceSlot, Quantity);
            }
            else
            {
                if (gc.Character.Items.GetItem(TargetType, TargetSlot) == null)
                {
                    Source.type = TargetType;
                    Source.slot = TargetSlot;
                    if (TargetType == (byte)InventoryType.ItemType.Equip || SourceType == (byte)InventoryType.ItemType.Equip)
                        UpdateCharacterInventoryStatus(gc, Source.ItemID, SourceType > 0);
                }
                else
                {   // 交換位置(swap)
                    chr.Items.Remove(SourceType, SorceSlot);
                    chr.Items.Remove(TargetType, TargetSlot);
                    // 類型
                    byte swapType = Source.type;
                    Source.type = Target.type;
                    Target.type = swapType;
                    // 欄位
                    byte swapSlot = Source.slot;
                    Source.slot = Target.slot;
                    Target.slot = swapSlot;
                    //
                    chr.Items.Add(Source);
                    chr.Items.Add(Target);
                    if (TargetType == (byte)InventoryType.ItemType.Equip || SourceType == (byte)InventoryType.ItemType.Equip)
                        UpdateCharacterInventoryStatus(gc, Target.ItemID, TargetType == 0);
                }
            }
            UpdateInventory(gc, SourceType, TargetType);
        }

        public static void UseSpend_Req(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            byte Type = lea.ReadByte();
            byte Slot = lea.ReadByte();
            Item Item = chr.Items.GetItem(Type, Slot);
            Map map = MapFactory.GetMap(chr.MapX, chr.MapY);
            var use = ItemFactory.useData[Item.ItemID];
            // 使用回復HP 跟 MP 的物品
            switch (Item.ItemID)
            {
                case 8850021: // 清陰符
                    chr.MapX = 1;
                    chr.MapY = 2;
                    chr.PlayerX = 2955;
                    chr.PlayerY = 1116;
                    MapPacket.warpToMapAuth(gc, true, chr.MapX, chr.MapY, chr.PlayerX, chr.PlayerY);
                    break;
                case 8850041: // 冥珠符
                    chr.MapX = 10;
                    chr.MapY = 3;
                    chr.PlayerX = 1645;
                    chr.PlayerY = 899;
                    MapPacket.warpToMapAuth(gc, true, chr.MapX, chr.MapY, chr.PlayerX, chr.PlayerY);
                    break;
                case 8850031: // 龍林符
                    chr.MapX = 15;
                    chr.MapY = 2;
                    chr.PlayerX = 3600;
                    chr.PlayerY = 1041;
                    MapPacket.warpToMapAuth(gc, true, chr.MapX, chr.MapY, chr.PlayerX, chr.PlayerY);
                    break;
                case 8850051: // 古樂符
                    chr.MapX = 25;
                    chr.MapY = 1;
                    chr.PlayerX = 4237;
                    chr.PlayerY = 1230;
                    MapPacket.warpToMapAuth(gc, true, chr.MapX, chr.MapY, chr.PlayerX, chr.PlayerY);
                    break;
                default:
                    if (use.Hp != -1)
                    {
                        if ((chr.MaxHp > chr.Hp + use.Hp))
                        {
                            chr.Hp += (short)use.Hp;
                            StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, 0);
                        }
                        else if (chr.MaxHp - chr.Hp < use.Hp)
                        {
                            chr.Hp = (short)chr.MaxHp;
                            StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, 0);
                        }
                    }
                    if (use.Mp != -1)
                    {
                        if ((chr.MaxMp > chr.Mp + use.Mp))
                        {
                            chr.Mp += (short)use.Mp;
                            StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, 0);
                        }
                        else if (chr.MaxMp - chr.Mp < use.Mp)
                        {
                            chr.Mp = (short)chr.MaxMp;
                            StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, 0);
                        }
                    }
                    break;
            }
            chr.Items.Remove(Type, Slot, 1);
            UpdateInventory(gc, Type);

        }

        public static void InvenUseSpendShout_Req(InPacket lea, Client gc)
        {
            byte Slot = lea.ReadByte();
            string Message = lea.ReadString(60);
            lea.ReadInt();
            lea.ReadByte();
            lea.ReadByte();
            if (Slot >= 0 && Slot < 24 && Message.Length <= 60)
            {
                gc.Character.Items.Remove(InventoryType.ItemType.Spend3, Slot);
                foreach (Character all in MapFactory.AllCharacters)
                {
                    GamePacket.InvenUseSpendShout(all.Client, Message);
                }
                InventoryPacket.getInvenSpend3(gc);
            }
        }

        public static void PickupItem(InPacket lea, Client gc)
        {
            int OriginalID = lea.ReadInt();
            int ItemID = lea.ReadInt();
            lea.ReadInt();
            byte Type = InventoryType.getItemType(ItemID);
            byte Slot = gc.Character.Items.GetNextFreeSlot((InventoryType.ItemType)Type);
            var chr = gc.Character;

            Map map = MapFactory.GetMap(chr.MapX, chr.MapY);
            if (!map.CharacterItem.ContainsKey(OriginalID))
                return;
            Item oItem = new Item(ItemID, Slot, (byte)Type, map.getDropByOriginalID(OriginalID).Quantity);
            chr.Items.Add(oItem);
            InventoryPacket.clearDropItem(gc, chr.CharacterID, OriginalID, ItemID, map.getDropByOriginalID(OriginalID).Quantity);
            map.CharacterItem.Remove(OriginalID);
            UpdateInventory(gc, Type);
        }

        public static void UpdateCharacterInventoryStatus(Client gc, int item, bool equiped)
        {
            ItemData idata = ItemFactory.GetItemData(item);
            Character chr = gc.Character;
            if (idata.Attack != -1)
            {
                if (equiped)
                {
                    chr.Attack += idata.Attack;
                    chr.MaxAttack += idata.Attack;
                } else
                {
                    chr.Attack -= idata.Attack;
                    chr.MaxAttack -= idata.Attack;
                }
            }
            if (idata.Defense != -1)
            {
                if (equiped)
                    chr.Defense += idata.Defense;
                else
                    chr.Defense -= idata.Defense;
            }
            StatusPacket.UpdateStat(gc);
        }

        public static void UpdateInventory(Client gc, byte SourceType, byte TargetType = 0xFF)
        {
            switch (SourceType)
            {
                case 0:
                    UpdateAvatar(gc);
                    switch (TargetType)
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
                    if (TargetType == 0)
                        UpdateAvatar(gc);
                    InventoryPacket.getInvenEquip1(gc);
                    break;
                case 2:
                    if (TargetType == 0)
                        UpdateAvatar(gc);
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

        public static void UpdateAvatar(Client gc)
        {
            InventoryPacket.getInvenEquip(gc);
            StatusPacket.getStatusInfo(gc);
            InventoryPacket.getAvatar(gc);
        }
    }
}
