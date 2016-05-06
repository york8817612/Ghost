using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Ghost;
using System;
using System.Collections.Generic;

namespace Server.Ghost
{
    public static class GamePacket
    {
        public static void Game_Log_Ack(Client c, int characterID)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.GAMELOG))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(characterID);
                plew.WriteInt(ServerConstants.CLIENT_VERSION);
                plew.WriteInt(15199);
                plew.WriteInt(12615854); // TimeLogin
                plew.WriteBytes(new byte[] { 127, 0, 0, 1 });
                plew.WriteLong(c.SessionID); // Key

                c.Send(plew);
            }
        }

        public static void getNotice(Client c, byte type, string message)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.NOTICE))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteByte(type);
                plew.WriteString(message, 76);

                c.Send(plew);
            }
        }

        public static void FW_DISCOUNTFACTION(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.FW_DISCOUNTFACTION))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteHexString("00 00 00 00 64 00 00 00 00 00 00 00 64 00 00 00 00 70 40 00 E8 03 D2 A8 74 A9 00 00 84 D1");

                c.Send(plew);
            }
        }
    }

    public static class MapPacket
    {
        public static void enterMapStart(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.ENTER_MAP_START))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteShort(chr.MapX);
                plew.WriteShort(chr.MapY);
                plew.WriteShort(chr.PlayerX);
                plew.WriteShort(chr.PlayerY);

                plew.WriteShort(chr.MapX);
                plew.WriteShort(chr.MapY);
                plew.WriteShort(chr.PlayerX);
                plew.WriteShort(chr.PlayerY);

                c.Send(plew);
            }
        }

        public static void warpToMap(Client c, int playerId, short mapX, short mapY, short playerX, short playerY)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.ENTER_WARP_ACK))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(playerId); // 角色編號
                plew.WriteString(chr.Name, 20);
                plew.WriteString(chr.Title, 20);
                plew.WriteShort(mapX);
                plew.WriteShort(mapY);
                plew.WriteShort(playerX);
                plew.WriteShort(playerY);
                plew.WriteByte(chr.Gender);
                plew.WriteByte(chr.Level);
                plew.WriteByte(chr.Class);
                plew.WriteByte(chr.ClassLevel);
                plew.WriteByte(0xFF);
                plew.WriteByte(0);
                plew.WriteByte(0); // 變身效果
                plew.WriteByte(0);
                plew.WriteByte(0);
                plew.WriteByte(0);
                plew.WriteByte(0);
                plew.WriteByte(0);
                plew.WriteInt(chr.Hair);                                                                              // 頭髮
                plew.WriteInt(chr.Inventory[0].getItem(9) != null ? c.Character.Inventory[0].getItem(9).ItemID : 0);  // 臉上
                plew.WriteInt(chr.Inventory[0].getItem(12) != null ? c.Character.Inventory[0].getItem(12).ItemID : 0);// 臉下
                plew.WriteInt(chr.Inventory[0].getItem(6) != null ? c.Character.Inventory[0].getItem(6).ItemID : 0);  // 帽子
                plew.WriteInt(chr.Eyes);                                                                              // 眼睛
                plew.WriteInt(chr.Inventory[0].getItem(1) != null ? c.Character.Inventory[0].getItem(1).ItemID : 0);  // 衣服
                plew.WriteInt(chr.Inventory[0].getItem(11) != null ? c.Character.Inventory[0].getItem(11).ItemID : 0);// 服裝
                plew.WriteInt(chr.Inventory[0].getItem(0) != null ? c.Character.Inventory[0].getItem(0).ItemID : 0);  // 武器
                plew.WriteInt(chr.Inventory[0].getItem(4) != null ? c.Character.Inventory[0].getItem(4).ItemID : 0);  // 披風
                plew.WriteInt(chr.Inventory[0].getItem(10) != null ? c.Character.Inventory[0].getItem(10).ItemID : 0);// 靈物
                plew.WriteInt(chr.Inventory[0].getItem(14) != null ? c.Character.Inventory[0].getItem(14).ItemID : 0);// HairAcc
                plew.WriteInt(chr.Inventory[0].getItem(15) != null ? c.Character.Inventory[0].getItem(15).ItemID : 0);// 玩物
                // 寵物
                plew.WriteString("", 20); // 寵物名稱
                plew.WriteByte(0); // 寵物等級
                plew.WriteHexString("00 00 00");
                plew.WriteInt(0); // 寵物血量
                plew.WriteInt(0);
                plew.WriteInt(0);
                plew.WriteInt(0);
                plew.WriteInt(0);
                // 玩物
                plew.WriteString("", 20); // 玩物名稱
                plew.WriteByte(0); // 玩物等級
                plew.WriteHexString("FF FF FF");
                plew.WriteInt(0);
                plew.WriteInt(0);
                plew.WriteInt(0);
                //

                c.Send(plew);
            }
        }

        public static void warpToMapAuth(Client c, Boolean isAvailableMap, short mapX, short mapY, short positionX, short positionY)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.CAN_WARP_ACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(isAvailableMap ? 1 : 0);
                plew.WriteShort(mapX);
                plew.WriteShort(mapY);
                plew.WriteShort(positionX);
                plew.WriteShort(positionY);

                plew.WriteShort(mapX);
                plew.WriteShort(mapY);
                plew.WriteShort(positionX);
                plew.WriteShort(positionY);

                c.Send(plew);
            }
        }

        public static void InvenUseSpendShout(Client c, string message)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_USESPEND_SHOUT_ACK))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteByte(1); // 頻道
                plew.WriteString(chr.Name, 20);
                plew.WriteString(message, 65);
                plew.WriteShort(1); // 類型
                c.Send(plew);
            }
        }
    }

    public static class InventoryPacket
    {
        public static void getCharacterEquip(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_ALL))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(chr.Inventory[0].getItem(0) != null ? c.Character.Inventory[0].getItem(0).ItemID : 0);  // 武器[Weapon] 8010101
                plew.WriteInt(chr.Inventory[0].getItem(1) != null ? c.Character.Inventory[0].getItem(1).ItemID : 0);  // 衣服[Outfit] 8160351
                plew.WriteInt(chr.Inventory[0].getItem(2) != null ? c.Character.Inventory[0].getItem(2).ItemID : 0);  // 戒指[Ring]
                plew.WriteInt(chr.Inventory[0].getItem(3) != null ? c.Character.Inventory[0].getItem(3).ItemID : 0);  // 項鍊[Necklace]
                plew.WriteInt(chr.Inventory[0].getItem(4) != null ? c.Character.Inventory[0].getItem(4).ItemID : 0);  // 披風[Mantle]
                plew.WriteInt(chr.Inventory[0].getItem(5) != null ? c.Character.Inventory[0].getItem(5).ItemID : 0);  // 封印物[Seal]
                plew.WriteInt(chr.Inventory[0].getItem(6) != null ? c.Character.Inventory[0].getItem(6).ItemID : 0);  // 頭部[Hat]
                plew.WriteInt(chr.Hair);                                                                              // 頭髮[Hair]
                plew.WriteInt(chr.Eyes);                                                                              // 眼睛[Eyes]
                plew.WriteInt(chr.Inventory[0].getItem(9) != null ? c.Character.Inventory[0].getItem(9).ItemID : 0);  // 臉上[Face]
                plew.WriteInt(chr.Inventory[0].getItem(10) != null ? c.Character.Inventory[0].getItem(10).ItemID : 0);// 靈物[Pet]
                plew.WriteInt(chr.Inventory[0].getItem(11) != null ? c.Character.Inventory[0].getItem(11).ItemID : 0);// 服裝[Dress]
                plew.WriteInt(chr.Inventory[0].getItem(12) != null ? c.Character.Inventory[0].getItem(12).ItemID : 0);// 臉下[Face2]
                plew.WriteInt(chr.Inventory[0].getItem(13) != null ? c.Character.Inventory[0].getItem(13).ItemID : 0);// 耳環[Earing]
                plew.WriteInt(chr.Inventory[0].getItem(14) != null ? c.Character.Inventory[0].getItem(14).ItemID : 0);// [HairAcc] 
                plew.WriteInt(chr.Inventory[0].getItem(15) != null ? c.Character.Inventory[0].getItem(15).ItemID : 0);// 玩物[Toy]
                plew.WriteHexString("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 2B 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");

                c.Send(plew);
            }
        }

        public static void getInvenEquip(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_EQUIP))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(chr.Inventory[0].getItem(0) != null ? c.Character.Inventory[0].getItem(0).ItemID : 0);  // 武器[Weapon] 8010101
                plew.WriteInt(chr.Inventory[0].getItem(1) != null ? c.Character.Inventory[0].getItem(1).ItemID : 0);  // 衣服[Outfit] 8160351
                plew.WriteInt(chr.Inventory[0].getItem(2) != null ? c.Character.Inventory[0].getItem(2).ItemID : 0);  // 戒指[Ring]
                plew.WriteInt(chr.Inventory[0].getItem(3) != null ? c.Character.Inventory[0].getItem(3).ItemID : 0);  // 項鍊[Necklace]
                plew.WriteInt(chr.Inventory[0].getItem(4) != null ? c.Character.Inventory[0].getItem(4).ItemID : 0);  // 披風[Mantle]
                plew.WriteInt(chr.Inventory[0].getItem(5) != null ? c.Character.Inventory[0].getItem(5).ItemID : 0);  // 封印物[Seal]
                plew.WriteInt(chr.Inventory[0].getItem(6) != null ? c.Character.Inventory[0].getItem(6).ItemID : 0);  // 頭部[Hat]
                plew.WriteInt(chr.Hair);                                                                              // 頭髮[Hair]
                plew.WriteInt(chr.Eyes);                                                                              // 眼睛[Eyes]
                plew.WriteInt(chr.Inventory[0].getItem(9) != null ? c.Character.Inventory[0].getItem(9).ItemID : 0);  // 臉上[Face]
                plew.WriteInt(chr.Inventory[0].getItem(10) != null ? c.Character.Inventory[0].getItem(10).ItemID : 0);// 靈物[Pet]
                plew.WriteInt(chr.Inventory[0].getItem(11) != null ? c.Character.Inventory[0].getItem(11).ItemID : 0);// 服裝[Dress]
                plew.WriteInt(chr.Inventory[0].getItem(12) != null ? c.Character.Inventory[0].getItem(12).ItemID : 0);// 臉下[Face2]
                plew.WriteInt(chr.Inventory[0].getItem(13) != null ? c.Character.Inventory[0].getItem(13).ItemID : 0);// 耳環[Earing]
                plew.WriteInt(chr.Inventory[0].getItem(14) != null ? c.Character.Inventory[0].getItem(14).ItemID : 0);// [HairAcc] 
                plew.WriteInt(chr.Inventory[0].getItem(15) != null ? c.Character.Inventory[0].getItem(15).ItemID : 0);// 玩物[Toy]
                plew.WriteInt(0); // 16
                plew.WriteInt(0); // 17

                for (int i = 0; i < 17; i++)
                {
                    plew.WriteByte(0);
                }

                for (int i = 0; i < 17; i++)
                {
                    plew.WriteHexString("00 00 00 00 00 00 00 00 00 00");
                }

                plew.WriteByte(0);

                for (int i = 0; i < 17; i++)
                {
                    plew.WriteShort(0);
                }

                for (int i = 0; i < 17; i++)
                {
                    plew.WriteShort(0);
                }

                for (int i = 0; i < 17; i++)
                {
                    plew.WriteHexString("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");
                }

                // 寵物
                plew.WriteString("", 20); // 寵物名稱
                plew.WriteByte(0); // 寵物等級
                plew.WriteByte(0);
                plew.WriteInt(0); // 寵物血量
                plew.WriteInt(0);
                plew.WriteInt(0);
                plew.WriteInt(-1);
                plew.WriteInt(-1);
                plew.WriteInt(-1); // 寵物截止日期
                plew.WriteByte(0);

                // 玩物
                plew.WriteString("", 20); // 玩物名稱
                plew.WriteByte(0);
                plew.WriteShort(0);
                plew.WriteInt(0);
                plew.WriteInt(0); // 玩物血量
                plew.WriteInt(0);

                plew.WriteInt(-1); // 玩物[Toy]截止日期
                plew.WriteInt(-1); // 武器[Weapon]截止日期
                plew.WriteInt(-1); // 衣服[Outfit]截止日期
                plew.WriteInt(-1); // 頭部[Hat]截止日期
                plew.WriteInt(-1); // 未知[]截止日期

                for (int i = 0; i < 17; i++)
                {
                    plew.WriteInt(0);
                }

                for (int i = 0; i < 17; i++)
                {
                    plew.WriteInt(0);
                }

                c.Send(plew);
            }
        }

        public static void getInvenEquip1(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_EQUIP1))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                for (byte i = 0; i < 24; i++)
                { // 物品編號
                    plew.WriteInt(chr.Inventory[1].getItem(i) != null ? c.Character.Inventory[1].getItem(i).ItemID : 0);
                }
                for (int i = 0; i < 24; i++)
                { // 
                    plew.WriteByte(0);
                }
                for (int i = 0; i < 24; i++)
                { // 
                    plew.WriteHexString("00 00 00 00 00 00 00 00 00 00");
                }
                for (int i = 0; i < 24; i++)
                { // 
                    plew.WriteShort(0);
                }
                for (int i = 0; i < 24; i++)
                { // 物品Lock
                    plew.WriteByte(0);
                }
                for (int i = 0; i < 24; i++)
                { // 截止日期
                    plew.WriteInt(-1);
                }
                for (int i = 0; i < 24; i++)
                { // 物品標誌
                    plew.WriteShort(0);
                }
                for (int i = 0; i < 24; i++)
                { // 960 Bytes
                    plew.WriteHexString("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");
                }
                c.Send(plew);
            }
        }

        public static void getInvenEquip2(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_EQUIP2))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                for (byte i = 0; i < 24; i++)
                { // 物品編號
                    plew.WriteInt(chr.Inventory[2].getItem(i) != null ? c.Character.Inventory[2].getItem(i).ItemID : 0);
                }
                for (int i = 0; i < 24; i++)
                { // 
                    plew.WriteByte(0);
                }
                for (int i = 0; i < 24; i++)
                { // 
                    plew.WriteHexString("00 00 00 00 00 00 00 00 00 00");
                }
                for (int i = 0; i < 24; i++)
                { // 封印物量
                    plew.WriteShort(0);
                }
                for (int i = 0; i < 24; i++)
                { // 物品Lock
                    plew.WriteByte(0);
                }
                for (int i = 0; i < 24; i++)
                { // 物品標誌
                    plew.WriteShort(0);
                }
                for (int i = 0; i < 24; i++)
                { // 截止日期
                    plew.WriteInt(-1);
                }
                c.Send(plew);
            }
        }

        public static void getInvenSpend3(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_SPEND3))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                for (byte i = 0; i < 24; i++)
                { // 物品編號
                    plew.WriteInt(chr.Inventory[3].getItem(i) != null ? c.Character.Inventory[3].getItem(i).ItemID : 0);
                }
                for (byte i = 0; i < 24; i++)
                { // 物品數量
                    plew.WriteInt(chr.Inventory[3].getItem(i) != null ? c.Character.Inventory[3].getItem(i).Quantity : 0);
                }
                for (short i = 1; i <= 24; i++)
                { // 物品Lock
                    plew.WriteByte(0);
                }
                for (int i = 0; i < 24; i++)
                { // 截止日期
                    plew.WriteInt(-1);
                }
                plew.WriteHexString("03 FF FF FF");
                c.Send(plew);
            }
        }

        public static void getInvenOther4(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_OTHER4))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                for (byte i = 0; i < 24; i++)
                { // 物品編號
                    plew.WriteInt(chr.Inventory[4].getItem(i) != null ? c.Character.Inventory[4].getItem(i).ItemID : 0);
                }
                for (byte i = 0; i < 24; i++)
                { // 物品數量
                    plew.WriteInt(chr.Inventory[4].getItem(i) != null ? c.Character.Inventory[4].getItem(i).Quantity : 0);
                }
                for (int i = 0; i < 24; i++)
                { // 物品Lock
                    plew.WriteByte(0);
                }
                for (int i = 0; i < 24; i++)
                { // 截止日期
                    plew.WriteInt(-1);
                }
                c.Send(plew);
            }
        }

        public static void getInvenPet5(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_PET5))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                for (int i = 0; i < 24; i++)
                { // 寵物編號
                    plew.WriteInt(0);
                }
                for (int i = 0; i < 24; i++)
                { // 寵物名稱
                    plew.WriteString("", 20);
                }
                for (int i = 0; i < 24; i++)
                { // 寵物等級
                    plew.WriteByte(0);
                }
                for (int i = 0; i < 24; i++)
                { // 寵物血量
                    plew.WriteInt(0);
                }
                for (int i = 0; i < 24; i++)
                { // 寵物經驗值
                    plew.WriteInt(0);
                }
                for (int i = 0; i < 24; i++)
                { // 
                    plew.WriteInt(0);
                }
                for (int i = 0; i < 24; i++)
                { // 截止日期
                    plew.WriteInt(-1);
                }
                for (int i = 0; i < 24; i++)
                { // 
                    plew.WriteShort(0);
                }
                for (int i = 0; i < 24; i++)
                { // 
                    plew.WriteInt(0);
                }
                for (int i = 0; i < 24; i++)
                { // 物品Lock
                    plew.WriteByte(0);
                }
                for (int i = 0; i < 24; i++)
                { // 
                    plew.WriteInt(-1);
                }
                for (int i = 0; i < 24; i++)
                { // 物品Icon
                    plew.WriteShort(0);
                }

                c.Send(plew);
            }
        }

        public static void getInvenCash(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_CASH))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteHexString("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 01 18 08 00 00 00 00 00 01 18 08 00 70 40 00 E8 03 D2 A8 74 A9 00 00 70 19");

                c.Send(plew);
            }
        }

        public static void getInvenMoney(Client c, int money, int pickup)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_MONEY))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteLong(money);
                plew.WriteLong(pickup);

                c.Send(plew);
            }
        }

        public static void getStoreInfo(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.STORE_INFO))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteHexString("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 08 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 19 D6 DA 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 DA 00 00 00 F5 00 00 D6 DA 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 F5 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 1A D6 DA 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 08 00 00 00 08 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 3F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 1B D6 DA 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 FF 00 00 FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 FF FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 64 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");

                c.Send(plew);
            }
        }

        public static void getStoreMoney(Client c, int money)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.STORE_MONEYINFO))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(money);
                plew.WriteInt(0);

                c.Send(plew);
            }
        }
    }

    public static class StatusPacket
    {
        public static void getStatusInfo(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.CHAR_ALL))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteString(chr.Name, 20);
                plew.WriteString(chr.Title, 20);
                plew.WriteByte(chr.Gender);
                plew.WriteByte(chr.Level);
                plew.WriteByte(chr.Class);
                plew.WriteByte(chr.ClassLevel);
                plew.WriteByte(0);
                plew.WriteByte(0xFF);
                plew.WriteShort(chr.MaxHp);
                plew.WriteShort(chr.Hp);
                plew.WriteShort(chr.MaxMp);
                plew.WriteShort(chr.Mp);
                plew.WriteInt(GameConstants.getExpNeededForLevel(chr.Level));
                plew.WriteInt(0);
                plew.WriteInt(chr.Exp);
                plew.WriteInt(0);
                plew.WriteShort(0);
                plew.WriteShort(chr.Fame);
                plew.WriteShort(chr.MaxFury); // 憤怒值(Max)
                plew.WriteShort(chr.Fury);    // 憤怒值
                plew.WriteByte(3);
                plew.WriteByte(chr.JumpHeight); // 跳躍高度
                plew.WriteShort(chr.Str); // 力量
                plew.WriteShort(chr.Dex); // 精力
                plew.WriteShort(chr.Vit); // 氣力
                plew.WriteShort(chr.Int); // 智力
                plew.WriteShort(chr.MaxAttack); // 攻擊力(Max)
                plew.WriteShort(chr.Attack); // 攻擊力(Min)
                plew.WriteShort(chr.MaxMagic); // 魔攻力(Max)
                plew.WriteShort(chr.Magic); // 魔攻力(Min)
                plew.WriteShort(chr.Defense); // 防禦力
                plew.WriteByte(0);
                plew.WriteByte(0);
                plew.WriteByte(0);
                plew.WriteByte(0);
                plew.WriteShort(chr.AbilityBonus); // 能力上升值
                plew.WriteShort(chr.SkillBonus); // 技能上升值
                plew.WriteShort(chr.UpgradeStr); // 力量+
                plew.WriteShort(chr.UpgradeDex); // 敏捷+
                plew.WriteShort(chr.UpgradeVit); // 氣力+
                plew.WriteShort(chr.UpgradeInt); // 智力+
                plew.WriteShort(chr.UpgradeAttack); // 攻擊力+
                plew.WriteShort(chr.UpgradeMagic); // 魔攻力+
                plew.WriteShort(chr.UpgradeDefense); // 防禦力+
                plew.WriteShort(0);
                plew.WriteShort(0);

                c.Send(plew);
            }
        }

        public static void updateHpMp(Client c, int hp, short mp, short maxFury, short fury)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.CHAR_HPSP))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(hp);
                plew.WriteShort(mp);
                plew.WriteShort(maxFury);
                plew.WriteShort(fury);
                plew.WriteShort(-1);

                c.Send(plew);
            }
        }

        public static void levelUp(Client c, int level)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.CHAR_LEVELUP))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(c.Character.CharacterID);
                plew.WriteInt(level);

                c.Send(plew);
            }
        }

        public static void updateStat(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.CHAR_STATUP_ACK))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteShort(chr.MaxHp);
                plew.WriteShort(chr.MaxMp);
                plew.WriteShort(chr.Str);
                plew.WriteShort(chr.Dex);
                plew.WriteShort(chr.Vit);//vit
                plew.WriteShort(chr.Int);
                plew.WriteShort(chr.MaxAttack);
                plew.WriteShort(chr.Attack);
                plew.WriteShort(chr.MaxMagic);
                plew.WriteShort(chr.Magic);
                plew.WriteShort(chr.Defense);
                plew.WriteByte(3);
                plew.WriteHexString("64 00 00");
                plew.WriteShort(chr.AbilityBonus);
                plew.WriteShort(chr.SkillBonus);
                plew.WriteShort(chr.UpgradeStr);
                plew.WriteShort(chr.UpgradeDex);
                plew.WriteShort(chr.UpgradeVit);//vit
                plew.WriteShort(chr.UpgradeInt);
                plew.WriteShort(chr.UpgradeAttack);
                plew.WriteShort(chr.UpgradeMagic);
                plew.WriteShort(chr.UpgradeDefense);
                c.Send(plew);
            }
        }
    }

    public static class SkillPacket
    {
        public static void getSkillInfo(Client c, List<Skill> skill)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.SKILL_ALL))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                for (int i = 0; i < 10; i++)
                {
                    int skillID = 0;
                    foreach(Skill s in skill)
                    {
                        skillID = (s.slot == i ? s.SkillID : 0);
                        if (skillID > 0)
                            break;
                    }
                    plew.WriteShort(skillID);
                }
                for (int i = 0; i < 10; i++)
                {
                    int skillLevel = 0;
                    foreach (Skill s in skill)
                    {
                        skillLevel = (s.slot == i ? s.SkillLevel : 0);
                        if (skillLevel > 0)
                            break;
                    }
                    plew.WriteByte(skillLevel);
                }
                plew.WriteBytes(new byte[174]);
                c.Send(plew);
            }
        }

        public static void updateSkillLevel(Client c, short skillBonus, byte inventory, byte slot, byte level)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.SKILL_LEVELUP_ACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteShort(skillBonus);
                plew.WriteByte(inventory);
                plew.WriteByte(slot);
                plew.WriteByte(level);
                c.Send(plew);
            }
        }
    }

    public static class QuestPacket
    {
        public static void getQuestInfo(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.QUEST_ALL))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteHexString("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 20 20 20 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 30 30 30 30 30 30 30 30 30 30 30 30 20 20 20 20 30 30 30 30 30 30 30 30 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 30 30 30 30 30 30 20 20 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 30 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 30 30 20 20 20 20 20 20 20 20 30 30 30 30 30 30 30 30 30 30 20 20 20 20 20 20 20 20 20 20 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 30 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 30 20 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 30 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 30 20 20 20 30 20 20 20 20 20 20 20 20 20 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 30 30 30 30 30 20 20 20 20 20 30 30 20 20 20 20 20 20 20 20 20 20 20 30 30 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 32 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 30 30 30 30 30 30 30 30 30 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 00 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 00");

                c.Send(plew);
            }
        }

        public static void getQuickSlot(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.QUICKSLOTALL))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteHexString("01 00 00 00 00 00 00 00 04 00 00 00 00 00 03 00 03 00 00 00 00 00 02 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 37 45 08");

                c.Send(plew);
            }
        }
    }

    public static class MonsterPacket
    {
        public static void createAllMonster(Client c, Monster[] monster)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.MON_ALLCREATE))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(monster.Length);
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteByte(1);
                }
                for (int i = 0; i < 50; i++)
                {//Level
                    plew.WriteByte(monster[i].Level);
                }
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteByte(0);
                }
                for (int i = 0; i < 50; i++)
                {//Facing
                    plew.WriteByte(monster[i].Facing);
                }
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteBytes(1);
                }
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteBytes(0);
                }
                for (int i = 0; i < 50; i++)
                {//IN MAP ID
                    plew.WriteShort(i);
                }
                for (int i = 0; i < 50; i++)
                {//Mob X
                    plew.WriteShort(monster[i].PositionX);
                }
                for (int i = 0; i < 50; i++)
                {//Y
                    plew.WriteShort(monster[i].PositionY);
                }
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteInt(0);
                }
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteInt(0);
                }
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteShort(5);
                }
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteShort(6);
                }
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteShort(5);
                }
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteShort(1);
                }
                for (int i = 0; i < 50; i++)
                {//Mobs ID
                    plew.WriteInt(monster[i].MonsterID);
                }
                for (int i = 0; i < 50; i++)
                {//MobSpeed
                    plew.WriteShort(monster[i].Speed);
                    plew.WriteShort(monster[i].Speed);
                }
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteHexString("CB 46");
                }
                for (int i = 0; i < 50; i++)
                {//MobHP
                    plew.WriteInt(monster[i].MP);
                }
                for (int i = 0; i < 50; i++)
                {//MobHP
                    plew.WriteInt(monster[i].HP);
                }
                c.Send(plew);
            }
        }

        public static void spawnMonster(Client c, Monster Monster, int CharacterID, int Damage, short HitX, short HitY)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.MON_SPAWN))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteByte(Monster.State);
                plew.WriteHexString("00 00 00");
                plew.WriteInt(Monster.OriginalID);
                plew.WriteShort(0);
                plew.WriteShort(0);
                plew.WriteByte(Monster.Facing);
                plew.WriteHexString("FF FF FF 00 00 40 40");
                plew.WriteShort(Monster.PositionX);
                plew.WriteShort(Monster.PositionY);
                plew.WriteHexString("00 00 00 00 00 00 00 00");
                plew.WriteInt(CharacterID);
                plew.WriteInt(Damage); // Damage
                plew.WriteInt(Monster.HP);
                plew.WriteShort(HitX); // Hit
                plew.WriteShort(HitY); // Hit
                plew.WriteHexString("00 00 00 00 00 00 00 00");

                c.Send(plew);
            }
        }
    }
}
