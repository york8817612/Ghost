namespace Server.Ghost
{
    public class Monster
    {
        public int OriginalID { get; set; }
        public int MonsterID { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Exp { get; set; }
        public float Speed { get; set; }
        public int Direction { get; set; }
        public byte State { get; set; }
        public byte Effect { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

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

        public Monster(int OriginalID, int MonsterID, int Level, int HP, int MP, int Exp, float Speed, int Driection, byte State, byte Effect, int PositionX, int PositionY)
        {
            this.OriginalID = OriginalID;
            this.MonsterID = MonsterID;
            this.Level = Level;
            this.HP = HP;
            this.MP = MP;
            this.Exp = Exp;
            this.Speed = Speed;
            this.Direction = Driection;
            this.State = State;
            this.Effect = Effect;
            this.PositionX = PositionX;
            this.PositionY = PositionY;
        }
    }
}
