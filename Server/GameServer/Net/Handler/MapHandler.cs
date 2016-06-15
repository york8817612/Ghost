using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;
using System.Threading;

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
            Thread thread = new Thread(() => ControlMonster(gc, map, j));
            thread.Start();
        }

        public static void ControlMonster(Client gc, Map map, int j)
        {
            System.Timers.Timer tmr = new System.Timers.Timer(1000);
            tmr.Elapsed += delegate
            {
                if (gc.Character.MapX != map.MapX || gc.Character.MapY != map.MapY)
                {
                    tmr.Stop();
                    return;
                }
                for (int i = 0; i < j; i++)
                {
                    if (map.Monster[i].IsAlive == false)
                        continue;
                    if (map.Monster[i].State == 7 || map.Monster[i].State == 9)
                    {
                        if (map.Monster[i].AttackType > 0)
                            map.Monster[i].State = 3;
                        MonsterPacket.spawnMonster(gc, map.Monster[i], 0, 0, 0, 0);
                        continue;
                    }
                    int Direction = map.Monster[i].Direction;
                    Monster Monster = UpdatePosition(map.Monster[i], (int)(40 * map.Monster[i].Speed), map);
                    if (Direction != Monster.Direction)
                        MonsterPacket.spawnMonster(gc, map.Monster[i], 0, 0, 0, 0);
                }
            };
            tmr.Start();

            System.Timers.Timer tmr2 = new System.Timers.Timer(10000);
            tmr2.Elapsed += delegate
            {
                if (gc.Character.MapX != map.MapX || gc.Character.MapY != map.MapY)
                {
                    tmr2.Stop();
                    return;
                }
                for (int i = 0; i < j; i++)
                {
                    if (map.Monster[i].IsAlive == false)
                    {
                        map.Monster[i].HP = MobFactory.MonsterMaxHP(map.Monster[i].Level);
                        MonsterPacket.regenrMonster(gc, map.Monster[i]);
                        map.Monster[i].IsAlive = true;
                        map.Monster[i].State = 1;
                        MonsterPacket.spawnMonster(gc, map.Monster[i], 0, 0, 0, 0);
                    }
                }
            };
            tmr2.Start();
        }

        public static Monster UpdatePosition(Monster monster, int Dest, Map map)
        {
            int Direction = 1;
            if (monster.Direction == 0xFF)
                Direction = -1;

            sbyte PexInf;
            for (int i = Dest; i > 0; i--)
            {
                if (monster.PositionX <= 25 || monster.PositionX >= map.GetMapWidth() - 25)
                {
                    Direction = Direction * (-1);
                    //monster.Direction = Direction;
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
                        //monster.Direction = Direction;
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
                        //monster.Direction = Direction;
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

            if (Direction == 1)
                monster.Direction = 0x1;
            else
                monster.Direction = 0xFF;

            return monster;
        }

        public static void WarpToMapAuth_Req(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            int mapX = (chr.IsAlive == true ? lea.ReadShort() : lea.ReadInt());
            short mapY = lea.ReadShort();
            short positionX = lea.ReadShort();
            short positionY = lea.ReadShort();
            bool isAvailableMap = true;
            if (chr.IsAlive == false)
            {
                chr.Hp = 1;
                chr.Mp = 1;
                StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
                chr.IsAlive = true;
            }
            MapPacket.warpToMapAuth(gc, isAvailableMap, (short)mapX, mapY, positionX, positionY);
        }
    }
}
