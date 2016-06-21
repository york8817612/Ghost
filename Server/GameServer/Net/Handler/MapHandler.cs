using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;

namespace Server.Handler
{
    public static class MapHandler
    {
        public static void WarpToMap_Req(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            Map map = MapFactory.GetMap(chr.MapX, chr.MapY);
            map.Characters.Remove(chr);
            foreach (Character All in map.Characters)
                MapPacket.removeUser(All.Client, chr);

            int playerId = lea.ReadInt();
            short mapX = lea.ReadShort();
            short mapY = lea.ReadShort();
            short positionX = lea.ReadShort();
            short positionY = lea.ReadShort();

            if (mapX == 77 && mapY == 1)
            {
                CashShopPacket.CashShopList1(gc); // 人物
                CashShopPacket.CashShopList2(gc); // 裝備
                CashShopPacket.CashShopList3(gc); // 能力
                CashShopPacket.CashShopList4(gc); // 靈物
                CashShopPacket.CashShopList5(gc); // 寶牌
                CashShopPacket.CashShopList6(gc);
                CashShopPacket.CashShopList7(gc); // 紅利積點
                CashShopPacket.CashShopList8(gc);
                CashShopPacket.CashShopList9(gc);
            }

            chr.MapX = mapX;
            chr.MapY = mapY;
            chr.PlayerX = positionX;
            chr.PlayerY = positionY;

            map = MapFactory.GetMap(chr.MapX, chr.MapY);
            map.Characters.Add(chr);
            foreach (Character All in map.Characters)
                MapPacket.warpToMap(All.Client, chr, playerId, mapX, mapY, positionX, positionY);

            if (map.GetMapCharactersTotal() > 1)
            {
                foreach (Character All in map.Characters)
                {
                    MapPacket.createUser(All.Client, chr, map);
                }
            }

            MonsterPacket.createAllMonster(gc, map, map.Monster);

            int j = 0;

            for (int i = 0; i < 50; i++)
            {
                if (map.Monster[i] != null)
                {
                    j++;
                }
            }

            //for (int i = 0; i < j; i++)
            //{
            //    foreach (Character All in map.Characters)
            //    {
            //        if (map.Monster[i].IsAlive == true)
            //            MonsterPacket.spawnMonster(All.Client, map.Monster[i], 0, 0, 0, 0);
            //    }
            //}

            //if (map.GetMapCharactersTotal() < 1)
            //{
                map.ControlMonster(gc, j);
            //}

            StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
            InventoryPacket.getAvatar(gc);

            if (mapX == 77 && mapY == 1)
            {
                CashShopPacket.MgameCash(gc);
                CashShopPacket.GuiHonCash(gc);
            }
        }

        public static void WarpToMapAuth_Req(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            int MapX = (chr.IsAlive == true ? lea.ReadShort() : lea.ReadInt());
            short MapY = lea.ReadShort();
            short PositionX = lea.ReadShort();
            short PositionY = lea.ReadShort();
            bool IsAvailableMap = true;
            if (chr.IsAlive == false)
            {
                StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
                chr.IsAlive = true;
            }
            MapPacket.warpToMapAuth(gc, IsAvailableMap, (short)MapX, MapY, PositionX, PositionY);
        }
    }
}
