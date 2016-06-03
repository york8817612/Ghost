using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;
using System.Threading;

namespace Server.Handler
{
    class MapHandler
    {
        public static void WarpToMap_Req(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            Map map = MapFactory.GetMap(chr.MapX, chr.MapY);
            map.Characters.Remove(chr);
            //foreach (Character all in map.Characters)
            //    MapPacket.removeUser(gc);

            int playerId = lea.ReadInt();
            short mapX = lea.ReadShort();
            short mapY = lea.ReadShort();
            short positionX = lea.ReadShort();
            short positionY = lea.ReadShort();
            chr.MapX = mapX;
            chr.MapY = mapY;
            chr.PlayerX = positionX;
            chr.PlayerY = positionY;

            map = MapFactory.GetMap(mapX, mapY);
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
            Thread thread = new Thread(() => ControlMonster(gc, map));
            thread.Start();
        }

        public static void ControlMonster(Client gc, Map map)
        {
            MonsterPacket.createAllMonster(gc, map, map.Monster);

            //int j = 0;

            //for (int i = 0; i < 50; i++)
            //{
            //    if (map.Monster[i] != null)
            //    {
            //        j++;
            //    }
            //}

            ////for (int k = 0; k < j; k++)
            ////{
            ////    MonsterPacket.spawnMonster(gc, map.Monster[k], 0, 0, 0, 0);
            ////}

            //System.Timers.Timer tmr = new System.Timers.Timer(1000);
            //tmr.Elapsed += delegate
            //{
            //    for (int i = 0; i < j; i++)
            //    {
            //            Position pos = new Position(map.Monster[i].PositionX, map.Monster[i].PositionY, map.Monster[i].Direction);
            //            if (map.Monster[i].State == 0x7 || map.Monster[i].State == 0x9)
            //            {
            //                map.Monster[i].State = 0x1;
            //                pos.Direction *= -1;
            //                Position NextPosition = FindPath(pos, 40, map);
            //                NextPosition.Direction *= -1;
            //                map.Monster[i].PositionX = NextPosition.PositionX;
            //                map.Monster[i].PositionY = NextPosition.PositionY;
            //                map.Monster[i].Direction = NextPosition.Direction;
            //                MonsterPacket.spawnMonster(gc, map.Monster[i], 0, 0, 0, 0);
            //                continue;
            //            }
            //            Position Next = FindPath(pos, (int)(40 * map.Monster[i].Speed), map);
            //            map.Monster[i].State = 0x1;
            //            map.Monster[i].PositionX = Next.PositionX;
            //            map.Monster[i].PositionY = Next.PositionY;
            //            map.Monster[i].Direction = Next.Direction;
            //            MonsterPacket.spawnMonster(gc, map.Monster[i], 0, 0, 0, 0);
            //    }
            //};
            //tmr.Start();
        }

        public static Position FindPath(Position Pos, int Dest, Map map)
        {
            int Facing = 1;
            if (Pos.Direction == 0xFF)
                Facing = -1;

            sbyte PexInf;
            for (int i = Dest; i > 0; i--)
            {
                if (Pos.PositionX <= 25 || Pos.PositionX >= map.GetMapWidth() - 25)
                {
                    Facing = Facing * (-1);
                    Pos.PositionX = Pos.PositionX + Facing;
                    break;
                }
                //Strat Walking in Facing

                //If We Get Cell -1
                //Get Cell Data IF Cell Data !4(Wall) -> Fix Y Pos Try Look UP For Cell, Not Found Try Look Down, Not Found Reverc Facing

                sbyte Curr_ = map.GetMapPexel(Pos.PositionX, Pos.PositionY);
                Pos.PositionX = Pos.PositionX + Facing;
                sbyte Next = map.GetMapPexel(Pos.PositionX, Pos.PositionY);

                if (Next == -1)
                {
                    PexInf = map.GetPexInfo(Pos.PositionX, Pos.PositionY);
                    if (PexInf == 4)
                    {
                        Facing = Facing * (-1);
                        Pos.PositionX = Pos.PositionX + Facing;
                        continue;
                    }
                    Pos.PositionY = (Pos.PositionY / 32) * 32;
                    Pos.PositionY += Curr_;
                    Pos.PositionY = (int)((((float)Pos.PositionY / 32) - 0.01) * 32);
                    sbyte Next_ = map.GetMapPexel(Pos.PositionX, Pos.PositionY);
                    //It Need Be In Below Cell
                    if (Next_ == -1 && Curr_ == 31)
                    {
                        Pos.PositionY = (Pos.PositionY / 32);
                        Pos.PositionY += 1;
                        Pos.PositionY *= 32;
                        //Pos.PositionY = (int)((((float)Pos.PositionY/32)-0.01)*32);
                        sbyte Next__ = map.GetMapPexel(Pos.PositionX, Pos.PositionY);
                        if (Next__ != -1)
                            continue;
                    }
                    if (Next_ == -1)
                    {
                        Facing = Facing * (-1);
                        Pos.PositionX = Pos.PositionX + Facing;
                        break;
                    }
                    continue;
                }
            }
            //Before Return Val Fix the Y	
            sbyte Curr = map.GetMapPexel(Pos.PositionX, Pos.PositionY);
            if (Curr != 0)
            {
                Pos.PositionY = (Pos.PositionY / 32) * 32;
                Pos.PositionY += Curr;
                Pos.PositionY = (int)((((float)Pos.PositionY / 32) - 0.01) * 32);
                sbyte Next = map.GetMapPexel(Pos.PositionX, Pos.PositionY);
            }
            if (Facing == 1)
                Pos.Direction = 0x1;
            else
                Pos.Direction = 0xFF;

            return Pos;
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

    class Position
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Direction { get; set; }

        public Position(int PositionX, int PositionY, int Direction)
        {
            this.PositionX = PositionX;
            this.PositionY = PositionY;
            this.Direction = Direction;
        }
    }
}
