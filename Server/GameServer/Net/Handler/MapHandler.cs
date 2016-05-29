using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;

namespace Server.Handler
{
    class MapHandler
    {
        public static void WarpToMap_Req(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            //Map map = MapFactory.GetMap(chr.MapX, chr.MapY);
            //foreach (Character all in map.Characters)
            //    MapPacket.removeUser(gc);
            //if (map != null)
            //    map.Characters.Remove(chr);

            int playerId = lea.ReadInt();
            short mapX = lea.ReadShort();
            short mapY = lea.ReadShort();
            short positionX = lea.ReadShort();
            short positionY = lea.ReadShort();
            chr.MapX = mapX;
            chr.MapY = mapY;
            chr.PlayerX = positionX;
            chr.PlayerY = positionY;

            Map map = MapFactory.GetMap(mapX, mapY);
            map.Characters.Add(chr);
            foreach (Character all in map.Characters)
                MapPacket.warpToMap(all.Client, playerId, mapX, mapY, positionX, positionY);

            if (map.GetMapCharactersTotal() > 1)
            {
                foreach (Character all in map.Characters)
                {
                    MapPacket.createUser(all.Client, map);
                }
            }

            ControlMonster(gc, map);
        }

        public static void ControlMonster(Client gc, Map map)
        {
            MonsterPacket.createAllMonster(gc, map, map.Monster);
           
            //System.Timers.Timer tmr = new System.Timers.Timer(1000);
            //tmr.Elapsed += delegate
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        try
            //        {
            //            if (map.Monster[i].State == 7 || map.Monster[i].State == 9)
            //            {
            //                map.Monster[i].State = 1;
            //                //map.Monster[i].Direction = map.Monster[i].Direction * -1;
            //                //Monster m = FindPath(map.Monster[i], 40, map);
            //                //monster[i].Direction = m.Direction;
            //                //map.Monster[i].PositionX = m.PositionX;
            //                //map.Monster[i].PositionY = m.PositionY;
            //                MonsterPacket.spawnMonster(gc, map.Monster[i], 0, 0, 0, 0);
            //                continue;
            //            }
            //            Monster mon = FindPath(map.Monster[i], 40, map);
            //            map.Monster[i].State = 1;
            //            map.Monster[i].PositionX = mon.PositionX;
            //            map.Monster[i].PositionY = mon.PositionY;
            //            MonsterPacket.spawnMonster(gc, map.Monster[i], 0, 0, 0, 0);
            //        }
            //        catch
            //        {

            //        }
            //    }
            //};
            //tmr.Start();
        }

        public static Monster FindPath(Monster monster, int Dest, Map map)
        {
            int Direction = 1;
            if (monster.Direction == -1)
                Direction = -1;

            sbyte PexInf;
            for (int i = Dest; i > 0; i--)
            {
                if (monster.PositionX <= 25 || monster.PositionX >= map.GetMapWidth() - 25)
                {
                    Direction = Direction * (-1);
                    monster.Direction = Direction;
                    monster.PositionX = monster.PositionX + Direction;
                    break;
                }
                //Strat Walking in Facing

                //If We Get Cell -1
                //Get Cell Data IF Cell Data !4(Wall) -> Fix Y Pos Try Look UP For Cell, Not Found Try Look Down, Not Found Reverc Facing

                sbyte Curr = map.GetMapPexel(monster.PositionX, monster.PositionY);
                monster.PositionX = monster.PositionX + Direction;
                sbyte Next = map.GetMapPexel(monster.PositionX, monster.PositionY);

                if (Next == -1)
                {
                    PexInf = map.GetPexInfo(monster.PositionX, monster.PositionY);
                    if (PexInf == 4)
                    {
                        Direction = Direction * (-1);
                        monster.Direction = Direction;
                        monster.PositionX = monster.PositionX + Direction;
                        continue;
                    }
                    monster.PositionY = (monster.PositionY / 32) * 32;
                    monster.PositionY += Curr;
                    monster.PositionY = (int)((((float)monster.PositionY / 32) - 0.01) * 32);
                    sbyte Next_ = map.GetMapPexel(monster.PositionX, monster.PositionY);
                    //It Need Be In Below Cell
                    if (Next_ == -1 && Curr == 0x1F)
                    {
                        monster.PositionY = (monster.PositionY / 32);
                        monster.PositionY += 1;
                        monster.PositionY *= 32;
                        //Pos.y = (int)((((float)Pos.y/32)-0.01)*32);
                        sbyte Next__ = map.GetMapPexel(monster.PositionX, monster.PositionY);
                        if (Next__ != -1)
                            continue;
                    }
                    if (Next_ == -1)
                    {
                        Direction = Direction * (-1);
                        monster.Direction = Direction;
                        monster.PositionX = monster.PositionX + Direction;
                        break;
                    }
                    continue;
                }
            }
            //Before Return Val Fix the Y	
            sbyte Curr_ = map.GetMapPexel(monster.PositionX, monster.PositionY);
            if (Curr_ != 0)
            {
                monster.PositionY = (monster.PositionY / 32) * 32;
                monster.PositionY += Curr_;
                monster.PositionY = (int)((((float)monster.PositionY / 32) - 0.01) * 32);
                sbyte Next = map.GetMapPexel(monster.PositionX, monster.PositionY);
            }

            //if (Direction == 1)
            //    monster.Direction = 0x1;
            //else
            //    monster.Direction = 0xFF;

            return monster;
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
