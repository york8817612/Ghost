using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;

namespace Server.Handler
{
    public static class PvPHandler
    {
        public static void PvPInvite(InPacket lea, Client c)
        {
            int CharacterID = lea.ReadInt();
            Map map = MapFactory.GetMap(c.Character.MapX, c.Character.MapY);

            foreach (Character chr in map.Characters)
            {
                if (chr.CharacterID == CharacterID)
                {
                    c.Character.Competitor = chr;
                    chr.Competitor = c.Character;
                    PvPPacket.PvPInvite(chr.Client, CharacterID);
                    break;
                }
            }
        }

        public static void PvPInviteResponses(InPacket lea, Client c)
        {
            int CharacterID = lea.ReadInt();
            int Respons = lea.ReadInt();
            Map map = MapFactory.GetMap(c.Character.MapX, c.Character.MapY);

            PvPPacket.PvPInviteResponses(c.Character.Competitor.Client, CharacterID, Respons);
            if (Respons == 1)
            {
                PvPPacket.PvPStart(c, c.Character.CharacterID, c.Character.Competitor.CharacterID);
                PvPPacket.PvPStart(c.Character.Competitor.Client, c.Character.CharacterID, c.Character.Competitor.CharacterID);
            }
        }
    }
}
