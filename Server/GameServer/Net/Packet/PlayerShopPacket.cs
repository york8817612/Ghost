using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Net;

namespace Server.Packet
{
    public static class PlayerShopPacket
    {
        public static void OpenShop(Client c, int Slots)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PSHOP_OPENACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(Slots);
                c.Send(plew);
            }
        }

        public static void SellStart(Client c, string Name)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PSHOP_SELLSTARTACK))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(chr.CharacterID);
                plew.WriteInt(0);
                plew.WriteString(Name, 40);
                c.Send(plew);
            }
        }

        public static void SellEnd(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PSHOP_SELLEND))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(chr.CharacterID);
                c.Send(plew);
            }
        }

        public static void SellInfo(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PSHOP_SELLINFO))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(0); // ID
                plew.WriteInt(0); // Gold
                plew.WriteInt(0);
                for (int i = 0; i < 12; i++)
                {
                    plew.WriteShort(chr.Shop.getType(i));
                    plew.WriteShort(chr.Shop.getSlot(i));
                    plew.WriteInt(chr.Shop.getQuantity(i));
                    plew.WriteInt(chr.Shop.getPrice(i));
                }
                c.Send(plew);
            }
        }

        public static void ShopInfo(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PSHOP_INFOACK))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(0); // ID
                plew.WriteString(chr.Shop.Name, 40);
                for (int i = 0; i < 12; i++)
                {
                    // 未完成
                }
                c.Send(plew);
            }
        }

        public static void Buy(Client c, int Respone)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PSHOP_BUYACK))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(Respone);
                c.Send(plew);
            }
        }
    }
}