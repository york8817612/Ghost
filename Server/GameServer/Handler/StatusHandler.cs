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
                    break;
                case 2:
                    chr.Dex++;
                    break;
                case 3:
                    chr.Vit++;
                    break;
                case 4:
                    chr.Int++;
                    break;
            }
            chr.AbilityBonus--;
            StatusPacket.updateStat(gc);
        }
    }
}
