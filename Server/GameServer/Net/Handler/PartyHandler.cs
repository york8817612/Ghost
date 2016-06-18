using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;

namespace Server.Handler
{
    public static class PartyHandler
    {
        public static void PartyInvite(InPacket lea, Client c)
        {
            int CharacterID = lea.ReadInt();
            Map map = MapFactory.GetMap(c.Character.MapX, c.Character.MapY);
            foreach (Character chr in map.Characters)
            {
                if (chr.CharacterID == CharacterID)
                {
                    PartyPacket.PartyInvite(chr.Client, c.Character.CharacterID);
                    c.Character.Party.getMembers().Add(new PartyMember(chr.CharacterID, chr.Name, chr.Level, chr.MaxHp, chr.Hp, chr.MaxMp, chr.Mp));
                    chr.Party.getMembers().Add(new PartyMember(c.Character.CharacterID, c.Character.Name, c.Character.Level, c.Character.MaxHp, c.Character.Hp, c.Character.MaxMp, c.Character.Mp));
                    break;
                }
            }
        }

        public static void PartyInviteResponses(InPacket lea, Client c)
        {
            int Respons = lea.ReadInt();
            PartyPacket.PartyInviteResponses(c,c.Character.CharacterID, Respons);
            if (Respons == 1)
                PartyPacket.PartyUpdate(c);
        }
    }
}
