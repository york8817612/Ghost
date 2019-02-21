using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Net;

namespace Server.Packet
{
    public static class TradePacket
    {
        public static void TradeInvite(Client c, int CharacterID)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.TRADE_INVITE))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(CharacterID);
                c.Send(plew);
            }
        }

        public static void TradeInviteResponses(Client c, int Respons)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.TRADE_INVITE_RESPONSES))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(Respons);
                c.Send(plew);
            }
        }

        public static void TradeReady(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.TRADE_READY))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                c.Send(plew);
            }
        }

        public static void TradeConfirm(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.TRADE_CONFIRM))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                c.Send(plew);
            }
        }

        public static void TradeCancel(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.TRADE_CANCEL))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                c.Send(plew);
            }
        }

        public static void TradeFail(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.TRADE_FAIL))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                c.Send(plew);
            }
        }

        public static void TradeSuccessful(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.TRADE_SUCCESS))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                c.Send(plew);
            }
        }

        public static void TradePutItem(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.TRADE_PUT))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(chr.CharacterID);
                plew.WriteInt(chr.Trader.CharacterID);
                plew.WriteInt(chr.Trade.Money);
                plew.WriteInt(chr.Trader.Trade.Money);
                for (int i = 0; i < 12; i++)
                {
                    plew.WriteInt(i < chr.Trade.Item.Count ? chr.Trade.Item[i].ItemID : 0); // v2
                    plew.WriteShort(i < chr.Trade.Item.Count ? chr.Trade.Item[i].Spirit : 0); // v2 + 4
                    plew.WriteShort(i < chr.Trade.Item.Count ? chr.Trade.Item[i].Quantity : 0); // v2 + 6
                    plew.WriteByte(i < chr.Trade.Item.Count ? chr.Trade.Item[i].Level1 : 0);
                    plew.WriteByte(i < chr.Trade.Item.Count ? chr.Trade.Item[i].Level2 : 0);
                    plew.WriteByte(i < chr.Trade.Item.Count ? chr.Trade.Item[i].Level3 : 0);
                    plew.WriteByte(i < chr.Trade.Item.Count ? chr.Trade.Item[i].Level4 : 0);
                    plew.WriteByte(i < chr.Trade.Item.Count ? chr.Trade.Item[i].Level5 : 0);
                    plew.WriteByte(i < chr.Trade.Item.Count ? chr.Trade.Item[i].Level6 : 0);
                    plew.WriteByte(i < chr.Trade.Item.Count ? chr.Trade.Item[i].Level7 : 0);
                    plew.WriteByte(i < chr.Trade.Item.Count ? chr.Trade.Item[i].Level8 : 0);
                    plew.WriteByte(i < chr.Trade.Item.Count ? chr.Trade.Item[i].Level9 : 0);
                    plew.WriteByte(i < chr.Trade.Item.Count ? chr.Trade.Item[i].Level10 : 0);
                    plew.WriteShort(i < chr.Trade.Item.Count ? chr.Trade.Item[i].Fusion : 0); // v2 + 18 (byte)
                    plew.WriteInt(0); // v2 + 20
                    plew.WriteByte(0); // v2 + 24
                    plew.WriteInt(0); // v5 (v2 + 25)
                    plew.WriteInt(0); // v5 + 4
                    plew.WriteInt(0); // v5 + 8
                    plew.WriteInt(0); // v5 + 12
                    plew.WriteInt(0); // v5 + 16
                    plew.WriteHexString("00 00 00");
                }
                for (int i = 0; i < 12; i++)
                {
                    plew.WriteInt(i < chr.Trader.Trade.Item.Count ? chr.Trader.Trade.Item[i].ItemID : 0); // v2
                    plew.WriteShort(i < chr.Trader.Trade.Item.Count ? chr.Trader.Trade.Item[i].Spirit : 0); // v2 + 4
                    plew.WriteShort(i < chr.Trader.Trade.Item.Count ? chr.Trader.Trade.Item[i].Quantity : 0); // v2 + 6
                    plew.WriteByte(i < chr.Trader.Trade.Item.Count ? chr.Trader.Trade.Item[i].Level1 : 0);
                    plew.WriteByte(i < chr.Trader.Trade.Item.Count ? chr.Trader.Trade.Item[i].Level2 : 0);
                    plew.WriteByte(i < chr.Trader.Trade.Item.Count ? chr.Trader.Trade.Item[i].Level3 : 0);
                    plew.WriteByte(i < chr.Trader.Trade.Item.Count ? chr.Trader.Trade.Item[i].Level4 : 0);
                    plew.WriteByte(i < chr.Trader.Trade.Item.Count ? chr.Trader.Trade.Item[i].Level5 : 0);
                    plew.WriteByte(i < chr.Trader.Trade.Item.Count ? chr.Trader.Trade.Item[i].Level6 : 0);
                    plew.WriteByte(i < chr.Trader.Trade.Item.Count ? chr.Trader.Trade.Item[i].Level7 : 0);
                    plew.WriteByte(i < chr.Trader.Trade.Item.Count ? chr.Trader.Trade.Item[i].Level8 : 0);
                    plew.WriteByte(i < chr.Trader.Trade.Item.Count ? chr.Trader.Trade.Item[i].Level9 : 0);
                    plew.WriteByte(i < chr.Trader.Trade.Item.Count ? chr.Trader.Trade.Item[i].Level10 : 0);
                    plew.WriteShort(i < chr.Trader.Trade.Item.Count ? chr.Trader.Trade.Item[i].Fusion : 0); // v2 + 18 (byte)
                    plew.WriteInt(0); // v2 + 20
                    plew.WriteByte(0); // v2 + 24
                    plew.WriteInt(0); // v5 (v2 + 25)
                    plew.WriteInt(0); // v5 + 4
                    plew.WriteInt(0); // v5 + 8
                    plew.WriteInt(0); // v5 + 12
                    plew.WriteInt(0); // v5 + 16
                    plew.WriteHexString("00 00 00");
                }
                c.Send(plew);
            }
        }
    }
}
