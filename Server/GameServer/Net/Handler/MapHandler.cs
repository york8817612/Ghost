using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Net;
using Server.Packet;
using System.Collections.Generic;

namespace Server.Handler
{
    class MapHandler
    {
        public static void WarpToMap_Req(InPacket lea, Client gc)
        {
            int playerId = lea.ReadInt();
            short mapX = lea.ReadShort();
            short mapY = lea.ReadShort();
            short playerX = lea.ReadShort();
            short playerY = lea.ReadShort();
            var chr = gc.Character;
            chr.MapX = mapX;
            chr.MapY = mapY;
            chr.PlayerX = playerX;
            chr.PlayerY = playerY;
            MapPacket.warpToMap(gc, playerId, mapX, mapY, playerX, playerY);
            if (mapX == 2 && mapY == 6)
            {
                Map map = new Map();
                chr.SetMap(map);
                map.Monster = new List<Monster>();
                Monster[] monster = new Monster[50];
                for (int i = 0; i < 50; i++)
                {
                    monster[i] = new Monster(i, 1000601, 3, 33, 10, 0x40400000, 0x01, 1, 0, 253 + i * 100, 1045);
                    map.Monster.Add(monster[i]);
                }
                MonsterPacket.createAllMonster(gc, monster);
                for (int i = 0; i < 50; i++)
                {
                    MonsterPacket.spawnMonster(gc, monster[i], 0, 0, 0, 0);
                }
            }
        }

        public static void WarpToMapAuth_Req(InPacket lea, Client gc)
        {
            short mapX = lea.ReadShort();
            short mapY = lea.ReadShort();
            short positionX = lea.ReadShort();
            short positionY = lea.ReadShort();
            bool isAvailableMap = true;
            MapPacket.warpToMapAuth(gc, isAvailableMap, mapX, mapY, positionX, positionY);
        }
    }
}
