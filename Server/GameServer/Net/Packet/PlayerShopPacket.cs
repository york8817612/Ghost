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
                    plew.WriteShort(i < chr.Shop.Count ? chr.Shop.SourceType(i) : -1);
                    plew.WriteShort(i < chr.Shop.Count ? chr.Shop.SourceSlot(i) : -1);
                    plew.WriteInt(i < chr.Shop.Count ? chr.Shop.Quantity(i) : 0);
                    plew.WriteInt(i < chr.Shop.Count ? chr.Shop.Price(i) : 0);
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
                    plew.WriteInt(i < Seller.Shop.Count ? Seller.Shop.ItemID(i) : 0);
                    plew.WriteShort(i < Seller.Shop.Count ? Seller.Shop.Spirit(i) : 0);
                    plew.WriteShort(i < Seller.Shop.Count ? Seller.Shop.Quantity(i) : 0);
                    plew.WriteByte(i < Seller.Shop.Count ? Seller.Shop.Level1(i) : 0);
                    plew.WriteByte(i < Seller.Shop.Count ? Seller.Shop.Level2(i) : 0);
                    plew.WriteByte(i < Seller.Shop.Count ? Seller.Shop.Level3(i) : 0);
                    plew.WriteByte(i < Seller.Shop.Count ? Seller.Shop.Level4(i) : 0);
                    plew.WriteByte(i < Seller.Shop.Count ? Seller.Shop.Level5(i) : 0);
                    plew.WriteByte(i < Seller.Shop.Count ? Seller.Shop.Level6(i) : 0);
                    plew.WriteByte(i < Seller.Shop.Count ? Seller.Shop.Level7(i) : 0);
                    plew.WriteByte(i < Seller.Shop.Count ? Seller.Shop.Level8(i) : 0);
                    plew.WriteByte(i < Seller.Shop.Count ? Seller.Shop.Level9(i) : 0);
                    plew.WriteByte(i < Seller.Shop.Count ? Seller.Shop.Level10(i) : 0);
                    plew.WriteByte(i < Seller.Shop.Count ? Seller.Shop.Fusion(i) : 0);
                    plew.WriteByte(i < Seller.Shop.Count ? Seller.Shop.IsLocked(i) : 0);
                    plew.WriteInt(i < Seller.Shop.Count ? Seller.Shop.Price(i) : 0);
                    plew.WriteByte(0); // 力量+
                    plew.WriteByte(0); // 氣力+
                    plew.WriteByte(0); // 精力+
                    plew.WriteByte(0); // 智力+
                    plew.WriteByte(0);
                    plew.WriteByte(0);
                    plew.WriteByte(0); // 防禦力+
                    plew.WriteByte(0); // 物理攻擊力+
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