using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Common.Net;
using System.Collections.Generic;

namespace Server.Ghost
{
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

        public static void warpToMap(Client c, int playerId, short mapX, short mapY, short positionX, short positionY)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.ENTER_WARP_ACK))
            {
                var chr = c.Character;
                Dictionary<InventoryType.EquipType, int> equip = InventoryPacket.getEquip(chr);
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(playerId); // 角色編號
                plew.WriteString(chr.Name, 20);
                plew.WriteString(chr.Title, 20);
                plew.WriteShort(mapX);
                plew.WriteShort(mapY);
                plew.WriteShort(positionX);
                plew.WriteShort(positionY);
                plew.WriteByte(chr.Gender);
                plew.WriteByte(chr.Level);
                plew.WriteByte(chr.Class);
                plew.WriteByte(chr.ClassLevel);
                plew.WriteByte(0xFF);
                plew.WriteByte(0);
                plew.WriteByte(0); // 變身效果
                plew.WriteByte(0);
                plew.WriteInt(0);
                plew.WriteInt(chr.Hair);                                                                              // 頭髮
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Face) ? equip[InventoryType.EquipType.Face] : 0);  // 臉上
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Face2) ? equip[InventoryType.EquipType.Face2] : 0);// 臉下
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Hat) ? equip[InventoryType.EquipType.Hat] : 0);  // 帽子
                plew.WriteInt(chr.Eyes);                                                                              // 眼睛
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Outfit) ? equip[InventoryType.EquipType.Outfit] : 0);  // 衣服
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Dress) ? equip[InventoryType.EquipType.Dress] : 0);// 服裝
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Weapon) ? equip[InventoryType.EquipType.Weapon] : 0);  // 武器
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Mantle) ? equip[InventoryType.EquipType.Mantle] : 0);  // 披風
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Pet) ? equip[InventoryType.EquipType.Pet] : 0);// 靈物
                //plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.HairAcc) ? equip[InventoryType.EquipType.HairAcc] : 0);// HairAcc
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Toy) ? equip[InventoryType.EquipType.Toy] : 0);// 玩物
                // 寵物
                plew.WriteString("", 20); // PetName
                plew.WriteInt(0); // PetLevel
                plew.WriteInt(0); // PetHP
                plew.WriteInt(0);
                plew.WriteInt(0);
                plew.WriteInt(0);
                plew.WriteInt(0);
                // 玩物
                plew.WriteString("", 20); // ToyName
                plew.WriteInt(0); // ToyLevel
                plew.WriteInt(0);
                plew.WriteInt(0);
                plew.WriteInt(0);
                //
                plew.WriteShort(0);
                plew.WriteShort(0);
                plew.WriteHexString("00 00 00 00 00 00 00 00 00 00 1F 40");
                plew.WriteShort(0);
                plew.WriteShort(0);
                plew.WriteHexString("00 00 00 00 00 00 00 00");
                plew.WriteInt(0);
                plew.WriteByte(0);
                plew.WriteByte(0);
                plew.WriteByte(0);
                plew.WriteByte(0);
                plew.WriteByte(0);
                plew.WriteByte(0);
                plew.WriteShort(0);
                plew.WriteByte(0);
                plew.WriteByte(0);
                plew.WriteByte(0);
                plew.WriteByte(0);
                c.Send(plew);
            }
        }

        public static void removeUser(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.LEAVE_WARP_ACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(0); // 玩家ID
                c.Send(plew);
            }
        }

        public static void createUser(Client c, int playerCount)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.USER_CREATE))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(playerCount); // 玩家數量 - 1
                for (int i = 0; i < 250; i++)
                {
                    plew.WriteInt(-1); // 玩家ID
                    plew.WriteString("", 20); // 玩家名稱
                    plew.WriteString("", 20); // 玩家稱號
                    plew.WriteShort(0); // 玩家 PositionX
                    plew.WriteShort(0); // 玩家 PositionY
                    plew.WriteByte(1); // 性別
                    plew.WriteByte(0); // 等級
                    plew.WriteByte(0); // 職業
                    plew.WriteByte(-1);
                    plew.WriteByte(-1);
                    plew.WriteByte(0);
                    plew.WriteByte(0); // HidePlayer
                    plew.WriteByte(0); // ReflectorSkill
                    plew.WriteByte(0); // 1 : 個人商店
                    plew.WriteHexString("00 00 00");
                    plew.WriteInt(0); // 頭髮[Hair]
                    plew.WriteInt(0); // 臉上[Face]
                    plew.WriteInt(0); // 臉下[Face2]
                    plew.WriteInt(0); // 頭部[Hat]
                    plew.WriteInt(0); // 眼睛[Eyes]
                    plew.WriteInt(0); // 衣服[Outfit]
                    plew.WriteInt(0); // 服裝[Dress]
                    plew.WriteInt(0); // 武器[Weapon]
                    plew.WriteInt(0); // 披風[Mantle]
                    plew.WriteInt(0); // 靈物[Pet]
                    //plew.WriteInt(0); // [HairAcc]
                    plew.WriteInt(0); // 玩物[Toy]

                    // 寵物
                    plew.WriteString("", 20); // PetName
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                    plew.WriteInt(0);

                    // 玩物
                    plew.WriteString("", 20); // ToyName
                    plew.WriteInt(0); // ToyLevel
                    plew.WriteInt(0); // ToyHP
                    plew.WriteInt(0); // ToyMaxMP

                    plew.WriteShort(0); // 武器 Glow ++
                    plew.WriteShort(0);

                    // 遠端IP位置
                    plew.WriteByte(0);
                    plew.WriteByte(0);
                    plew.WriteByte(0);
                    plew.WriteByte(0);

                    // 本地IP位置
                    plew.WriteByte(0);
                    plew.WriteByte(0);
                    plew.WriteByte(0);
                    plew.WriteByte(0);

                    plew.WriteHexString("1F 40");
                    // 個人商店
                    plew.WriteString("", 40); // 個人商店名稱

                    plew.WriteShort(0);
                    plew.WriteShort(-1);
                    plew.WriteShort(0);
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                    plew.WriteInt(-1);

                    plew.WriteString("", 20);

                    plew.WriteByte(0);
                    plew.WriteByte(0); // Like Warp On Player Effect
                    plew.WriteByte(0);
                    plew.WriteByte(0); // 泡泡效果
                    plew.WriteByte(0); // 泡泡效果
                    plew.WriteByte(0);
                    plew.WriteShort(0);
                    plew.WriteShort(-1);// 玩家ID [Map Number]
                    plew.WriteByte(-1);
                    plew.WriteByte(0);
                    plew.WriteByte(0);
                    plew.WriteByte(0);
                    plew.WriteShort(0);
                }
                c.Send(plew);
            }
        }

        public static void userDead(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PLAYER_DEAD_ACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(0); // 玩家ID
                plew.WriteShort(1);
                plew.WriteShort(1);
                plew.WriteShort(0); // 玩家 PositionX
                plew.WriteShort(0); // 玩家 PositionY

                plew.WriteShort(1);
                plew.WriteShort(1);
                plew.WriteShort(0); // 玩家 PositionX
                plew.WriteShort(0); // 玩家 PositionY

                c.Send(plew);
            }
        }

        public static void warpToMapAuth(Client c, bool isAvailableMap, short mapX, short mapY, short positionX, short positionY)
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
}
