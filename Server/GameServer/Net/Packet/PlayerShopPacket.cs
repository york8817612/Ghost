using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Ghost.Characters;
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

        public static void SellStart(Client c, Character chr, string Name)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PSHOP_SELLSTARTACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(chr.CharacterID);
                plew.WriteInt(0);
                plew.WriteString(Name, 40);
                c.Send(plew);
            }
        }

        public static void SellEnd(Client c, Character chr)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PSHOP_SELLEND))
            {
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
                plew.WriteInt(chr.CharacterID);
                plew.WriteInt(chr.Shop.Money);
                plew.WriteInt(0);
                for (int i = 0; i < 12; i++)
                {
                    plew.WriteShort(i < chr.Shop.Count ? chr.Shop.getSourceType(i) : -1);
                    plew.WriteShort(i < chr.Shop.Count ? chr.Shop.getSourceSlot(i) : -1);
                    plew.WriteInt(i < chr.Shop.Count ? chr.Shop.getQuantity(i) : 0);
                    plew.WriteInt(i < chr.Shop.Count ? chr.Shop.getPrice(i) : 0);
                }
                c.Send(plew);
            }
        }

        public static void ShopInfo(Client c, Character Seller, int CharacterID)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PSHOP_INFOACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(CharacterID);
                plew.WriteString(Seller.Shop.Name, 40);
                for (int i = 0; i < 12; i++)
                {
                    plew.WriteInt(i < Seller.Shop.Count ? Seller.Shop.getItemID(i) : 0);
                    plew.WriteShort(0);
                    plew.WriteShort(i < Seller.Shop.Count ? Seller.Shop.getQuantity(i) : 0);
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                    plew.WriteShort(0);
                    plew.WriteShort(i < Seller.Shop.Count ? Seller.Shop.getIsLocked(i) : 0);
                    plew.WriteInt(i < Seller.Shop.Count ? Seller.Shop.getPrice(i) : 0);
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                    plew.WriteInt(0);
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