using Server.Common.IO.Packet;
using Server.Net;
using Server.Packet;

namespace Server.Handler
{
    public static class PartyHandler
    {
        public static void PartyInvite(InPacket lea, Client c)
        {
            int CharacterID = lea.ReadInt();
            PartyPacket.PartyInvite(c, CharacterID, 1);
        }
    }
}
