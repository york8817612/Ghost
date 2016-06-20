using Server.Common.IO;
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

            Character Other = null;
            foreach (Character chr in map.Characters)
            {
                if (chr.CharacterID == CharacterID)
                {
                    Other = chr;
                    PartyPacket.PartyInvite(chr.Client, c.Character.CharacterID);
                    break;
                }
            }
            if (Other != null)
            {
                c.Character.Party = new CharacterParty(c.Character);
                Other.Party = new CharacterParty(Other);

                c.Character.Party.getMembers().Add(new Member(c.Character)); // 個人
                c.Character.Party.getMembers().Add(new Member(Other)); // 他人

                Other.Party.getMembers().Add(new Member(c.Character));
                Other.Party.getMembers().Add(new Member(Other));
            }
        }

        public static void PartyInviteResponses(InPacket lea, Client c)
        {
            int Respons = lea.ReadInt();
            foreach (Member Member in c.Character.Party.getMembers())
            {
                if (Member.Character.CharacterID == c.Character.CharacterID)
                    continue;
                PartyPacket.PartyInviteResponses(Member.Character.Client, Respons);
            }
            if (Respons == 1)
            {
                foreach (Member Member in c.Character.Party.getMembers())
                {
                    PartyPacket.PartyUpdate(Member.Character.Client);
                }
            }
        }

        public static void PartyLeave(InPacket lea, Client c)
        {
            // Bug
            Member MyCharacter = c.Character.Party.getMembers().Find(i => (i.Character.CharacterID == c.Character.CharacterID));
            foreach (Member Member in c.Character.Party.getMembers())
            {
                if (Member.Character.CharacterID != c.Character.CharacterID)
                {
                    Member.Character.Party.getMembers().Remove(MyCharacter);
                    Log.Error("Value2 = {0}", Member.Character.Party.getMembers().Count);
                    PartyPacket.PartyUpdate(Member.Character.Client);
                }
            }
            c.Character.Party = null;
        }
    }
}
