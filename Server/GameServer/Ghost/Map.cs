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

            Delay tmr = null;
            tmr = new Delay(1000, true, () =>
            {
                if (this.GetMapCharactersTotal() < 1)
                {
                    tmr.Cancel();
                    this.IsControling = false;
                    return;
                }
                for (int i = 0; i < j; i++)
                {
                    if (this.Monster[i].State == 3 || this.Monster[i].State == 7 || this.Monster[i].State == 9 || this.Monster[i].MoveType == 3)
                        continue;

                    int Direction = this.Monster[i].Direction;

                    Monster Monster = UpdatePosition(this.Monster[i], (int)(40 * this.Monster[i].Speed));

                    foreach (Character All in this.Characters)
                    {
                        if (this.Monster[i].State != 9 && Direction != Monster.Direction && All.MapX == this.MapX && All.MapY == this.MapY)
                            MonsterPacket.spawnMonster(All.Client, this.Monster[i], 0, 0, 0, 0);
                    }
                }
            });
            tmr.Execute();

            Delay tmr2 = null;
            tmr2 = new Delay(20000, true, () =>
            {
                if (this.GetMapCharactersTotal() < 1)
                {
                    tmr2.Cancel();
                    this.IsControling = false;
                    return;
                }
                for (int i = 0; i < j; i++)
                {
                    if (this.Monster[i].IsAlive == false)
                    {
                        this.Monster[i].HP = MobFactory.MonsterMaxHP(this.Monster[i].Level);
                        this.Monster[i].IsAlive = true;
                        this.Monster[i].State = (this.Monster[i].MoveType == 0 ? (byte)0 : (byte)1);
                        foreach (Character All in this.Characters)
                        {
                            if (All.MapX == this.MapX && All.MapY == this.MapY)
                            {
                                MonsterPacket.regenrMonster(All.Client, this.Monster[i]);
                                MonsterPacket.spawnMonster(All.Client, this.Monster[i], 0, 0, 0, 0);
                            }
                        }
                    }
                }
            });
            tmr2.Execute();
        }

        public Monster UpdatePosition(Monster Monster, int Dest)
        {
            int Direction = (Monster.Direction == 0xFF ? -1 : 1);

            //// 修正怪物座標
            //sbyte NextPosition = this.GetMapPexel(Monster.PositionX, Monster.PositionY);
            //while (NextPosition == -1)
            //{
            //    Monster.PositionY = (Monster.PositionY / 32);
            //    Monster.PositionY += 1;
            //    Monster.PositionY *= 32;
            //    sbyte Next = this.GetMapPexel(Monster.PositionX, Monster.PositionY);
            //    if (Next != -1)
            //        break;
            //}

            // 怪物開始移動
            sbyte PexInf;
            for (int i = Dest; i > 0; i--)
            {
                if (Monster.PositionX <= 25 || Monster.PositionX >= this.GetMapWidth() - 25)
                {   // [地圖座標(PositionX) <= 25 || 地圖座標(PositionX) >= 地圖寬度 - 25] 
                    Direction = Direction * (-1);
                    Monster.PositionX = Monster.PositionX + Direction;
                    break;
                }

                // Strat Walking in Facing

                // If We Get Cell -1
                // Get Cell Data IF Cell Data !4(Wall) -> Fix Y Pos Try Look UP For Cell, Not Found Try Look Down, Not Found Reverc Facing

                sbyte Curr = this.GetMapPexel(Monster.PositionX, Monster.PositionY);
                Monster.PositionX = Monster.PositionX + Direction;
                sbyte Next = this.GetMapPexel(Monster.PositionX, Monster.PositionY);

                if (Next == -1)
                {
                    PexInf = this.GetPexInfo(Monster.PositionX, Monster.PositionY);
                    if (PexInf == 4)
                    {   // [牆壁]
                        Direction = Direction * (-1);
                        Monster.PositionX = Monster.PositionX + Direction;
                        continue;
                    }
                    Monster.PositionY = (Monster.PositionY / 32) * 32;
                    Monster.PositionY += Curr;
                    Monster.PositionY = (int)((((float)Monster.PositionY / 32) - 0.01) * 32);
                    Next = this.GetMapPexel(Monster.PositionX, Monster.PositionY);
                    // It Need Be In Below Cell
                    if (Next == -1 && Curr == 0x1F)
                    {
                        Monster.PositionY = (Monster.PositionY / 32);
                        Monster.PositionY += 1;
                        Monster.PositionY *= 32;
                        Next = this.GetMapPexel(Monster.PositionX, Monster.PositionY);
                        if (Next != -1)
                            continue;
                    }
                    if (Next == -1)
                    {
                        Direction = Direction * (-1);
                        Monster.PositionX = Monster.PositionX + Direction;
                        break;
                    }
                    continue;
                }
            }

            // Before Return Val Fix the Y	
            sbyte Current = this.GetMapPexel(Monster.PositionX, Monster.PositionY);
            if (Current != 0)
            {
                Monster.PositionY = (Monster.PositionY / 32) * 32;
                Monster.PositionY += Current;
                Monster.PositionY = (int)((((float)Monster.PositionY / 32) - 0.01) * 32);
                sbyte Next = this.GetMapPexel(Monster.PositionX, Monster.PositionY);
            }

            Monster.Direction = (Direction != 1 ? 0xFF : 0x01);

            return Monster;
        }
    }
}
