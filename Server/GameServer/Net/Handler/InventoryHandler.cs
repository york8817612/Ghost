using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Common.Utilities;
using Server.Ghost;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;
using System;
using System.Collections.Generic;

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
            Item Source = gc.Character.Items.getItem(SourceType, SourceSlot);
            Item Target = gc.Character.Items.getItem(TargetType, TargetSlot);
            var chr = gc.Character;

            if (SourceType != (byte)InventoryType.ItemType.Pet5 && Source.IsLocked == 1 && TargetType == (byte)InventoryType.ItemType.Equip)
            {
                Source.IsLocked = 0;
            }

            if (TargetType == 0x63 && TargetSlot == 0x63)
            {
                if (SourceType == 0xFF && SourceSlot == 0xFF)
                    return;
                Map Map = MapFactory.GetMap(chr.MapX, chr.MapY);
                foreach (Character All in Map.Characters)
                {
                    InventoryPacket.CharDropItem(All.Client, Map.ObjectID, Source.ItemID, chr.PlayerX, (short)(chr.PlayerY - 50), Quantity == 0 ? 1 : Quantity);
                }
                Map.Item.Add(Map.ObjectID, new Drop(Map.ObjectID, Source.ItemID, Quantity == 0 ? (short)1 : (short)Quantity));
                Map.ObjectID++;
                chr.Items.Remove(SourceType, SourceSlot, Quantity == 0 ? 1 : Quantity);
            }
            else
            {
                if (chr.Items.getItem(TargetType, TargetSlot) == null)
                {
                    if (SourceType != 5 && TargetType != 5)
                    {
                        // 普通物品
                        Source.Type = TargetType;
                        Source.Slot = TargetSlot;
                        if (TargetType == (byte)InventoryType.ItemType.Equip || SourceType == (byte)InventoryType.ItemType.Equip)
                            UpdateCharacterInventoryStatus(gc, Source, SourceType > 0);
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
                    if (SourceType == (byte)InventoryType.ItemType.Equip && TargetType == (byte)InventoryType.ItemType.Equip1)
                    {
                        UpdateCharacterInventoryStatus(gc, Source, false);
                        UpdateCharacterInventoryStatus(gc, Target, true);
                    }
                    else if (SourceType == (byte)InventoryType.ItemType.Equip || TargetType == (byte)InventoryType.ItemType.Equip)
                    {
                        UpdateCharacterInventoryStatus(gc, Target, false);
                        UpdateCharacterInventoryStatus(gc, Source, true);
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
            Item Item = chr.Items.getItem(Type, Slot);
            Map map = MapFactory.GetMap(chr.MapX, chr.MapY);
            var use = ItemFactory.useData[Item.ItemID];
            // 使用回復HP 跟 MP 的物品
            switch (Item.ItemID)
            {
                case 8841006: // 全部還原本
                    int Recover = 0;
                    Recover = Recover + (chr.Str - 3);
                    Recover = Recover + (chr.Dex - 3);
                    Recover = Recover + (chr.Vit - 3);
                    Recover = Recover + (chr.Int - 3);
                    chr.Str = 3;
                    chr.Dex = 3;
                    chr.Vit = 3;
                    chr.Int = 3;
                    chr.AbilityBonus += (short)Recover;
                    StatusPacket.getStatusInfo(gc);
                    break;
                case 8850011: // 回城符
                    switch (chr.MapX)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 22:
                        case 23:
                            chr.MapX = 1;
                            chr.MapY = 1;
                            break;
                        case 7:
                        case 8:
                        case 9:
                            chr.MapX = 16;
                            chr.MapY = 1;
                            break;
                        case 10:
                        case 11:
                        case 20:
                            chr.MapX = 10;
                            chr.MapY = 1;
                            break;
                        case 12:
                        case 13:
                            chr.MapX = 12;
                            chr.MapY = 1;
                            break;
                        case 14:
                        case 15:
                        case 17:
                        case 18:
                        case 19:
                        case 21:
                            chr.MapX = 15;
                            chr.MapY = 1;
                            break;
                        case 16:
                            chr.MapX = 16;
                            chr.MapY = 1;
                            break;
                        case 24:
                        case 25:
                        case 26:
                        case 31:
                        case 32:
                        case 33:
                            chr.MapX = 25;
                            chr.MapY = 1;
                            break;
                        case 27:
                        case 28:
                            chr.MapX = 27;
                            chr.MapY = 1;
                            break;
                        default:
                            chr.MapX = 1;
                            chr.MapY = 1;
                            break;
                    }
                    chr.PlayerX = 0;
                    chr.PlayerY = 0;
                    MapPacket.warpToMapAuth(gc, true, chr.MapX, chr.MapY, chr.PlayerX, chr.PlayerY);
                    break;
                case 8850021: // 清陰符
                    chr.MapX = 1;
                    chr.MapY = 2;
                    chr.PlayerX = 2955;
                    chr.PlayerY = 1116;
                    MapPacket.warpToMapAuth(gc, true, chr.MapX, chr.MapY, chr.PlayerX, chr.PlayerY);
                    break;
                case 8850031: // 龍林符(龍林城)
                    chr.MapX = 15;
                    chr.MapY = 2;
                    chr.PlayerX = 3600;
                    chr.PlayerY = 1041;
                    MapPacket.warpToMapAuth(gc, true, chr.MapX, chr.MapY, chr.PlayerX, chr.PlayerY);
                    break;
                case 8850041: // 冥珠符
                    chr.MapX = 10;
                    chr.MapY = 3;
                    chr.PlayerX = 1645;
                    chr.PlayerY = 899;
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
                case 8850071: // 龍林符(龍林客棧)
                    chr.MapX = 12;
                    chr.MapY = 1;
                    chr.PlayerX = 1040;
                    chr.PlayerY = 782;
                    MapPacket.warpToMapAuth(gc, true, chr.MapX, chr.MapY, chr.PlayerX, chr.PlayerY);
                    break;
                case 8890011: // 蠟燭
                case 8890021: // 火把
                    InventoryPacket.UseSpendStart(gc, chr, chr.PlayerX, chr.PlayerY, Item.ItemID, (byte)InventoryType.ItemType.Spend3, Slot);
                    break;
                case 8899017: // 逮巴符
                    chr.MapX = 27;
                    chr.MapY = 1;
                    chr.PlayerX = 2070;
                    chr.PlayerY = 1330;
                    MapPacket.warpToMapAuth(gc, true, chr.MapX, chr.MapY, chr.PlayerX, chr.PlayerY);
                    break;
                default:
                    switch (use.Type)
                    {
                        case 0: // 恢復鬼力
                            if ((chr.MaxMp > chr.Mp + use.Recover))
                            {
                                chr.Mp += (short)use.Recover;
                                StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
                            }
                            else if (chr.MaxMp - chr.Mp < use.Recover)
                            {
                                chr.Mp = chr.MaxMp;
                                StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
                            }
                            break;
                        case 1: // 恢復鬼力(%)
                            if ((chr.MaxMp > chr.Mp + chr.MaxMp * use.Recover / 100))
                            {
                                chr.Mp += (short)(chr.MaxMp * use.Recover / 100);
                                StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
                            }
                            else if (chr.MaxMp - chr.Mp < chr.MaxMp * use.Recover / 100)
                            {
                                chr.Mp = chr.MaxMp;
                                StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
                            }
                            break;
                        case 2: // 恢復體力
                            if ((chr.MaxHp > chr.Hp + use.Recover))
                            {
                                chr.Hp += (short)use.Recover;
                                StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
                            }
                            else if (chr.MaxHp - chr.Hp < use.Recover)
                            {
                                chr.Hp = chr.MaxHp;
                                StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
                            }
                            break;
                        case 3: // 恢復體力(%)
                            if ((chr.MaxHp > chr.Hp + chr.MaxHp * use.Recover / 100))
                            {
                                chr.Hp += (short)(chr.MaxHp * use.Recover / 100);
                                StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
                            }
                            else if (chr.MaxHp - chr.Hp < chr.MaxHp * use.Recover / 100)
                            {
                                chr.Hp = chr.MaxHp;
                                StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
                            }
                            break;
                        default:
                            break;
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
            Item Item = chr.Items.getItem((byte)InventoryType.ItemType.Spend3, (byte)Slot);
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
                gc.Character.Items.Remove((byte)InventoryType.ItemType.Spend3, Slot, 1);
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
            Map Map = MapFactory.GetMap(chr.MapX, chr.MapY);

            // 撿取靈魂
            if (ItemID >= 9900001 && ItemID <= 9900004)
            {
                if (Map.getDropByOriginalID(OriginalID) == null)
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
                        int rnd = Randomizer.Next(3, 7);
                        chr.Fury += (short)(chr.MaxFury / 100 * rnd);
                        if (chr.Fury > chr.MaxFury)
                            chr.Fury = chr.MaxFury;
                        break;
                    case 9900004: // Purple
                        if (chr.Items[InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Seal] != null)
                        {
                            chr.Items[InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Seal].Spirit++;
                            InventoryPacket.getInvenEquip(gc);
                        }
                        break;
                }
                StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
                foreach (Character All in Map.Characters)
                {
                    InventoryPacket.ClearDropItem(All.Client, chr.CharacterID, OriginalID, ItemID);
                }
                return;
            }

            // 撿取錢
            if (ItemID >= 9800001 && ItemID <= 9800005)
            {
                if (Map.getDropByOriginalID(OriginalID) == null)
                    return;
                chr.Money += Map.getDropByOriginalID(OriginalID).Quantity;
                InventoryPacket.getInvenMoney(gc, chr.Money, Map.getDropByOriginalID(OriginalID).Quantity);
                foreach (Character All in Map.Characters)
                {
                    InventoryPacket.ClearDropItem(All.Client, chr.CharacterID, OriginalID, ItemID);
                }
                return;
            }

            if (!Map.Item.ContainsKey(OriginalID))
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
                && (finditem.Quantity + Map.getDropByOriginalID(OriginalID).Quantity) <= 100)
            {
                // 合併消費物品跟其他物品
                chr.Items[(InventoryType.ItemType)finditem.Type, finditem.Slot].Quantity += Map.getDropByOriginalID(OriginalID).Quantity;
            }
            else
            {
                byte Slot = gc.Character.Items.GetNextFreeSlot((InventoryType.ItemType)Type);
                Item oItem = new Item(ItemID, Type, Slot, Map.getDropByOriginalID(OriginalID).Quantity);
                chr.Items.Add(oItem);
            }
            foreach (Character All in Map.Characters)
            {
                InventoryPacket.ClearDropItem(All.Client, chr.CharacterID, OriginalID, ItemID);
            }
            Map.Item.Remove(OriginalID);
            UpdateInventory(gc, Type);
        }

        public static void UpdateCharacterInventoryStatus(Client gc, Item Source, bool Equiped)
        {
            ItemData idata = ItemFactory.GetItemData(Source.ItemID);
            Character chr = gc.Character;

            int MaxAttack = 5;
            int Attack = 3;
            int MaxMagic = 4;
            int Magic = 4;
            MaxAttack += ((chr.Str - 3) * 2 + chr.Str / 5);
            MaxAttack += ((chr.Dex - 3) * 2 + chr.Dex / 5);
            Attack += ((chr.Dex - 3) * 1 + chr.Dex / 5);
            MaxMagic += ((chr.Int - 3) * 2 + chr.Int / 5);
            Magic += ((chr.Int - 3) * 2 + chr.Int / 5);

            // 技能攻擊力+、魔攻力+
            Dictionary<int, byte> Skill = new Dictionary<int, byte>();
            foreach (Skill sl in chr.Skills.getSkills())
            {
                Skill.Add(sl.SkillID, sl.SkillLevel);
            }
            if (InventoryType.Is劍(Source.ItemID) && Skill.ContainsKey(10101))
            {
                if (Equiped)
                {
                    chr.MaxAttack += (short)(MaxAttack * 0.02 * Skill[10101]);
                    chr.Attack += (short)(Attack * 0.02 * Skill[10101]);
                }
                else
                {
                    chr.MaxAttack -= (short)(MaxAttack * 0.02 * Skill[10101]);
                    chr.Attack -= (short)(Attack * 0.02 * Skill[10101]);
                }
            }
            if (InventoryType.Is刀(Source.ItemID) && Skill.ContainsKey(10102))
            {
                if (Equiped)
                {
                    chr.MaxAttack += (short)(MaxAttack * 0.03 * Skill[10102]);
                    chr.Attack += (short)(Attack * 0.03 * Skill[10102]);
                }
                else
                {
                    chr.MaxAttack -= (short)(MaxAttack * 0.03 * Skill[10102]);
                    chr.Attack -= (short)(Attack * 0.03 * Skill[10102]);
                }
            }
            if (InventoryType.Is手套(Source.ItemID) && Skill.ContainsKey(10201))
            {
                if (Equiped)
                {
                    chr.MaxAttack += (short)(MaxAttack * 0.02 * Skill[10201]);
                    chr.Attack += (short)(Attack * 0.02 * Skill[10201]);
                }
                else
                {
                    chr.MaxAttack -= (short)(MaxAttack * 0.02 * Skill[10201]);
                    chr.Attack -= (short)(Attack * 0.02 * Skill[10201]);
                }
            }
            if (InventoryType.Is爪(Source.ItemID) && Skill.ContainsKey(10202))
            {
                if (Equiped)
                {
                    chr.MaxAttack += (short)(MaxAttack * 0.03 * Skill[10202]);
                    chr.Attack += (short)(Attack * 0.03 * Skill[10202]);
                }
                else
                {
                    chr.MaxAttack -= (short)(MaxAttack * 0.03 * Skill[10202]);
                    chr.Attack -= (short)(Attack * 0.03 * Skill[10202]);
                }
            }
            if (InventoryType.Is扇(Source.ItemID) && Skill.ContainsKey(10301))
            {
                if (Equiped)
                {
                    chr.MaxMagic += (short)(MaxMagic * 0.02 * Skill[10301]);
                    chr.Magic += (short)(Magic * 0.02 * Skill[10301]);
                }
                else
                {
                    chr.MaxMagic -= (short)(MaxMagic * 0.02 * Skill[10301]);
                    chr.Magic -= (short)(Magic * 0.02 * Skill[10301]);
                }
            }
            if (InventoryType.Is杖(Source.ItemID) && Skill.ContainsKey(10302))
            {
                if (Equiped)
                {
                    chr.MaxMagic += (short)(MaxMagic * 0.03 * Skill[10302]);
                    chr.Magic += (short)(Magic * 0.03 * Skill[10302]);
                }
                else
                {
                    chr.MaxMagic -= (short)(MaxMagic * 0.03 * Skill[10302]);
                    chr.Magic -= (short)(Magic * 0.03 * Skill[10302]);
                }
            }
            if (InventoryType.Is斧(Source.ItemID) && Skill.ContainsKey(10401))
            {
                if (Equiped)
                {
                    chr.MaxAttack += (short)(MaxAttack * 0.02 * Skill[10401]);
                    chr.Attack += (short)(Attack * 0.02 * Skill[10401]);
                }
                else
                {
                    chr.MaxAttack -= (short)(MaxAttack * 0.02 * Skill[10401]);
                    chr.Attack -= (short)(Attack * 0.02 * Skill[10401]);
                }
            }
            if (InventoryType.Is輪(Source.ItemID) && Skill.ContainsKey(10402))
            {
                if (Equiped)
                {
                    chr.MaxAttack += (short)(MaxAttack * 0.03 * Skill[10402]);
                    chr.Attack += (short)(Attack * 0.03 * Skill[10402]);
                }
                else
                {
                    chr.MaxAttack -= (short)(MaxAttack * 0.03 * Skill[10402]);
                    chr.Attack -= (short)(Attack * 0.03 * Skill[10402]);
                }
            }
            //if (Skill.ContainsKey(10501) && InventoryType.Is(chr.Items[InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Weapon].ItemID))
            //{

            //}
            //if (Skill.ContainsKey(10502) && InventoryType.Is(chr.Items[InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Weapon].ItemID))
            //{

            //}

            // Hp
            if (idata.Hp != -1)
            {
                if (Equiped)
                {
                    chr.MaxHp += idata.Hp;
                }
                else
                {
                    chr.MaxHp -= idata.Hp;
                }
            }
            // Mp
            if (idata.Mp != -1)
            {
                if (Equiped)
                {
                    chr.MaxMp += idata.Mp;
                }
                else
                {
                    chr.MaxMp -= idata.Mp;
                }
            }
            // 物理攻擊力
            if (idata.Attack != -1)
            {
                if (Equiped)
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
                if (Equiped)
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

            // 力量
            if (idata.Str != -1)
            {
                if (Equiped)
                {
                    chr.Str += idata.Str;
                    chr.UpgradeStr += idata.Str;
                    chr.MaxHp += (short)(3 * idata.Str);
                    chr.MaxAttack += (short)(2 * idata.Str);
                }
                else
                {
                    chr.Str -= idata.Str;
                    chr.UpgradeStr -= idata.Str;
                    chr.MaxHp -= (short)(3 * idata.Str);
                    chr.MaxAttack -= (short)(2 * idata.Str);
                }
            }
            // 精力
            if (idata.Dex != -1)
            {
                if (Equiped)
                {
                    chr.Dex += idata.Dex;
                    chr.UpgradeDex += idata.Dex;
                    chr.Attack += (short)(1 * idata.Dex);
                    chr.MaxAttack += (short)(2 * idata.Dex);
                }
                else
                {
                    chr.Dex -= idata.Dex;
                    chr.UpgradeDex -= idata.Dex;
                    chr.Attack -= (short)(1 * idata.Dex);
                    chr.MaxAttack -= (short)(2 * idata.Dex);
                }
            }
            // 氣力
            if (idata.Vit != -1)
            {
                if (Equiped)
                {
                    chr.Vit += idata.Vit;
                    chr.UpgradeVit += idata.Vit;
                    chr.Defense += (short)(5 * idata.Vit);
                    chr.MaxHp += (short)(20 * idata.Vit);
                }
                else
                {
                    chr.Vit -= idata.Vit;
                    chr.UpgradeVit -= idata.Vit;
                    chr.Defense -= (short)(5 * idata.Vit);
                    chr.MaxHp -= (short)(20 * idata.Vit);
                }
            }
            // 智力
            if (idata.Int != -1)
            {
                if (Equiped)
                {
                    chr.Int += idata.Int;
                    chr.UpgradeInt += idata.Int;
                    chr.MaxMp += (short)(3 * idata.Int);
                    chr.Magic += (short)(2 * idata.Int);
                    chr.MaxMagic += (short)(2 * idata.Int);
                }
                else
                {
                    chr.Int -= idata.Int;
                    chr.UpgradeInt -= idata.Int;
                    chr.MaxMp -= (short)(3 * idata.Int);
                    chr.Magic -= (short)(2 * idata.Int);
                    chr.MaxMagic -= (short)(2 * idata.Int);
                }
            }
            // 迴避率
            if (idata.Avoid != -1)
            {
                if (Equiped)
                    chr.Avoid += idata.Avoid;
                else
                    chr.Avoid -= idata.Avoid;
            }
            // 防禦力
            if (idata.Defense != -1)
            {
                if (Equiped)
                    chr.Defense += idata.Defense;
                else
                    chr.Defense -= idata.Defense;
            }

            // 武器
            if (Source.ItemID / 100000 == 79 || Source.ItemID / 100000 == 80)
            {
                Attack = 0;
                Attack += Source.Level1 * 10;
                Attack += Source.Level2 * 9;
                Attack += Source.Level3 * 8;
                Attack += Source.Level4 * 7;
                Attack += Source.Level5 * 6;
                Attack += Source.Level6 * 5;
                Attack += Source.Level7 * 4;
                Attack += Source.Level8 * 3;
                Attack += Source.Level9 * 2;
                Attack += Source.Level10 * 1;
                if (Equiped)
                {
                    chr.Attack += (short)Attack;
                    chr.MaxAttack += (short)Attack;
                    chr.UpgradeAttack += (short)Attack;
                }
                else
                {
                    chr.Attack -= (short)Attack;
                    chr.MaxAttack -= (short)Attack;
                    chr.UpgradeAttack -= (short)Attack;
                }
            }

            // 衣服
            if (Source.ItemID / 100000 == 81 || Source.ItemID / 100000 == 95)
            {
                int Defense = 0;
                Defense += Source.Level1 * 20;
                Defense += Source.Level2 * 18;
                Defense += Source.Level3 * 16;
                Defense += Source.Level4 * 14;
                Defense += Source.Level5 * 12;
                Defense += Source.Level6 * 10;
                Defense += Source.Level7 * 8;
                Defense += Source.Level8 * 6;
                Defense += Source.Level9 * 4;
                Defense += Source.Level10 * 2;
                if (Equiped)
                {
                    chr.Defense += (short)Defense;
                    chr.UpgradeDefense += (short)Defense;
                }
                else
                {
                    chr.Defense -= (short)Defense;
                    chr.UpgradeDefense -= (short)Defense;
                }
            }

            if (chr.Hp > chr.MaxHp)
                chr.Hp = chr.MaxHp;
            if (chr.Mp > chr.MaxMp)
                chr.Mp = chr.MaxMp;

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
