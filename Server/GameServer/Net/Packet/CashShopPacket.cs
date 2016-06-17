using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Ghost.Provider;
using Server.Net;

namespace Server.Packet
{
    public static class CashShopPacket
    {
        public static void BuyCommodity(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.CASH_BUY_ACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(1); // 購買成功 
                c.Send(plew);
            }
        }

        public static void CommodityToInventory(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.CASH_TO_INVEN_ACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(1); // 已發送至行囊
                c.Send(plew);
            }
        }

        public static void GuiHonCash(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.CASH_GUIHONCASH))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(c.Account.BonusPoints); // 搞鬼紅利積點
                c.Send(plew);
            }
        }

        public static void MgameCash(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.CASH_MGAMECASH_ACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(c.Account.GamePoints); // 搞鬼點數
                plew.WriteInt(c.Account.GiftPoints); // 禮物點數
                c.Send(plew);
            }
        }

        public static void CashShopList1(Client c)
        {
            // 人物
            using (OutPacket plew = new OutPacket(ServerOpcode.CASHSHOPLIST1_ACK))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                // 眼睛(男)
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i < CashShopFactory.BoyEyes.Count ? CashShopFactory.BoyEyes[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.BoyEyes.Count ? CashShopFactory.BoyEyes[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.BoyEyes.Count ? CashShopFactory.BoyEyes[i].Term : 0); // 期限
                    plew.WriteInt(i < CashShopFactory.BoyEyes.Count ? CashShopFactory.BoyEyes[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.BoyEyes.Count ? CashShopFactory.BoyEyes[i].Flag : 0);
                    plew.WriteInt(0);
                }
                // 眼睛(女)
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i < CashShopFactory.GirlEyes.Count ? CashShopFactory.GirlEyes[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.GirlEyes.Count ? CashShopFactory.GirlEyes[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.GirlEyes.Count ? CashShopFactory.GirlEyes[i].Term : 0); // 期限
                    plew.WriteInt(i < CashShopFactory.GirlEyes.Count ? CashShopFactory.GirlEyes[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.GirlEyes.Count ? CashShopFactory.GirlEyes[i].Flag : 0);
                    plew.WriteInt(0);
                }
                // 髮型(男)
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i < CashShopFactory.BoyHair.Count ? CashShopFactory.BoyHair[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.BoyHair.Count ? CashShopFactory.BoyHair[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.BoyHair.Count ? CashShopFactory.BoyHair[i].Term : 0); // 期限
                    plew.WriteInt(i < CashShopFactory.BoyHair.Count ? CashShopFactory.BoyHair[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.BoyHair.Count ? CashShopFactory.BoyHair[i].Flag : 0);
                    plew.WriteInt(0);
                }
                // 髮型(女)
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i < CashShopFactory.GirlHair.Count ? CashShopFactory.GirlHair[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.GirlHair.Count ? CashShopFactory.GirlHair[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.GirlHair.Count ? CashShopFactory.GirlHair[i].Term : 0); // 期限
                    plew.WriteInt(i < CashShopFactory.GirlHair.Count ? CashShopFactory.GirlHair[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.GirlHair.Count ? CashShopFactory.GirlHair[i].Flag : 0);
                    plew.WriteInt(0);
                }
                // 臉部(上)
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i < CashShopFactory.Face1.Count ? CashShopFactory.Face1[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.Face1.Count ? CashShopFactory.Face1[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.Face1.Count ? CashShopFactory.Face1[i].Term : 0); // 期限
                    plew.WriteInt(i < CashShopFactory.Face1.Count ? CashShopFactory.Face1[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.Face1.Count ? CashShopFactory.Face1[i].Flag : 0);
                    plew.WriteInt(0);
                }
                // 臉部(下)
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i < CashShopFactory.Face2.Count ? CashShopFactory.Face2[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.Face2.Count ? CashShopFactory.Face2[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.Face2.Count ? CashShopFactory.Face2[i].Term : 0); // 期限
                    plew.WriteInt(i < CashShopFactory.Face2.Count ? CashShopFactory.Face2[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.Face2.Count ? CashShopFactory.Face2[i].Flag : 0);
                    plew.WriteInt(0);
                }
                // 帽子
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i < CashShopFactory.Hat.Count ? CashShopFactory.Hat[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.Hat.Count ? CashShopFactory.Hat[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.Hat.Count ? CashShopFactory.Hat[i].Term : 0); // 期限
                    plew.WriteInt(i < CashShopFactory.Hat.Count ? CashShopFactory.Hat[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.Hat.Count ? CashShopFactory.Hat[i].Flag : 0);
                    plew.WriteInt(0);
                }
                c.Send(plew);
            }
        }

        public static void CashShopList2(Client c)
        {
            // 裝備
            using (OutPacket plew = new OutPacket(ServerOpcode.CASHSHOPLIST2_ACK))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                // 服裝(男)
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i < CashShopFactory.BoyDress.Count ? CashShopFactory.BoyDress[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.BoyDress.Count ? CashShopFactory.BoyDress[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.BoyDress.Count ? CashShopFactory.BoyDress[i].Term : 0); // 期限
                    plew.WriteInt(i < CashShopFactory.BoyDress.Count ? CashShopFactory.BoyDress[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.BoyDress.Count ? CashShopFactory.BoyDress[i].Flag : 0);
                    plew.WriteInt(0);
                }
                // 服裝(女)
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i < CashShopFactory.GirlDress.Count ? CashShopFactory.GirlDress[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.GirlDress.Count ? CashShopFactory.GirlDress[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.GirlDress.Count ? CashShopFactory.GirlDress[i].Term : 0); // 期限
                    plew.WriteInt(i < CashShopFactory.GirlDress.Count ? CashShopFactory.GirlDress[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.GirlDress.Count ? CashShopFactory.GirlDress[i].Flag : 0);
                    plew.WriteInt(0);
                }
                // 披風
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i < CashShopFactory.Mantle.Count ? CashShopFactory.Mantle[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.Mantle.Count ? CashShopFactory.Mantle[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.Mantle.Count ? CashShopFactory.Mantle[i].Term : -1); // 期限
                    plew.WriteInt(i < CashShopFactory.Mantle.Count ? CashShopFactory.Mantle[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.Mantle.Count ? CashShopFactory.Mantle[i].Flag : 0);
                    plew.WriteInt(0);
                }
                // 福袋
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(0); // 售價
                    plew.WriteInt(-1); // 期限
                    plew.WriteInt(0); // 原價
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                }
                // 生產
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(0); // 售價
                    plew.WriteInt(-1); // 期限
                    plew.WriteInt(0); // 原價
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                }
                c.Send(plew);
            }
        }

        public static void CashShopList3(Client c)
        {
            // 能力
            using (OutPacket plew = new OutPacket(ServerOpcode.CASHSHOPLIST3_ACK))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                // 符咒
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i == 0 ? 8843030 : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i == 0 ? 100 : 0); // 售價
                    plew.WriteInt(-1); // 期限
                    plew.WriteInt(i == 0 ? 100 : 0); // 原價
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                }
                // 靈丹
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i == 0 ? 8843001 : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i == 0 ? 100 : 0); // 售價
                    plew.WriteInt(-1); // 期限
                    plew.WriteInt(i == 0 ? 100 : 0); // 原價
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                }
                // 法寶
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(0); // 售價
                    plew.WriteInt(-1); // 期限
                    plew.WriteInt(0); // 原價
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                }
                c.Send(plew);
            }
        }

        public static void CashShopList4(Client c)
        {
            // 靈物
            using (OutPacket plew = new OutPacket(ServerOpcode.CASHSHOPLIST4_ACK))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                // 靈物
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i == 0 ? 9212011 : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i == 0 ? 300 : 0); // 售價
                    plew.WriteInt(-1); // 期限
                    plew.WriteInt(i == 0 ? 300 : 0); // 原價
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                }
                // 靈物裝備
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i == 0 ? 9220011 : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i == 0 ? 100 : 0); // 售價
                    plew.WriteInt(-1); // 期限
                    plew.WriteInt(i == 0 ? 100 : 0); // 原價
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                }
                // 靈物消耗
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(0); // 售價
                    plew.WriteInt(-1); // 期限
                    plew.WriteInt(0); // 原價
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                }
                // 守護靈
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(0); // 售價
                    plew.WriteInt(-1); // 期限
                    plew.WriteInt(0); // 原價
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                }
                c.Send(plew);
            }
        }

        public static void CashShopList5(Client c)
        {
            // 寶牌
            using (OutPacket plew = new OutPacket(ServerOpcode.CASHSHOPLIST5_ACK))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                // 寶牌
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(0); // 售價
                    plew.WriteInt(-1); // 期限
                    plew.WriteInt(0); // 原價
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                }
                c.Send(plew);
            }
        }

        public static void CashShopList6(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.CASHSHOPLIST6_ACK))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                // 
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(0); // 售價
                    plew.WriteInt(-1); // 期限
                    plew.WriteInt(0); // 原價
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                }
                // 
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(0); // 售價
                    plew.WriteInt(-1); // 期限
                    plew.WriteInt(0); // 原價
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                }
                // 
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(0); // 售價
                    plew.WriteInt(-1); // 期限
                    plew.WriteInt(0); // 原價
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                }
                c.Send(plew);
            }
        }

        public static void CashShopList7(Client c)
        {
            // 紅利積點
            using (OutPacket plew = new OutPacket(ServerOpcode.CASHSHOPLIST7_ACK))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(0); // 售價
                    plew.WriteInt(-1); // 期限
                    plew.WriteInt(0); // 原價
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                }
                // 
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(0); // 售價
                    plew.WriteInt(-1); // 期限
                    plew.WriteInt(0); // 原價
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                }
                c.Send(plew);
            }
        }

        public static void CashShopList8(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.CASHSHOPLIST8_ACK))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                // 
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(0); // 售價
                    plew.WriteInt(-1); // 期限
                    plew.WriteInt(0); // 原價
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                }
                // 
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(0); // 售價
                    plew.WriteInt(-1); // 期限
                    plew.WriteInt(0); // 原價
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                }
                // 
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(0); // 售價
                    plew.WriteInt(-1); // 期限
                    plew.WriteInt(0); // 原價
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                }
                c.Send(plew);
            }
        }

        public static void CashShopList9(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.CASHSHOPLIST9_ACK))
            {
                var chr = c.Character;
                // 
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(0); // 售價
                    plew.WriteInt(-1); // 期限
                    plew.WriteInt(0); // 原價
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                }
                c.Send(plew);
            }
        }
    }
}
