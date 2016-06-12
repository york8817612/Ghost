using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Net;

namespace Server.Packet
{
    public static class TradePacket
    {
        public static void TradeInvite(Client c, int Respons, int CharacterID)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.TRADE_INVITE))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(Respons);
                plew.WriteInt(CharacterID);
                c.Send(plew);
            }
        }

        public static void TradeReady(Client c, int Respons, int CharacterID)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.TRADE_READY))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                c.Send(plew);
            }
        }

        public static void TradeConfirm(Client c, int Respons, int CharacterID)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.TRADE_CONFIRM))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                c.Send(plew);
            }
        }

        public static void TradeSuccessful(Client c, int Respons, int CharacterID)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.TRADE_SUCCESS))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                c.Send(plew);
            }
        }
    }
}
