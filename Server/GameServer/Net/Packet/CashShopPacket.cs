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

        public static void Gifts(Client c, int Type)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.CASH_GIFT_ACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(Type);
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

        public static void CheckName(Client c, int Type)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.CASH_CHECKCHARNAME_ACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(Type);
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
                    plew.WriteInt(i < CashShopFactory.BoyEyesList.Count ? CashShopFactory.BoyEyesList[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.BoyEyesList.Count ? CashShopFactory.BoyEyesList[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.BoyEyesList.Count ? CashShopFactory.BoyEyesList[i].Term : 0); // 期限
                    plew.WriteInt(i < CashShopFactory.BoyEyesList.Count ? CashShopFactory.BoyEyesList[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.BoyEyesList.Count ? CashShopFactory.BoyEyesList[i].Flag : 0);
                    plew.WriteInt(0);
                }
                // 眼睛(女)
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i < CashShopFactory.GirlEyesList.Count ? CashShopFactory.GirlEyesList[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.GirlEyesList.Count ? CashShopFactory.GirlEyesList[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.GirlEyesList.Count ? CashShopFactory.GirlEyesList[i].Term : 0); // 期限
                    plew.WriteInt(i < CashShopFactory.GirlEyesList.Count ? CashShopFactory.GirlEyesList[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.GirlEyesList.Count ? CashShopFactory.GirlEyesList[i].Flag : 0);
                    plew.WriteInt(0);
                }
                // 髮型(男)
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i < CashShopFactory.BoyHairList.Count ? CashShopFactory.BoyHairList[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.BoyHairList.Count ? CashShopFactory.BoyHairList[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.BoyHairList.Count ? CashShopFactory.BoyHairList[i].Term : 0); // 期限
                    plew.WriteInt(i < CashShopFactory.BoyHairList.Count ? CashShopFactory.BoyHairList[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.BoyHairList.Count ? CashShopFactory.BoyHairList[i].Flag : 0);
                    plew.WriteInt(0);
                }
                // 髮型(女)
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i < CashShopFactory.GirlHairList.Count ? CashShopFactory.GirlHairList[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.GirlHairList.Count ? CashShopFactory.GirlHairList[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.GirlHairList.Count ? CashShopFactory.GirlHairList[i].Term : 0); // 期限
                    plew.WriteInt(i < CashShopFactory.GirlHairList.Count ? CashShopFactory.GirlHairList[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.GirlHairList.Count ? CashShopFactory.GirlHairList[i].Flag : 0);
                    plew.WriteInt(0);
                }
                // 臉部(上)
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i < CashShopFactory.Face1List.Count ? CashShopFactory.Face1List[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.Face1List.Count ? CashShopFactory.Face1List[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.Face1List.Count ? CashShopFactory.Face1List[i].Term : 0); // 期限
                    plew.WriteInt(i < CashShopFactory.Face1List.Count ? CashShopFactory.Face1List[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.Face1List.Count ? CashShopFactory.Face1List[i].Flag : 0);
                    plew.WriteInt(0);
                }
                // 臉部(下)
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i < CashShopFactory.Face2List.Count ? CashShopFactory.Face2List[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.Face2List.Count ? CashShopFactory.Face2List[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.Face2List.Count ? CashShopFactory.Face2List[i].Term : 0); // 期限
                    plew.WriteInt(i < CashShopFactory.Face2List.Count ? CashShopFactory.Face2List[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.Face2List.Count ? CashShopFactory.Face2List[i].Flag : 0);
                    plew.WriteInt(0);
                }
                // 帽子
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i < CashShopFactory.HatList.Count ? CashShopFactory.HatList[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.HatList.Count ? CashShopFactory.HatList[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.HatList.Count ? CashShopFactory.HatList[i].Term : 0); // 期限
                    plew.WriteInt(i < CashShopFactory.HatList.Count ? CashShopFactory.HatList[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.HatList.Count ? CashShopFactory.HatList[i].Flag : 0);
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
                    plew.WriteInt(i < CashShopFactory.BoyDressList.Count ? CashShopFactory.BoyDressList[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.BoyDressList.Count ? CashShopFactory.BoyDressList[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.BoyDressList.Count ? CashShopFactory.BoyDressList[i].Term : 0); // 期限
                    plew.WriteInt(i < CashShopFactory.BoyDressList.Count ? CashShopFactory.BoyDressList[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.BoyDressList.Count ? CashShopFactory.BoyDressList[i].Flag : 0);
                    plew.WriteInt(0);
                }
                // 服裝(女)
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i < CashShopFactory.GirlDressList.Count ? CashShopFactory.GirlDressList[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.GirlDressList.Count ? CashShopFactory.GirlDressList[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.GirlDressList.Count ? CashShopFactory.GirlDressList[i].Term : 0); // 期限
                    plew.WriteInt(i < CashShopFactory.GirlDressList.Count ? CashShopFactory.GirlDressList[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.GirlDressList.Count ? CashShopFactory.GirlDressList[i].Flag : 0);
                    plew.WriteInt(0);
                }
                // 披風
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i < CashShopFactory.MantleList.Count ? CashShopFactory.MantleList[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.MantleList.Count ? CashShopFactory.MantleList[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.MantleList.Count ? CashShopFactory.MantleList[i].Term : -1); // 期限
                    plew.WriteInt(i < CashShopFactory.MantleList.Count ? CashShopFactory.MantleList[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.MantleList.Count ? CashShopFactory.MantleList[i].Flag : 0);
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
                    plew.WriteInt(i < CashShopFactory.ProduceList.Count ? CashShopFactory.ProduceList[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.ProduceList.Count ? CashShopFactory.ProduceList[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.ProduceList.Count ? CashShopFactory.ProduceList[i].Term : -1); // 期限
                    plew.WriteInt(i < CashShopFactory.ProduceList.Count ? CashShopFactory.ProduceList[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.ProduceList.Count ? CashShopFactory.ProduceList[i].Flag : 0);
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
                    plew.WriteInt(i < CashShopFactory.AmuletList.Count ? CashShopFactory.AmuletList[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.AmuletList.Count ? CashShopFactory.AmuletList[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.AmuletList.Count ? CashShopFactory.AmuletList[i].Term : 0); // 期限
                    plew.WriteInt(i < CashShopFactory.AmuletList.Count ? CashShopFactory.AmuletList[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.AmuletList.Count ? CashShopFactory.AmuletList[i].Flag : 0);
                    plew.WriteInt(0);
                }
                // 靈丹
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
                // 法寶
                for (int i = 0; i < 300; i++)
                {
                    plew.WriteInt(i < CashShopFactory.TalismanList.Count ? CashShopFactory.TalismanList[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.TalismanList.Count ? CashShopFactory.TalismanList[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.TalismanList.Count ? CashShopFactory.TalismanList[i].Term : 0); // 期限
                    plew.WriteInt(i < CashShopFactory.TalismanList.Count ? CashShopFactory.TalismanList[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.TalismanList.Count ? CashShopFactory.TalismanList[i].Flag : 0);
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
                    plew.WriteInt(i < CashShopFactory.PetList.Count ? CashShopFactory.PetList[i].ItemID : 0); // 物品ID
                    plew.WriteInt(1);
                    plew.WriteInt(i < CashShopFactory.PetList.Count ? CashShopFactory.PetList[i].BargainPrice : 0); // 售價
                    plew.WriteInt(i < CashShopFactory.PetList.Count ? CashShopFactory.PetList[i].Term : 0); // 期限
                    plew.WriteInt(i < CashShopFactory.PetList.Count ? CashShopFactory.PetList[i].Price : 0); // 原價
                    plew.WriteInt(i < CashShopFactory.PetList.Count ? CashShopFactory.PetList[i].Flag : 0);
                    plew.WriteInt(0);
                }
                // 靈物裝備
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
