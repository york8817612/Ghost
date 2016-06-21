using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Net;

namespace Server.Packet
{
    public static class PvPPacket
    {
        public static void PvPInvite(Client c, int CharacterID)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PVP_REQ))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(CharacterID);
                c.Send(plew);
            }
        }

        public static void PvPInviteResponses(Client c, int CharacterID, int Respons)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PVP_ACK))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(CharacterID);
                plew.WriteInt(Respons);
                c.Send(plew);
            }
        }

        public static void PvPStart(Client c, int CharacterID, int CompetitorID)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PVP_START))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(CharacterID);
                plew.WriteInt(CompetitorID);
                plew.WriteInt(82);
                c.Send(plew);
            }
        }

        public static void PvPEnd(Client c, int CharacterID)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PVP_END))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(CharacterID); // 贏家
                plew.WriteInt(0);
                plew.WriteInt(0); // 目前獲得%
                c.Send(plew);
            }
        }
    }
}
