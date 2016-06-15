using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;
using System;

namespace Server.Handler
{
    public static class InventoryHandler
    {
        public static void MoveItem_Req(InPacket lea, Client gc)
        {
            byte SourceType = lea.ReadByte();
            byte SourceSlot = lea.ReadByte();
            byte TargetType = lea.ReadByte();
            byte TargetSlot = lea.ReadByte();
            int Quantity = lea.ReadInt();
            Item Source = gc.Character.Items.GetItem(SourceType, SourceSlot);
            Item Target = gc.Character.Items.GetItem(TargetType, TargetSlot);
            var chr = gc.Character;

            if (TargetType == 0x63 && TargetSlot == 0x63)
            {
                if (SourceType == 0xFF && SourceSlot == 0xFF)
                    return;
                Map map = MapFactory.GetMap(chr.MapX, chr.MapY);
                InventoryPacket.charDropItem(gc, map.ObjectID, Source.ItemID, chr.PlayerX, (short)(chr.PlayerY - 50), Quantity == 0 ? 1 : Quantity);
                map.CharacterItem.Add(map.ObjectID, Source);
                map.ObjectID++;
                chr.Items.Remove(SourceType, SourceSlot, Quantity == 0 ? 1 : Quantity);
            }
            else
            {
                if (chr.Items.GetItem(TargetType, TargetSlot) == null)
                {
                    if (SourceType != 5)
                    {
                        // 普通物品
                        Source.Type = TargetType;
                        Source.Slot = TargetSlot;
                        if (TargetType == (byte)InventoryType.ItemType.Equip || SourceType == (byte)InventoryType.ItemType.Equip)
                            UpdateCharacterInventoryStatus(gc, Source.ItemID, SourceType > 0);
                    }
                    else
                    {
                        // 寵物
                        Pet Src = chr.Pets.Pet(SourceType, SourceSlot);
                        Src.Type = TargetType;
                        Src.Slot = TargetSlot;
                    }
                }
                else
                {
                    if ((SourceType == TargetType)
                        && ((TargetType == (byte)InventoryType.ItemType.Spend3)
                        || (TargetType == (byte)InventoryType.ItemType.Other4))
                        && (Source.ItemID == Target.ItemID))
                    {
                        // 合併消費物品跟其他物品
                        if (chr.Items[(InventoryType.ItemType)Target.Type, Target.Slot].Quantity + Source.Quantity > 100)
                        {
                            short newqu = (short)(Source.Quantity - (100 - chr.Items[(InventoryType.ItemType)Target.Type, Target.Slot].Quantity));
                            chr.Items[(InventoryType.ItemType)Source.Type, Source.Slot].Quantity = newqu;
                            chr.Items[(InventoryType.ItemType)Target.Type, Target.Slot].Quantity = 100;
                        }
                        else
                        {
                            chr.Items.Remove(SourceType, SourceSlot);
                            chr.Items[(InventoryType.ItemType)Target.Type, Target.Slot].Quantity += Source.Quantity;
                        }
                    }
                    else
                    {
                        // 交換位置(swap)
                        chr.Items.Remove(SourceType, SourceSlot);
                        chr.Items.Remove(TargetType, TargetSlot);
                        // 類型
                        byte swapType = Source.Type;
                        Source.Type = Target.Type;
                        Target.Type = swapType;
                        // 欄位
                        byte swapSlot = Source.Slot;
                        Source.Slot = Target.Slot;
                        Target.Slot = swapSlot;
                        //
                        chr.Items.Add(Source);
                        chr.Items.Add(Target);
                    }
                    if (TargetType == (byte)InventoryType.ItemType.Equip || SourceType == (byte)InventoryType.ItemType.Equip)
                    {
                        UpdateCharacterInventoryStatus(gc, Target.ItemID, false);
                        UpdateCharacterInventoryStatus(gc, Source.ItemID, true);
                    }
                }
            }
            UpdateInventory(gc, SourceType, TargetType);
        }

        public static void SelectSlot_Req(InPacket lea, Client c)
        {
            int Slot = lea.ReadInt();
            var chr = c.Character;
            chr.UseSlot.Remove((byte)InventoryType.ItemType.Spend3);
            chr.UseSlot.Add((byte)InventoryType.ItemType.Spend3, (byte)Slot);
            InventoryPacket.SelectSlot(c, Slot);
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
                            StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
                        }
                        else if (chr.MaxHp - chr.Hp < use.Hp)
                        {
                            chr.Hp = (short)chr.MaxHp;
                            StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
                        }
                    }
                    if (use.Mp != -1)
                    {
                        if ((chr.MaxMp > chr.Mp + use.Mp))
                        {
                            chr.Mp += (short)use.Mp;
                            StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
                        }
                        else if (chr.MaxMp - chr.Mp < use.Mp)
                        {
                            chr.Mp = (short)chr.MaxMp;
                            StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
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
            var chr = gc.Character;
            Map map = MapFactory.GetMap(chr.MapX, chr.MapY);

            // 撿取靈魂
            if (ItemID >= 9900001 && ItemID <= 9900004)
            {
                if (map.getDropByOriginalID(OriginalID) == null)
                    return;
                switch (ItemID)
                {
                    case 9900001: // Blue
                        chr.Mp += (short)(chr.MaxMp * 0.2);
                        if (chr.Mp > chr.MaxMp)
                            chr.Mp = chr.MaxMp;
                        break;
                    case 9900002: // Green
                        chr.Mp += (short)(chr.MaxMp * 0.4);
                        if (chr.Mp > chr.MaxMp)
                            chr.Mp = chr.MaxMp;
                        break;
                    case 9900003: // Red
                        Random rd = new Random();
                        int number = rd.Next(3, 7); // 範圍：3 ~ 6
                        chr.Fury += (short)(chr.MaxFury / 100 * number);
                        if (chr.Fury > chr.MaxFury)
                            chr.Fury = chr.MaxFury;
                        break;
                    case 9900004: // Purple
                        // TODO: +封印量
                        break;
                }
                StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
                InventoryPacket.clearDropItem(gc, chr.CharacterID, OriginalID, ItemID);
                return;
            }
            // 撿取錢
            if (ItemID >= 9800001 && ItemID <= 9800005)
            {
                if (map.getDropByOriginalID(OriginalID) == null)
                    return;
                chr.Money += map.getDropByOriginalID(OriginalID).Quantity;
                InventoryPacket.getInvenMoney(gc, chr.Money, map.getDropByOriginalID(OriginalID).Quantity);
                InventoryPacket.clearDropItem(gc, chr.CharacterID, OriginalID, ItemID);
                return;
            }

            if (!map.CharacterItem.ContainsKey(OriginalID))
                return;

            byte Type = InventoryType.getItemType(ItemID);

            Item finditem = null;
            foreach (Item it in gc.Character.Items)
            {
                if (it.ItemID == ItemID)
                {
                    finditem = it;
                }
            }

            if (((Type == (byte)InventoryType.ItemType.Spend3)
                || (Type == (byte)InventoryType.ItemType.Other4))
                && (finditem != null)
                && (finditem.Quantity + map.getDropByOriginalID(OriginalID).Quantity) <= 100)
            {
                // 合併消費物品跟其他物品
                chr.Items[(InventoryType.ItemType)finditem.Type, finditem.Slot].Quantity += map.getDropByOriginalID(OriginalID).Quantity;
            }
            else
            {
                byte Slot = gc.Character.Items.GetNextFreeSlot((InventoryType.ItemType)Type);
                Item oItem = new Item(ItemID, Slot, (byte)Type, map.getDropByOriginalID(OriginalID).Quantity);
                chr.Items.Add(oItem);
            }
            InventoryPacket.clearDropItem(gc, chr.CharacterID, OriginalID, ItemID);
            map.CharacterItem.Remove(OriginalID);
            UpdateInventory(gc, Type);
        }

        public static void UpdateCharacterInventoryStatus(Client gc, int itemID, bool equiped)
        {
            ItemData idata = ItemFactory.GetItemData(itemID);
            Character chr = gc.Character;
            if (idata.Attack != -1)
            {
                if (equiped)
                {
                    if (GameConstants.isPhysicalWeapon(itemID))
                    {
                        // 物理攻擊力武器
                        chr.Attack += idata.Attack;
                        chr.MaxAttack += idata.Attack;
                    }
                    else
                    {
                        // 魔法攻擊力武器
                        chr.Magic += idata.Attack;
                        chr.MaxMagic += idata.Attack;
                    }
                }
                else
                {
                    if (GameConstants.isPhysicalWeapon(itemID))
                    {
                        // 物理攻擊力武器
                        chr.Attack -= idata.Attack;
                        chr.MaxAttack -= idata.Attack;
                    }
                    else
                    {
                        // 魔法攻擊力武器
                        chr.Magic -= idata.Attack;
                        chr.MaxMagic -= idata.Attack;
                    }
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
                    if (TargetType == 0)
                        UpdateAvatar(gc);
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
