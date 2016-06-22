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
            Map Map = MapFactory.GetMap(chr.MapX, chr.MapY);
            Map.Characters.Remove(chr);
            foreach (Character All in Map.Characters)
                MapPacket.removeUser(All.Client, chr);

            int CharacterID = lea.ReadInt();
            short MapX = lea.ReadShort();
            short MapY = lea.ReadShort();
            short PositionX = lea.ReadShort();
            short PositionY = lea.ReadShort();

            if (MapX == 77 && MapY == 1)
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

            chr.MapX = MapX;
            chr.MapY = MapY;
            chr.PlayerX = PositionX;
            chr.PlayerY = PositionY;

            Map = MapFactory.GetMap(chr.MapX, chr.MapY);
            Map.Characters.Add(chr);
            foreach (Character All in Map.Characters)
                MapPacket.warpToMap(All.Client, chr, CharacterID, MapX, MapY, PositionX, PositionY);

            if (Map.GetMapCharactersTotal() > 1)
            {
                foreach (Character All in Map.Characters)
                {
                    MapPacket.createUser(All.Client, chr, Map);
                }
            }

            if ((Map.MapX == 1 && Map.MapY == 53) || (Map.MapX == 1 && Map.MapY == 54) || (Map.MapX == 1 && Map.MapY == 55))
                return;
            
            MonsterPacket.createAllMonster(gc, Map, Map.Monster);

            int j = 0;

            for (int i = 0; i < 50; i++)
            {
                if (Map.Monster[i] != null)
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
                Map.ControlMonster(gc, j);
            //}

            //StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
            //InventoryPacket.getAvatar(gc, chr);

            if (MapX == 77 && MapY == 1)
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
