using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Ghost;
using Server.Net;
using System.Collections.Generic;

namespace Server.Packet
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
                plew.WriteByte(0xFF);
                plew.WriteByte(0xFF); // 變身效果
                plew.WriteByte(0xFF);
                plew.WriteHexString("00 00 3A 01");
                plew.WriteInt(chr.Hair);                                                                                        // 頭髮
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Face) ? equip[InventoryType.EquipType.Face] : 0);       // 臉上
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Face2) ? equip[InventoryType.EquipType.Face2] : 0);     // 臉下
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Hat) ? equip[InventoryType.EquipType.Hat] : 0);         // 帽子
                plew.WriteInt(chr.Eyes);                                                                                        // 眼睛
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Outfit) ? equip[InventoryType.EquipType.Outfit] : 0);   // 衣服
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Dress) ? equip[InventoryType.EquipType.Dress] : 0);     // 服裝
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Weapon) ? equip[InventoryType.EquipType.Weapon] : 0);   // 武器
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Mantle) ? equip[InventoryType.EquipType.Mantle] : 0);   // 披風
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Pet) ? equip[InventoryType.EquipType.Pet] : 0);         // 靈物
                //plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.HairAcc) ? equip[InventoryType.EquipType.HairAcc] : 0);// HairAcc
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Toy) ? equip[InventoryType.EquipType.Toy] : 0);         // 玩物
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
                plew.WriteHexString("00 00");
                plew.WriteByte(chr.IP.GetAddressBytes()[0]);
                plew.WriteByte(chr.IP.GetAddressBytes()[1]);
                plew.WriteByte(chr.IP.GetAddressBytes()[2]);
                plew.WriteByte(chr.IP.GetAddressBytes()[3]);
                plew.WriteByte(192);
                plew.WriteByte(168);
                plew.WriteByte(1);
                plew.WriteByte(101);
                plew.WriteHexString("1F 40"); // Port
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
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(chr.CharacterID); // 玩家ID
                c.Send(plew);
            }
        }

        public static void createUser(Client c, Map map)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.USER_CREATE))
            {
                var myCharacter = c.Character;
                var chr = map.Characters;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(map.GetMapCharactersTotal() - 1); // 玩家數量 - 1
                for (int i = 0; i < map.GetMapCharactersTotal() - 1; i++)
                {
                    if (chr[i].CharacterID == myCharacter.CharacterID)
                        continue;

                    Dictionary<InventoryType.EquipType, int> equip = null;
                    try
                    {
                        equip = InventoryPacket.getEquip(chr[i]);
                    } catch
                    {
                        equip = null;
                    }
                    plew.WriteInt(i < chr.Count ? chr[i].CharacterID : -1); // 玩家ID(-1)
                    plew.WriteString(i < chr.Count ? chr[i].Name : "", 20); // 玩家名稱
                    plew.WriteString(i < chr.Count ? chr[i].Title: "", 20); // 玩家稱號
                    plew.WriteShort(i < chr.Count ? chr[i].PlayerX : 0); // 玩家 PositionX
                    plew.WriteShort(i < chr.Count ? chr[i].PlayerY : 0); // 玩家 PositionY
                    plew.WriteByte(i < chr.Count ? chr[i].Gender : 1); // 性別(1)
                    plew.WriteByte(i < chr.Count ? chr[i].Level : 0); // 等級
                    plew.WriteByte(i < chr.Count ? chr[i].Class : 0); // 職業
                    plew.WriteByte(i < chr.Count ? chr[i].ClassLevel : -1); // (-1)
                    plew.WriteByte(i < chr.Count ? - 1 : 0);
                    plew.WriteByte(0);
                    plew.WriteByte(0); // HidePlayer
                    plew.WriteByte(0); // ReflectorSkill
                    plew.WriteByte(0); // 1 : 個人商店
                    plew.WriteHexString("00 00 00");
                    plew.WriteInt(i < chr.Count ? chr[i].Hair : 0);                                                                                   // 頭髮[Hair]
                    plew.WriteInt(i < chr.Count ? equip.ContainsKey(InventoryType.EquipType.Face) ? equip[InventoryType.EquipType.Face] : 0 : 0);     // 臉上[Face]
                    plew.WriteInt(i < chr.Count ? equip.ContainsKey(InventoryType.EquipType.Face2) ? equip[InventoryType.EquipType.Face2] : 0 : 0);   // 臉下[Face2]
                    plew.WriteInt(i < chr.Count ? equip.ContainsKey(InventoryType.EquipType.Hat) ? equip[InventoryType.EquipType.Hat] : 0 : 0);       // 頭部[Hat]
                    plew.WriteInt(i < chr.Count ? chr[i].Eyes : 0);                                                                                   // 眼睛[Eyes]
                    plew.WriteInt(i < chr.Count ? equip.ContainsKey(InventoryType.EquipType.Outfit) ? equip[InventoryType.EquipType.Outfit] : 0 : 0); // 衣服[Outfit]
                    plew.WriteInt(i < chr.Count ? equip.ContainsKey(InventoryType.EquipType.Dress) ? equip[InventoryType.EquipType.Dress] : 0 : 0);   // 服裝[Dress]
                    plew.WriteInt(i < chr.Count ? equip.ContainsKey(InventoryType.EquipType.Weapon) ? equip[InventoryType.EquipType.Weapon] : 0 : 0); // 武器[Weapon]
                    plew.WriteInt(i < chr.Count ? equip.ContainsKey(InventoryType.EquipType.Mantle) ? equip[InventoryType.EquipType.Mantle] : 0 : 0); // 披風[Mantle]
                    plew.WriteInt(i < chr.Count ? equip.ContainsKey(InventoryType.EquipType.Pet) ? equip[InventoryType.EquipType.Pet] : 0 : 0);       // 靈物[Pet]
                    //plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.HairAcc) ? equip[InventoryType.EquipType.HairAcc] : 0);
                    plew.WriteInt(i < chr.Count ? equip.ContainsKey(InventoryType.EquipType.Toy) ? equip[InventoryType.EquipType.Toy] : 0 : 0);       // 玩物[Toy]

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
                    plew.WriteByte(chr[i].IP.GetAddressBytes()[0]);
                    plew.WriteByte(chr[i].IP.GetAddressBytes()[1]);
                    plew.WriteByte(chr[i].IP.GetAddressBytes()[2]);
                    plew.WriteByte(chr[i].IP.GetAddressBytes()[3]);

                    // 本地IP位置
                    plew.WriteByte(myCharacter.IP.GetAddressBytes()[0]);
                    plew.WriteByte(myCharacter.IP.GetAddressBytes()[1]);
                    plew.WriteByte(myCharacter.IP.GetAddressBytes()[2]);
                    plew.WriteByte(myCharacter.IP.GetAddressBytes()[3]);

                    plew.WriteHexString(i < chr.Count ? "1F 40" : "00 00");
                    // 個人商店
                    plew.WriteString("", 40); // 個人商店名稱

                    plew.WriteShort(0);
                    plew.WriteShort(i < chr.Count ? -1 : 0);
                    plew.WriteShort(0);
                    plew.WriteInt(0);
                    plew.WriteInt(0);
                    plew.WriteInt(i < chr.Count ? -1 : 0);

                    plew.WriteString("", 20);

                    plew.WriteByte(0);
                    plew.WriteByte(0); // Like Warp On Player Effect
                    plew.WriteByte(0);
                    plew.WriteByte(0); // 泡泡效果
                    plew.WriteByte(0); // 泡泡效果
                    plew.WriteByte(0);
                    plew.WriteShort(0);
                    plew.WriteShort(i < chr.Count ? -1 : 0);// 玩家ID [Map Number]
                    plew.WriteByte(i < chr.Count ? -1 : 0);
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
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(chr.CharacterID); // 玩家ID
                plew.WriteShort(1);
                plew.WriteShort(1);
                plew.WriteShort(chr.PlayerX); // 玩家 PositionX
                plew.WriteShort(chr.PlayerY); // 玩家 PositionY

                plew.WriteShort(1);
                plew.WriteShort(1);
                plew.WriteShort(chr.PlayerX); // 玩家 PositionX
                plew.WriteShort(chr.PlayerY); // 玩家 PositionY

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
    }
}
