using Server.Common.IO.Packet;
using Server.Ghost;
using System;
using System.Collections.Generic;
using System.Threading;

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
            gc.Character.MapX = mapX;
            gc.Character.MapY = mapY;
            gc.Character.PlayerX = playerX;
            gc.Character.PlayerY = playerY;
            MapPacket.warpToMap(gc, playerId, mapX, mapY, playerX, playerY);
            if (mapX == 2 && mapY == 1)
            {
                Map map = new Map();
                gc.Character.SetMap(map);
                map.Monster = new List<Monster>();

                Random random = new Random();
                Monster[] monster = new Monster[50];
                for (int i = 0; i < 50; i++)
                {
                    int facing = 0;
                    if (i < 25)
                    {
                        facing = 0xFF;
                    } else
                    {
                        facing = 0x01;
                    }
                    monster[i] = new Monster(i, 1000101, 3, 3, 10, 1, facing, 1, random.Next(25, 4775), random.Next(436, 1045));
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
