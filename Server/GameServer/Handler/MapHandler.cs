using Server.Common.IO.Packet;
using Server.Ghost;
using System;

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
                Random random = new Random();
                Monster[] monster = new Monster[50];
                for (int i = 0; i < 50; i++)
                {
                    monster[i] = new Monster(1000011, 3, 37, 10, 2, 1, random.Next(25, 4775), random.Next(436, 1045));
                }
                MonsterPacket.createAllMonster(gc, monster);
                for (int i = 0; i < 50; i++)
                {
                    MonsterPacket.spawnMonster(gc);
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
