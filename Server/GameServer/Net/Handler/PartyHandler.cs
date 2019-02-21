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
                    if (Other.Party.getMembers().Count == 0)
                        PartyPacket.PartyInvite(chr.Client, c.Character.CharacterID);
                    break;
                }
            }
            if (Other != null)
            {
                if (Other.Party.getMembers().Count == 0)
                {
                    // 個人 + 其他隊員
                    if (c.Character.Party.getMembers().Count == 0)
                        c.Character.Party.getMembers().Add(new Member(c.Character)); // 隊長
                    c.Character.Party.getMembers().Add(new Member(Other)); // 對方
                    foreach (var chr in c.Character.Party.getMembers())
                    {
                        if (chr.Character.CharacterID != c.Character.CharacterID && chr.Character.CharacterID != Other.CharacterID)
                        {
                            chr.Character.Party.getMembers().Add(new Member(Other));
                        }
                    }
                    // 對方
                    Other.Party.getMembers().Add(new Member(c.Character)); // 隊長
                    Other.Party.getMembers().Add(new Member(Other)); // 對方
                    foreach (var chr in c.Character.Party.getMembers())
                    {
                        if (chr.Character.CharacterID != c.Character.CharacterID && chr.Character.CharacterID != Other.CharacterID)
                        {
                            chr.Character.Party.getMembers().Add(chr);
                        }
                    }
                }
            }
        }

        public static void PartyInviteResponses(InPacket lea, Client c)
        {
            int Respons = lea.ReadInt();

            if (Respons == 0)
            {
                PartyPacket.PartyInviteResponses(c.Character.Party.getMembers()[0].Character.Client, Respons);

                Member find = null;
                foreach (var chr in c.Character.Party.getMembers())
                {
                    if (chr.Character.CharacterID == c.Character.CharacterID)
                    {
                        find = chr;
                        break;
                    }
                }
                foreach (var chr in c.Character.Party.getMembers())
                {
                    if (chr.Character.CharacterID != c.Character.CharacterID)
                    {
                        chr.Character.Party.getMembers().Remove(find);
                    }
                }
                c.Character.Party.getMembers().Clear();
            }
            else if (Respons == 1)
            {
                PartyPacket.PartyInviteResponses(c, Respons);
                foreach (var chr in c.Character.Party.getMembers())
                {
                    PartyPacket.PartyUpdate(chr.Character.Client);
                }
            }
        }

        public static void PartyLeave(InPacket lea, Client c)
        {
            Member find = null;
            foreach (var chr in c.Character.Party.getMembers())
            {
                if (chr.Character.CharacterID == c.Character.CharacterID)
                {
                    find = chr;
                    break;
                }
            }

            if (find == null)
                return;

            foreach (var chr in c.Character.Party.getMembers())
            {
                if (chr.Character.CharacterID != c.Character.CharacterID)
                {
                    chr.Character.Party.getMembers().Remove(find);
                    PartyPacket.PartyUpdate(chr.Character.Client);
                }
            }
            c.Character.Party.getMembers().Clear();
            PartyPacket.PartyUpdate(c);
            c.Character.Party = null;
        }
    }
}
