using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Common.Threading;
using Server.Ghost;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;

namespace Server.Handler
{
    public static class StatusHandler
    {
        public static void Char_Damage_Req(InPacket lea, Client c)
        {
            short Damage = lea.ReadShort();
            var chr = c.Character;

            if (Damage < 0)
                Damage = short.MaxValue;

            chr.Hp -= Damage;
            if (chr.Hp <= 0)
            {
                chr.IsAlive = false;
                if (!(chr.MapX == 10 && chr.MapY == 60) && !(chr.MapX == 10 && chr.MapY == 61) && !(chr.MapX == 10 && chr.MapY == 62) && !(chr.MapX == 10 && chr.MapY == 63) && !(chr.MapX == 10 && chr.MapY == 64))
                {
                    chr.Exp -= (int)(GameConstants.getExpNeededForLevel(chr.Level) * 0.2);
                    if (chr.Exp < 0)
                        chr.Exp = 0;
                    StatusPacket.UpdateExp(c);
                }
                MapPacket.userDead(c);
                if (chr.Competitor != null)
                {
                    PvPPacket.PvPEnd(c, chr.Competitor.CharacterID);
                    PvPPacket.PvPEnd(chr.Competitor.Client, chr.Competitor.CharacterID);
                    chr.Competitor = null;
                    chr.Competitor.Competitor = null;
                }
                chr.Hp = 1;
                chr.Mp = 1;
            }
            StatusPacket.UpdateHpMp(c, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
        }

        public static void Char_Dead_Req(InPacket lea, Client c)
        {
            //var chr = c.Character;
            //if (chr.IsAlive == true)
            //{
            //    chr.IsAlive = false;
            //    chr.Hp = 1;
            //    chr.Mp = 1;
            //    chr.Exp -= (int)(GameConstants.getExpNeededForLevel(chr.Level) * 0.2);
            //    if (chr.Exp < 0)
            //        chr.Exp = 0;
            //    MapPacket.userDead(c);
            //    StatusPacket.UpdateExp(c);
            //    if (chr.Competitor != null)
            //    {
            //        PvPPacket.PvPEnd(c, chr.Competitor.CharacterID);
            //        PvPPacket.PvPEnd(chr.Competitor.Client, chr.Competitor.CharacterID);
            //        chr.Competitor = null;
            //        chr.Competitor.Competitor = null;
            //    }
            //}
            //StatusPacket.getStatusInfo(c);
        }

        public static void Char_Statup_Req(InPacket lea, Client gc)
        {
            int stat = lea.ReadInt();
            var chr = gc.Character;

            if (chr.AbilityBonus < 1)
                return;

            switch (stat)
            {
                case 1: // 力量
                    chr.Str++;
                    chr.MaxHp += 3;
                    if (chr.Str % 5 != 0)
                        chr.MaxAttack += 2;
                    else
                        chr.MaxAttack += 3;
                    break;
                case 2: // 精力
                    chr.Dex++;
                    if (chr.Dex % 5 != 0)
                    {
                        chr.Attack += 1;
                        chr.MaxAttack += 2;
                    }
                    else
                    {
                        chr.Attack += 2;
                        chr.MaxAttack += 3;
                    }
                    break;
                case 3: // 氣力
                    chr.Vit++;
                    chr.Defense += 5;
                    chr.MaxHp += 20;
                    break;
                case 4: // 智力
                    chr.Int++;
                    chr.MaxMp += 3;
                    if (chr.Int % 5 != 0)
                    {
                        chr.Magic += 2;
                        chr.MaxMagic += 2;
                    }
                    else
                    {
                        chr.Magic += 3;
                        chr.MaxMagic += 3;
                    }
                    break;
                default:
                    break;
            }
            chr.AbilityBonus--;
            StatusPacket.UpdateStat(gc);
        }

        public static void Char_Fury_Req(InPacket lea, Client c)
        {
            int Type = lea.ReadInt();

            var chr = c.Character;

            if (Type == 0 || chr.IsFuring == true || chr.Fury != chr.MaxFury)
                return;

            Map Map = MapFactory.GetMap(chr.MapX, chr.MapY);

            if (Type == 1)
            {
                short UpgradeAttack = (short)(chr.Attack * 0.2);
                short UpgradeMagic = (short)(chr.Magic * 0.2);
                short UpgradeDefense = (short)(chr.Defense * 0.2);

                chr.IsFuring = true;
                chr.FuryAttack = UpgradeAttack;
                chr.FuryMagic = UpgradeMagic;
                chr.FuryDefense = UpgradeDefense;

                chr.MaxAttack += UpgradeAttack;
                chr.Attack += UpgradeAttack;
                chr.MaxMagic += UpgradeMagic;
                chr.Magic += UpgradeMagic;
                chr.Defense += UpgradeDefense;

                StatusPacket.getStatusInfo(c);
                foreach (Character All in Map.Characters)
                {
                    StatusPacket.Fury(All.Client, chr, Type);
                }

                chr.Fury = 0;
                chr.FuringType = 1;

                Delay tmr = null;
                tmr = new Delay(30000, false, () =>
                {
                    chr.IsFuring = false;
                    chr.MaxAttack -= UpgradeAttack;
                    chr.Attack -= UpgradeAttack;
                    chr.MaxMagic -= UpgradeMagic;
                    chr.Magic -= UpgradeMagic;
                    chr.Defense -= UpgradeDefense;
                    StatusPacket.getStatusInfo(c);
                    foreach (Character All in Map.Characters)
                    {
                        StatusPacket.Fury(All.Client, chr, 0);
                    }
                });
                tmr.Execute();
            }
            else if (Type == 2)
            {
                Skill Skill = chr.Skills[2, 0];

                if (Skill == null)
                    return;

                int Time = 1;

                switch (Skill.SkillLevel)
                {
                    case 1:
                        Time = 30000;
                        break;
                    case 2:
                        Time = 32000;
                        break;
                    case 3:
                        Time = 34000;
                        break;
                    case 4:
                        Time = 36000;
                        break;
                    case 5:
                        Time = 38000;
                        break;
                    case 6:
                        Time = 40000;
                        break;
                    case 7:
                        Time = 42000;
                        break;
                    case 8:
                        Time = 44000;
                        break;
                    case 9:
                        Time = 46000;
                        break;
                    case 10:
                        Time = 48000;
                        break;
                    case 11:
                        Time = 50000;
                        break;
                    case 12:
                        Time = 52000;
                        break;
                    case 13:
                        Time = 53000;
                        break;
                    case 14:
                        Time = 54000;
                        break;
                    case 15:
                        Time = 55000;
                        break;
                    case 16:
                        Time = 56000;
                        break;
                    case 17:
                        Time = 57000;
                        break;
                    case 18:
                        Time = 58000;
                        break;
                    case 19:
                        Time = 59000;
                        break;
                    case 20:
                        Time = 60000;
                        break;
                }

                short UpgradeAttack = (short)(chr.Attack * 0.2 * Skill.SkillLevel);
                short UpgradeMagic = (short)(chr.Magic * 0.2 * Skill.SkillLevel);
                short UpgradeDefense = (short)(chr.Defense * 0.2 * Skill.SkillLevel);

                chr.IsFuring = true;
                chr.FuryAttack = UpgradeAttack;
                chr.FuryMagic = UpgradeMagic;
                chr.FuryDefense = UpgradeDefense;

                chr.MaxAttack += UpgradeAttack;
                chr.Attack += UpgradeAttack;
                chr.MaxMagic += UpgradeMagic;
                chr.Magic += UpgradeMagic;
                chr.Defense += UpgradeDefense;

                StatusPacket.getStatusInfo(c);
                foreach (Character All in Map.Characters)
                {
                    StatusPacket.Fury(All.Client, chr, Type);
                }

                chr.Fury = 0;
                chr.FuringType = 2;

                Delay tmr = null;
                tmr = new Delay(Time, false, () =>
                {
                    chr.IsFuring = false;
                    chr.MaxAttack -= UpgradeAttack;
                    chr.Attack -= UpgradeAttack;
                    chr.MaxMagic -= UpgradeMagic;
                    chr.Magic -= UpgradeMagic;
                    chr.Defense -= UpgradeDefense;
                    StatusPacket.getStatusInfo(c);
                    foreach (Character All in Map.Characters)
                    {
                        StatusPacket.Fury(All.Client, chr, 0);
                    }
                });
                tmr.Execute();
            }
        }
    }
}
