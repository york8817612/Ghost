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
                foreach (Character All in map.Characters)
                {
                    InventoryPacket.charDropItem(All.Client, map.ObjectID, Source.ItemID, chr.PlayerX, (short)(chr.PlayerY - 50), Quantity == 0 ? 1 : Quantity);
                }
                map.CharacterItem.Add(map.ObjectID, Source);
                map.ObjectID++;
                chr.Items.Remove(SourceType, SourceSlot, Quantity == 0 ? 1 : Quantity);
            }
            else
            {
                if (chr.Items.GetItem(TargetType, TargetSlot) == null)
                {
                    if (SourceType != 5 && TargetType != 5)
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
                        Pet Tar = chr.Pets.Pet(TargetType, TargetSlot);

                        if (SourceType == 5)
                            chr.UseSlot[(byte)InventoryType.ItemType.Pet5] = Src.Slot;
                        else if (TargetType == 5)
                            chr.UseSlot[(byte)InventoryType.ItemType.Pet5] = 0xFF;

                        if (chr.Pets.Pet(TargetType, TargetSlot) == null)
                        {
                            Src.Type = TargetType;
                            Src.Slot = TargetSlot;
                        }
                        else
                        {
                            // 交換位置(swap)
                            chr.Pets.Remove(SourceType, SourceSlot);
                            chr.Pets.Remove(TargetType, TargetSlot);
                            // 類型
                            byte swapType = Src.Type;
                            Src.Type = Tar.Type;
                            Tar.Type = swapType;
                            // 欄位
                            byte swapSlot = Src.Slot;
                            Src.Slot = Tar.Slot;
                            Tar.Slot = swapSlot;
                            //
                            chr.Pets.Add(Src);
                            chr.Pets.Add(Tar);
                        }
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
            if (SourceType != 5 && TargetType != 5)
            {
                if (Source.IsLocked == 1)
                    Source.IsLocked = 0;
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
                case 8850061: // 無名符
                    chr.MapX = 16;
                    chr.MapY = 1;
                    chr.PlayerX = 2005;
                    chr.PlayerY = 1101;
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

        public static void InvenUseSpendStart_Req(InPacket lea, Client c)
        {
            short PositionX = lea.ReadShort();
            short PositionY = lea.ReadShort();
            int Slot = lea.ReadInt();
            var chr = c.Character;
            Map map = MapFactory.GetMap(chr.MapX, chr.MapY);
            Item Item = chr.Items.GetItem((byte)InventoryType.ItemType.Spend3, (byte)Slot);
            foreach (Character All in map.Characters)
                InventoryPacket.UseSpendStart(All.Client, chr, PositionX, PositionY, Item.ItemID, (byte)InventoryType.ItemType.Spend3, Slot);
            chr.Items.Remove((byte)InventoryType.ItemType.Spend3, (byte)Slot, 1);
            UpdateInventory(c, (byte)InventoryType.ItemType.Spend3);
        }

        public static void InvenUseSpendShout_Req(InPacket lea, Client gc)
        {
            byte Slot = lea.ReadByte();
            string Message = lea.ReadString(60);
            lea.ReadInt();
            lea.ReadByte();
            lea.ReadByte();
            var chr = gc.Character;

            if (Slot >= 0 && Slot < 24 && Message.Length <= 60)
            {
                gc.Character.Items.Remove(InventoryType.ItemType.Spend3, Slot);
                foreach (Character All in MapFactory.AllCharacters)
                {
                    GamePacket.InvenUseSpendShout(All.Client, chr, Message);
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
                foreach (Character All in map.Characters)
                {
                    InventoryPacket.clearDropItem(All.Client, chr.CharacterID, OriginalID, ItemID);
                }
                return;
            }
            // 撿取錢
            if (ItemID >= 9800001 && ItemID <= 9800005)
            {
                if (map.getDropByOriginalID(OriginalID) == null)
                    return;
                chr.Money += map.getDropByOriginalID(OriginalID).Quantity;
                InventoryPacket.getInvenMoney(gc, chr.Money, map.getDropByOriginalID(OriginalID).Quantity);
                foreach (Character All in map.Characters)
                {
                    InventoryPacket.clearDropItem(All.Client, chr.CharacterID, OriginalID, ItemID);
                }
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
                Item oItem = new Item(ItemID, Type, Slot, map.getDropByOriginalID(OriginalID).Quantity);
                chr.Items.Add(oItem);
            }
            foreach (Character All in map.Characters)
            {
                InventoryPacket.clearDropItem(All.Client, chr.CharacterID, OriginalID, ItemID);
            }
            map.CharacterItem.Remove(OriginalID);
            UpdateInventory(gc, Type);
        }

        public static void UpdateCharacterInventoryStatus(Client gc, int itemID, bool equiped)
        {
            ItemData idata = ItemFactory.GetItemData(itemID);
            Character chr = gc.Character;
            // Hp
            if (idata.Hp != -1)
            {
                if (equiped)
                {
                    chr.MaxHp += idata.Hp;
                }
                else
                {
                    chr.MaxHp -= idata.Hp;
                    chr.Hp = chr.MaxHp;
                }
            }
            // Mp
            if (idata.Mp != -1)
            {
                if (equiped)
                {
                    chr.MaxMp += idata.Mp;
                }
                else
                {
                    chr.MaxMp -= idata.Mp;
                    chr.Mp = chr.MaxMp;
                }
            }
            // 力量
            if (idata.Str != -1)
            {
                if (equiped)
                    chr.UpgradeStr += idata.Str;
                else
                    chr.UpgradeStr -= idata.Str;
            }
            // 精力
            if (idata.Dex != -1)
            {
                if (equiped)
                    chr.UpgradeDex += idata.Dex;
                else
                    chr.UpgradeDex -= idata.Dex;
            }
            // 氣力
            if (idata.Vit != -1)
            {
                if (equiped)
                    chr.UpgradeVit += idata.Vit;
                else
                    chr.UpgradeVit -= idata.Vit;
            }
            // 智力
            if (idata.Int != -1)
            {
                if (equiped)
                    chr.UpgradeInt += idata.Int;
                else
                    chr.UpgradeInt -= idata.Int;
            }
            // 物理攻擊力
            if (idata.Attack != -1)
            {
                if (equiped)
                {
                    chr.Attack += idata.Attack;
                    chr.MaxAttack += idata.Attack;
                }
                else
                {
                    chr.Attack -= idata.Attack;
                    chr.MaxAttack -= idata.Attack;
                }
            }
            // 魔法攻擊力
            if (idata.Magic != -1)
            {
                if (equiped)
                {
                    chr.Magic += idata.Magic;
                    chr.MaxMagic += idata.Magic;
                }
                else
                {
                    chr.Magic -= idata.Magic;
                    chr.MaxMagic -= idata.Magic;
                }
            }
            // 迴避率
            if (idata.Avoid != -1)
            {
                if (equiped)
                    chr.Avoid += idata.Avoid;
                else
                    chr.Avoid -= idata.Avoid;
            }
            // 防禦力
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
                        case 5:
                            InventoryPacket.getInvenPet5(gc);
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
            var chr = gc.Character;
            Map map = MapFactory.GetMap(chr.MapX, chr.MapY);
            InventoryPacket.getInvenEquip(gc);
            StatusPacket.getStatusInfo(gc);
            foreach (Character All in map.Characters)
                InventoryPacket.getAvatar(All.Client, chr);
        }
    }
}
