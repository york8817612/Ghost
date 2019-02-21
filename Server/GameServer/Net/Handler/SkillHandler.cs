using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Common.Threading;
using Server.Ghost;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;
using System.Collections.Generic;

namespace Server.Handler
{
    public static class SkillHandler
    {
        public static void UseSkill_Req(InPacket lea, Client gc)
        {
            byte Type = lea.ReadByte();
            byte Slot = lea.ReadByte();
            byte Level = lea.ReadByte();
            byte NumOfTargets = lea.ReadByte();
            int Active = lea.ReadInt();
            var chr = gc.Character;

            Map Map = MapFactory.GetMap(chr.MapX, chr.MapY);

            if (Type == 0 || Type == 1 || Type == 2 || Type == 3 || Type == 4)
            {
                Skill Skill = null;
                foreach (Skill sl in chr.Skills.getSkills())
                {
                    if (sl.Type.Equals(Type) && sl.Slot.Equals(Slot) && sl.SkillLevel.Equals(Level))
                    {
                        Skill = sl;
                    }
                }
                switch (Skill.SkillID)
                {
                    case 0:
                        break;
                    case 1:
                        if (Skill.SkillLevel < 5)
                            chr.Mp -= 2;
                        else
                            chr.Mp -= 4;
                        break;
                    case 2:
                        break;
                    case 3:
                        if (Active == 1)
                        {
                            Delay ddl = new Delay(1, false, null);
                            chr.SkillState.Add(Skill.SkillID, ddl);
                            chr.SkillState[Skill.SkillID] = new Delay(8000, true, () =>
                            {
                                int addHp = 0, addMp = 0;
                                if ((chr.Hp + 8) < chr.MaxHp)
                                {
                                    addHp = 8;
                                }
                                else
                                {
                                    addHp = chr.MaxHp - chr.Hp;
                                    if (addHp > 8)
                                        addHp = 8;
                                }
                                if ((chr.Mp + 2) < chr.MaxMp)
                                {
                                    addMp = 2;
                                }
                                else
                                {
                                    addMp = chr.MaxMp - chr.Mp;
                                    if (addMp > 2)
                                        addMp = 2;
                                }
                                chr.Hp += (short)addHp;
                                chr.Mp += (short)addMp;
                                StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
                            }
                            );
                            chr.SkillState[Skill.SkillID].Execute();
                        }
                        else
                        {
                            chr.SkillState[Skill.SkillID].Cancel();
                            chr.SkillState.Remove(Skill.SkillID);
                        }
                        break;
                    case 4:
                        chr.Mp -= (short)5;
                        StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
                        break;
                    case 10104: // 氣力轉換
                        chr.Hp -= (short)(5 * Skill.SkillLevel);
                        chr.Mp += (short)(16 * Skill.SkillLevel);
                        if (chr.Hp < 0)
                            chr.Hp = 0;
                        if (chr.Mp > chr.MaxMp)
                            chr.Mp = chr.MaxMp;
                        break;
                    case 10107: // 狂暴怒氣
                        if (chr.SkillState.ContainsKey(10107))
                            chr.SkillState[10107].Cancel();

                        short Mp = 26;
                        short Defense = (short)(chr.Defense * 0.03);
                        short Attack = (short)(chr.Attack * 0.01);
                        int Time = 33;
                        switch (Skill.SkillLevel)
                        {
                            case 1:
                                Mp = 26;
                                Defense = (short)(chr.Defense * 0.03);
                                Attack = (short)(chr.Attack * 0.01);
                                Time = 33;
                                break;
                            case 2:
                                Mp = 26;
                                Defense = (short)(chr.Defense * 0.06);
                                Attack = (short)(chr.Attack * 0.02);
                                Time = 36;
                                break;
                            case 3:
                                Mp = 26;
                                Defense = (short)(chr.Defense * 0.09);
                                Attack = (short)(chr.Attack * 0.03);
                                Time = 39;
                                break;
                            case 4:
                                Mp = 26;
                                Defense = (short)(chr.Defense * 0.12);
                                Attack = (short)(chr.Attack * 0.04);
                                Time = 42;
                                break;
                            case 5:
                                Mp = 26;
                                Defense = (short)(chr.Defense * 0.15);
                                Attack = (short)(chr.Attack * 0.05);
                                Time = 45;
                                break;
                            case 6:
                                Mp = 52;
                                Defense = (short)(chr.Defense * 0.18);
                                Attack = (short)(chr.Attack * 0.06);
                                Time = 48;
                                break;
                            case 7:
                                Mp = 52;
                                Defense = (short)(chr.Defense * 0.21);
                                Attack = (short)(chr.Attack * 0.07);
                                Time = 51;
                                break;
                            case 8:
                                Mp = 52;
                                Defense = (short)(chr.Defense * 0.24);
                                Attack = (short)(chr.Attack * 0.08);
                                Time = 54;
                                break;
                            case 9:
                                Mp = 52;
                                Defense = (short)(chr.Defense * 0.27);
                                Attack = (short)(chr.Attack * 0.09);
                                Time = 57;
                                break;
                            case 10:
                                Mp = 52;
                                Defense = (short)(chr.Defense * 0.30);
                                Attack = (short)(chr.Attack * 0.10);
                                Time = 60;
                                break;
                            case 11:
                                Mp = 78;
                                Defense = (short)(chr.Defense * 0.33);
                                Attack = (short)(chr.Attack * 0.11);
                                Time = 63;
                                break;
                            case 12:
                                Mp = 78;
                                Defense = (short)(chr.Defense * 0.36);
                                Attack = (short)(chr.Attack * 0.12);
                                Time = 66;
                                break;
                            case 13:
                                Mp = 78;
                                Defense = (short)(chr.Defense * 0.39);
                                Attack = (short)(chr.Attack * 0.13);
                                Time = 69;
                                break;
                            case 14:
                                Mp = 78;
                                Defense = (short)(chr.Defense * 0.42);
                                Attack = (short)(chr.Attack * 0.14);
                                Time = 72;
                                break;
                            case 15:
                                Mp = 78;
                                Defense = (short)(chr.Defense * 0.45);
                                Attack = (short)(chr.Attack * 0.15);
                                Time = 75;
                                break;
                            case 16:
                                Mp = 104;
                                Defense = (short)(chr.Defense * 0.48);
                                Attack = (short)(chr.Attack * 0.16);
                                Time = 78;
                                break;
                            case 17:
                                Mp = 104;
                                Defense = (short)(chr.Defense * 0.51);
                                Attack = (short)(chr.Attack * 0.17);
                                Time = 81;
                                break;
                            case 18:
                                Mp = 104;
                                Defense = (short)(chr.Defense * 0.54);
                                Attack = (short)(chr.Attack * 0.18);
                                Time = 84;
                                break;
                            case 19:
                                Mp = 104;
                                Defense = (short)(chr.Defense * 0.57);
                                Attack = (short)(chr.Attack * 0.19);
                                Time = 87;
                                break;
                            case 20:
                                Mp = 104;
                                Defense = (short)(chr.Defense * 0.60);
                                Attack = (short)(chr.Attack * 0.20);
                                Time = 90;
                                break;
                        }
                        chr.Mp -= Mp;
                        if (chr.Mp < 0)
                            chr.Mp = 0;

                        if (!chr.SkillState.ContainsKey(10107))
                        {
                            chr.Defense -= Defense;
                            chr.MaxAttack += Attack;
                            chr.Attack += Attack;
                            chr.UpgradeAttack += Attack;
                            if (chr.Defense < 0)
                                chr.Defense = 0;
                            chr.SkillAttack_10107 = Attack;
                            chr.SkillDefense_10107 = Defense;
                            chr.SkillState.Add(Skill.SkillID, null);
                            StatusPacket.UpdateStat(gc);
                        }
                        chr.SkillState[Skill.SkillID] = new Delay(Time * 1000, false, () =>
                        {
                            chr.Defense += Defense;
                            chr.MaxAttack -= Attack;
                            chr.Attack -= Attack;
                            chr.UpgradeAttack -= Attack;
                            chr.SkillState.Remove(10107);
                            StatusPacket.UpdateStat(gc);
                        });
                        chr.SkillState[Skill.SkillID].Execute();
                        break;
                    case 10207: // 霧影術
                        chr.IsHiding = true;
                        foreach (Character All in Map.Characters)
                            StatusPacket.Hide(All.Client, chr, 1);
                        break;
                    case 10309: // 防護加持
                        if (chr.SkillState.ContainsKey(10309))
                            chr.SkillState[10309].Cancel();

                        Mp = 34;
                        Defense = (short)(chr.Defense * 0.03);
                        Time = 35;
                        switch (Skill.SkillLevel)
                        {
                            case 1:
                                Mp = 34;
                                Defense = (short)(chr.Defense * 0.03);
                                Time = 35;
                                break;
                            case 2:
                                Mp = 34;
                                Defense = (short)(chr.Defense * 0.06);
                                Time = 40;
                                break;
                            case 3:
                                Mp = 34;
                                Defense = (short)(chr.Defense * 0.09);
                                Time = 45;
                                break;
                            case 4:
                                Mp = 34;
                                Defense = (short)(chr.Defense * 0.12);
                                Time = 50;
                                break;
                            case 5:
                                Mp = 34;
                                Defense = (short)(chr.Defense * 0.15);
                                Time = 55;
                                break;
                            case 6:
                                Mp = 68;
                                Defense = (short)(chr.Defense * 0.18);
                                Time = 60;
                                break;
                            case 7:
                                Mp = 68;
                                Defense = (short)(chr.Defense * 0.21);
                                Time = 65;
                                break;
                            case 8:
                                Mp = 68;
                                Defense = (short)(chr.Defense * 0.24);
                                Time = 70;
                                break;
                            case 9:
                                Mp = 68;
                                Defense = (short)(chr.Defense * 0.27);
                                Time = 75;
                                break;
                            case 10:
                                Mp = 68;
                                Defense = (short)(chr.Defense * 0.30);
                                Time = 80;
                                break;
                            case 11:
                                Mp = 102;
                                Defense = (short)(chr.Defense * 0.33);
                                Time = 85;
                                break;
                            case 12:
                                Mp = 102;
                                Defense = (short)(chr.Defense * 0.36);
                                Time = 90;
                                break;
                            case 13:
                                Mp = 102;
                                Defense = (short)(chr.Defense * 0.39);
                                Time = 95;
                                break;
                            case 14:
                                Mp = 102;
                                Defense = (short)(chr.Defense * 0.42);
                                Time = 100;
                                break;
                            case 15:
                                Mp = 102;
                                Defense = (short)(chr.Defense * 0.45);
                                Time = 105;
                                break;
                            case 16:
                                Mp = 136;
                                Defense = (short)(chr.Defense * 0.48);
                                Time = 110;
                                break;
                            case 17:
                                Mp = 136;
                                Defense = (short)(chr.Defense * 0.51);
                                Time = 115;
                                break;
                            case 18:
                                Mp = 136;
                                Defense = (short)(chr.Defense * 0.54);
                                Time = 120;
                                break;
                            case 19:
                                Mp = 136;
                                Defense = (short)(chr.Defense * 0.57);
                                Time = 125;
                                break;
                            case 20:
                                Mp = 136;
                                Defense = (short)(chr.Defense * 0.60);
                                Time = 130;
                                break;
                        }
                        chr.Mp -= Mp;
                        if (chr.Mp < 0)
                            chr.Mp = 0;

                        if (!chr.SkillState.ContainsKey(10309))
                        {
                            chr.Defense += Defense;
                            chr.UpgradeDefense += Defense;
                            chr.SkillDefense_10309 = Defense;
                            chr.SkillState.Add(Skill.SkillID, null);
                            StatusPacket.UpdateStat(gc);
                        }
                        chr.SkillState[Skill.SkillID] = new Delay(Time * 1000, false, () =>
                        {
                            chr.Defense -= Defense;
                            chr.UpgradeDefense -= Defense;
                            chr.SkillState.Remove(10309);
                            StatusPacket.UpdateStat(gc);
                        });
                        chr.SkillState[Skill.SkillID].Execute();
                        break;
                    case 10310: // 陰陽幻移
                        chr.Hp += (short)(16 * Skill.SkillLevel);
                        chr.Mp -= (short)(5 * Skill.SkillLevel);
                        if (chr.Hp > chr.MaxHp)
                            chr.Hp = chr.MaxHp;
                        if (chr.Mp < 0)
                            chr.Mp = 0;
                        break;
                    default:
                        //Log.Inform("[Use Skill] SkillID = {0}", skill.SkillID);
                        break;
                }
            }
        }

        public static void SkillLevelUp_Req(InPacket lea, Client gc)
        {
            byte Type = lea.ReadByte();
            byte Slot = lea.ReadByte();

            var chr = gc.Character;

            if (chr.SkillBonus < 1)
                return;

            List<Skill> s = chr.Skills.getSkills();
            Skill sl = null;
            foreach (Skill skill in s)
            {
                if (skill.Type == Type && skill.Slot == Slot)
                {
                    sl = skill;
                    break;
                }
            }

            if (sl == null || (sl.SkillID == 1 && sl.SkillLevel + 1 > 5) || (sl.SkillID == 2 && sl.SkillLevel + 1 > 10) || (sl.SkillID == 3 && sl.SkillLevel + 1 > 20) || (sl.SkillID == 4 && sl.SkillLevel + 1 > 20) || sl.SkillLevel + 1 > 20)
                return;

            chr.SkillBonus--;
            sl.SkillLevel++;

            if (sl.SkillID == 10101 || sl.SkillID == 10201 || sl.SkillID == 10301 || sl.SkillID == 10401 || sl.SkillID == 10501 || sl.SkillID == 10102 || sl.SkillID == 10202 || sl.SkillID == 10302 || sl.SkillID == 10402 || sl.SkillID == 10502)
            {
                if (chr.Items[InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Weapon] != null)
                {
                    int ItemID = chr.Items[InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Weapon].ItemID;
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
                    if (InventoryType.Is劍(ItemID) && sl.SkillID == 10101)
                    {
                        chr.MaxAttack -= (short)(MaxAttack * 0.02 * (sl.SkillLevel - 1));
                        chr.Attack -= (short)(Attack * 0.02 * (sl.SkillLevel - 1));
                        chr.MaxAttack += (short)(MaxAttack * 0.02 * sl.SkillLevel);
                        chr.Attack += (short)(Attack * 0.02 * sl.SkillLevel);
                    }
                    if (InventoryType.Is刀(ItemID) && sl.SkillID == 10102)
                    {
                        chr.MaxAttack -= (short)(MaxAttack * 0.03 * (sl.SkillLevel - 1));
                        chr.Attack -= (short)(Attack * 0.03 * (sl.SkillLevel - 1));
                        chr.MaxAttack += (short)(MaxAttack * 0.03 * sl.SkillLevel);
                        chr.Attack += (short)(Attack * 0.03 * sl.SkillLevel);
                    }
                    if (InventoryType.Is手套(ItemID) && sl.SkillID == 10201)
                    {
                        chr.MaxAttack -= (short)(MaxAttack * 0.02 * (sl.SkillLevel - 1));
                        chr.Attack -= (short)(Attack * 0.02 * (sl.SkillLevel - 1));
                        chr.MaxAttack += (short)(MaxAttack * 0.02 * sl.SkillLevel);
                        chr.Attack += (short)(Attack * 0.02 * sl.SkillLevel);
                    }
                    if (InventoryType.Is爪(ItemID) && sl.SkillID == 10202)
                    {
                        chr.MaxAttack -= (short)(MaxAttack * 0.03 * (sl.SkillLevel - 1));
                        chr.Attack -= (short)(Attack * 0.03 * (sl.SkillLevel - 1));
                        chr.MaxAttack += (short)(MaxAttack * 0.03 * sl.SkillLevel);
                        chr.Attack += (short)(Attack * 0.03 * sl.SkillLevel);
                    }
                    if (InventoryType.Is扇(ItemID) && sl.SkillID == 10301)
                    {
                        chr.MaxMagic -= (short)(MaxMagic * 0.02 * (sl.SkillLevel - 1));
                        chr.Magic -= (short)(Magic * 0.02 * (sl.SkillLevel - 1));
                        chr.MaxMagic += (short)(MaxMagic * 0.02 * sl.SkillLevel);
                        chr.Magic += (short)(Magic * 0.02 * sl.SkillLevel);
                    }
                    if (InventoryType.Is杖(ItemID) && sl.SkillID == 10302)
                    {
                        chr.MaxMagic -= (short)(MaxMagic * 0.03 * (sl.SkillLevel - 1));
                        chr.Magic -= (short)(Magic * 0.03 * (sl.SkillLevel - 1));
                        chr.MaxMagic += (short)(MaxMagic * 0.03 * sl.SkillLevel);
                        chr.Magic += (short)(Magic * 0.03 * sl.SkillLevel);
                    }
                    if (InventoryType.Is斧(ItemID) && sl.SkillID == 10401)
                    {
                        chr.MaxAttack -= (short)(MaxAttack * 0.02 * (sl.SkillLevel - 1));
                        chr.Attack -= (short)(Attack * 0.02 * (sl.SkillLevel - 1));
                        chr.MaxAttack += (short)(MaxAttack * 0.02 * sl.SkillLevel);
                        chr.Attack += (short)(Attack * 0.02 * sl.SkillLevel);
                    }
                    if (InventoryType.Is輪(ItemID) && sl.SkillID == 10402)
                    {
                        chr.MaxAttack -= (short)(MaxAttack * 0.03 * (sl.SkillLevel - 1));
                        chr.Attack -= (short)(Attack * 0.03 * (sl.SkillLevel - 1));
                        chr.MaxAttack += (short)(MaxAttack * 0.03 * sl.SkillLevel);
                        chr.Attack += (short)(Attack * 0.03 * sl.SkillLevel);
                    }
                    //if (Skill.ContainsKey(10501) && InventoryType.Is(chr.Items[InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Weapon].ItemID))
                    //{

                    //}
                    //if (Skill.ContainsKey(10502) && InventoryType.Is(chr.Items[InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Weapon].ItemID))
                    //{

                    //}
                    StatusPacket.UpdateStat(gc);
                }
            }

            SkillPacket.updateSkillLevel(gc, chr.SkillBonus, Type, Slot, sl.SkillLevel);
        }
    }
}
