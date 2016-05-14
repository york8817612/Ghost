using Server.Common.IO.Packet;
using Server.Ghost;

namespace Server.Handler
{
    class StatusHandler
    {
        public static void Char_Statup_Req(InPacket lea, Client gc)
        {
            int stat = lea.ReadInt();
            var chr = gc.Character;
            switch (stat)
            {

                case 1:
                    chr.Str++;
                    chr.MaxHp += 30;
                    chr.MaxAttack += 3;
                    break;
                case 2:
                    chr.Dex++;
                    chr.Attack += 3;
                    chr.MaxAttack += 3;
                    break;
                case 3:
                    chr.Vit++;
                    chr.Defense += 10;
                    chr.MaxHp += 30;
                    break;
                case 4:
                    chr.Int++;
                    chr.Mp += 30;
                    chr.Magic += 3;
                    chr.MaxMagic += 3;
                    break;
            }
            chr.AbilityBonus--;
            StatusPacket.updateStat(gc);
        }
    }
}
