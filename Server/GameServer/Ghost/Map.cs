using Server.Common.Threading;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;
using System;
using System.Collections.Generic;

namespace Server.Ghost
{
    public class Map
    {
        public short MapX { get; set; }
        public short MapY { get; set; }
        public int MapHeight { get; set; }
        public int MapWidth { get; set; }
        public sbyte[][] MapPexels;
        public int ObjectID { get; set; }
        public bool IsControling { get; set; }

        public List<Character> Characters { get; private set; }
        public List<Monster> Monster { get; set; }
        public Dictionary<int, Drop> Item { get; set; }

        //private System.Timers.Timer tmr = new System.Timers.Timer(1000);
        //private System.Timers.Timer tmr2 = new System.Timers.Timer(10000);

        public Map(short MapX, short MapY)
        {
            this.MapX = MapX;
            this.MapY = MapY;
            Characters = new List<Character>();
            Monster = new List<Monster>();
            Item = new Dictionary<int, Drop>();
        }

        public void SetMapHeightWidth(int Height, int Width)
        {
            this.MapHeight = Height * 32;
            this.MapWidth = Width * 32;
            Array.Resize(ref MapPexels, Height);
            for (int i = 0; i < Height; ++i)
                Array.Resize(ref MapPexels[i], Width * 33);
        }

        public void SetMapPexel(int X, int Y, sbyte Value)
        {
            this.MapPexels[Y][X] = Value;
        }

        public sbyte GetMapPexel(int X, int Y)
        {
            Y = Y / 32;
            X = X + (X / 32) + 1;
            return this.MapPexels[Y][X];
        }

        public int GetMapWidth()
        {
            return this.MapWidth;
        }

        public sbyte GetPexInfo(int X, int Y)
        {
            Y = Y / 32;
            X = 32 * (X / 32) + (X / 32);
            return this.MapPexels[Y][X];
        }

        public int GetMapCharactersTotal()
        {
            return Characters.Count;
        }

        public Monster getMonsterByOriginalID(int OriginalID)
        {
            foreach (Monster Monster in Monster)
            {
                if (Monster.OriginalID == OriginalID)
                    return Monster;
            }
            return null;
        }

        public Drop getDropByOriginalID(int OriginalID)
        {
            return this.Item[OriginalID];
        }

        public void ControlMonster(Client gc, int j)
        {
            if (this.IsControling == true)
                return;

            var chr = gc.Character;

            this.IsControling = true;

            Delay tmr = new Delay(1000, true, () =>
            {
                //if (this.GetMapCharactersTotal() < 1)
                //{
                //    tmr.Stop();
                //    return;
                //}
                for (int i = 0; i < j; i++)
                {
                    if (this.Monster[i].IsAlive == false)
                        continue;
                    if (this.Monster[i].State == 7 || this.Monster[i].State == 9)
                    {
                        if (this.Monster[i].AttackType > 0)
                        {
                            this.Monster[i].State = 3;
                            foreach (Character All in this.Characters)
                            {
                                if (All.MapX == this.MapX && All.MapY == this.MapY)
                                    MonsterPacket.spawnMonster(All.Client, this.Monster[i], 0, 0, 0, 0);
                            }
                        }
                        this.Monster[i].State = 1;
                        foreach (Character All in this.Characters)
                        {
                            if (All.MapX == this.MapX && All.MapY == this.MapY)
                                MonsterPacket.spawnMonster(All.Client, this.Monster[i], 0, 0, 0, 0);
                        }
                        continue;
                    }
                    int Direction = this.Monster[i].Direction;
                    Monster Monster = UpdatePosition(this.Monster[i], (int)(40 * this.Monster[i].Speed));
                    foreach (Character All in this.Characters)
                    {
                        if (Direction != Monster.Direction && All.MapX == this.MapX && All.MapY == this.MapY)
                            MonsterPacket.spawnMonster(All.Client, this.Monster[i], 0, 0, 0, 0);
                    }
                }
            });
            tmr.Execute();

            Delay tmr2 = new Delay(10000, true, () =>
            {
                //if (this.GetMapCharactersTotal() < 1)
                //{
                //    tmr2.Stop();
                //    return;
                //}
                for (int i = 0; i < j; i++)
                {
                    if (this.Monster[i].IsAlive == false)
                    {
                        this.Monster[i].HP = MobFactory.MonsterMaxHP(this.Monster[i].Level);
                        foreach (Character All in this.Characters)
                        {
                            if (All.MapX == this.MapX && All.MapY == this.MapY)
                                MonsterPacket.regenrMonster(All.Client, this.Monster[i]);
                        }
                        this.Monster[i].IsAlive = true;
                        this.Monster[i].State = 1;
                        foreach (Character All in this.Characters)
                        {
                            if (All.MapX == this.MapX && All.MapY == this.MapY)
                                MonsterPacket.spawnMonster(All.Client, this.Monster[i], 0, 0, 0, 0);
                        }
                    }
                }
            });
            tmr2.Execute();
        }

        public Monster UpdatePosition(Monster monster, int Dest)
        {
            int Direction = 1;
            if (monster.Direction == 0xFF)
                Direction = -1;

            sbyte PexInf;
            for (int i = Dest; i > 0; i--)
            {
                if (monster.PositionX <= 25 || monster.PositionX >= this.GetMapWidth() - 25)
                {
                    Direction = Direction * (-1);
                    //monster.Direction = Direction;
                    monster.PositionX = monster.PositionX + Direction;
                    break;
                }
                //Strat Walking in Facing

                //If We Get Cell -1
                //Get Cell Data IF Cell Data !4(Wall) -> Fix Y Pos Try Look UP For Cell, Not Found Try Look Down, Not Found Reverc Facing

                sbyte Curr = this.GetMapPexel(monster.PositionX, monster.PositionY);
                monster.PositionX = monster.PositionX + Direction;
                sbyte Next = this.GetMapPexel(monster.PositionX, monster.PositionY);

                if (Next == -1)
                {
                    PexInf = this.GetPexInfo(monster.PositionX, monster.PositionY);
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
                    sbyte Next_ = this.GetMapPexel(monster.PositionX, monster.PositionY);
                    //It Need Be In Below Cell
                    if (Next_ == -1 && Curr == 0x1F)
                    {
                        monster.PositionY = (monster.PositionY / 32);
                        monster.PositionY += 1;
                        monster.PositionY *= 32;
                        //Pos.y = (int)((((float)Pos.y/32)-0.01)*32);
                        sbyte Next__ = this.GetMapPexel(monster.PositionX, monster.PositionY);
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
            sbyte Curr_ = this.GetMapPexel(monster.PositionX, monster.PositionY);
            if (Curr_ != 0)
            {
                monster.PositionY = (monster.PositionY / 32) * 32;
                monster.PositionY += Curr_;
                monster.PositionY = (int)((((float)monster.PositionY / 32) - 0.01) * 32);
                sbyte Next = this.GetMapPexel(monster.PositionX, monster.PositionY);
            }

            if (Direction == 1)
                monster.Direction = 0x1;
            else
                monster.Direction = 0xFF;

            return monster;
        }
    }
}
