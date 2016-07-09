using Server.Common.Threading;
using System.Collections.Generic;

namespace Server.Ghost
{
    public class Monster
    {
        public int OriginalID { get; set; }
        public int MonsterID { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int MP { get; set; }
        public int Exp { get; set; }
        public float Speed { get; set; }
        public int Direction { get; set; }
        public byte MoveType { get; set; }
        public byte AttackType { get; set; }
        public int Attack1 { get; set; }
        public int Attack2 { get; set; }
        public int CrashAttack { get; set; }
        public int Defense { get; set; }
        public byte State { get; set; }
        public byte Effect { get; set; }
        public byte AddEffect { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public bool IsAlive { get; set; }

        public List<Drop> Drops { get; set; }

        public Delay tmr1 { get; set; }
        public Delay tmr2 { get; set; }
        public Delay tmr3 { get; set; }

        /* Speed
        00 00 00 00 // Stop
        00 00 C0 3F // 速度 1.5
        66 66 26 40 // 速度 2.6
        33 33 33 40 // 速度 2.8
        00 00 40 40 // 速度 3
        00 00 E0 40 // 速度 7
        00 00 F0 40 // 速度 7.5
        00 00 00 41 // 速度 8
        00 00 08 41 // 速度 8.5
        00 00 10 41 // 速度 9
        */

        /* State
        06 // 煞
        */

        public Monster(int OriginalID, int MonsterID, int Level, int HP, int MaxHP, int MP, int Exp, float Speed, int Driection, byte MoveType, byte AttackType, int Attack1, int Attack2, int CrashAttack, int Defense, byte State, byte Effect, byte AddEffect, int PositionX, int PositionY, bool IsAlive)
        {
            this.OriginalID = OriginalID;
            this.MonsterID = MonsterID;
            this.Level = Level;
            this.HP = HP;
            this.MaxHP = MaxHP;
            this.MP = MP;
            this.Exp = Exp;
            this.Speed = Speed;
            this.Direction = Driection;
            this.MoveType = MoveType;
            this.AttackType = AttackType;
            this.Attack1 = Attack1;
            this.Attack2 = Attack2;
            this.CrashAttack = CrashAttack;
            this.Defense = Defense;
            this.State = State;
            this.Effect = Effect;
            this.AddEffect = AddEffect;
            this.PositionX = PositionX;
            this.PositionY = PositionY;
            this.IsAlive = IsAlive;
            this.Drops = new List<Drop>();
        }
    }
}
