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

        public static void PvPStart(Client c, int CharacterID_1, int CharacterID_2)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PVP_START))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(CharacterID_1);
                plew.WriteInt(CharacterID_2);
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
