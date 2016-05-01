using Server.Common.IO.Packet;
using Server.Ghost;

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
                Monster monster = new Monster(1000301, 3, 37, 10, 2, 1, 6433, 917);
                MonsterPacket.createAllMonster(gc, monster);
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
