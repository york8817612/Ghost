using Server.Common.Constants;
using Server.Common.IO.Packet;
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
            chr.Hp -= Damage;
            if (chr.Hp <= 0)
            {
                chr.IsAlive = false;
                chr.Hp = 1;
                chr.Mp = 1;
                chr.Exp -= (int)(GameConstants.getExpNeededForLevel(chr.Level) * 0.2);
                if (chr.Exp < 0)
                    chr.Exp = 0;
                MapPacket.userDead(c);
                StatusPacket.UpdateExp(c);
                if (chr.Competitor != null)
                {
                    PvPPacket.PvPEnd(c, chr.Competitor.CharacterID);
                    PvPPacket.PvPEnd(chr.Competitor.Client, chr.Competitor.CharacterID);
                    chr.Competitor = null;
                    chr.Competitor.Competitor = null;
                }
                return;
            }
            StatusPacket.UpdateHpMp(c, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
        }

        public static void Char_Dead_Req(InPacket lea, Client c)
        {
            var chr = c.Character;
            if (chr.IsAlive == true)
            {
                chr.IsAlive = false;
                chr.Hp = 1;
                chr.Mp = 1;
                chr.Exp -= (int)(GameConstants.getExpNeededForLevel(chr.Level) * 0.2);
                if (chr.Exp < 0)
                    chr.Exp = 0;
                MapPacket.userDead(c);
                StatusPacket.UpdateExp(c);
                if (chr.Competitor != null)
                {
                    PvPPacket.PvPEnd(c, chr.Competitor.CharacterID);
                    PvPPacket.PvPEnd(chr.Competitor.Client, chr.Competitor.CharacterID);
                    chr.Competitor = null;
                    chr.Competitor.Competitor = null;
                }
            }
            StatusPacket.getStatusInfo(c);
        }

        public static void Char_Statup_Req(InPacket lea, Client gc)
        {
            int stat = lea.ReadInt();
            var chr = gc.Character;
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
    }
}
