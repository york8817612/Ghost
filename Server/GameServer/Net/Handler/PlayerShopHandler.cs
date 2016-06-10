using Server.Common.IO.Packet;
using Server.Ghost.Characters;
using Server.Net;
using Server.Net.Packet;

namespace Server.Handler
{
    public static class PlayerShopHandler
    {
        public static void OpenShop_Req(InPacket lea, Client c)
        {
            int slots = 6;
            PlayerShopPacket.OpenShop(c, slots);
        }

        public static void SellStart_Req(InPacket lea, Client c)
        {
            string Name = lea.ReadString(40);
            var chr = c.Character;
            CharacterShop PlayerShop = new CharacterShop(Name);
            for (int i = 0; i < 12; i++)
            {
                int Type = lea.ReadShort();
                int Slot = lea.ReadShort();
                int Quantity = lea.ReadInt();
                int Price = lea.ReadInt();
                PlayerShop.Add(new ShopData(Type, Slot, Quantity, Price));
            }
            chr.Shop = PlayerShop;
            PlayerShopPacket.SellStart(c, Name);
        }

        public static void SellEnd_Req(InPacket lea, Client c)
        {
            PlayerShopPacket.SellEnd(c);
        }

        public static void SellInfo_Req(InPacket lea, Client c)
        {
            PlayerShopPacket.SellInfo(c);
        }

        public static void Buy_Req(InPacket lea, Client c)
        {
            PlayerShopPacket.Buy(c, 1);
        }
    }
}