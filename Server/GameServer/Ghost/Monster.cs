namespace Server.Ghost
{
    public class Monster
    {
        public int OriginalID { get; set; }
        public int MonsterID { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int MoveState { get; set; }
        public int Direction { get; set; }
        public byte State { get; set; }
        public byte Effect { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public Monster(int OriginalID, int MonsterID, int Level, int HP, int MP, int MoveState, int Driection, byte State, byte Effect, int PositionX, int PositionY)
        {
            this.OriginalID = OriginalID;
            this.MonsterID = MonsterID;
            this.Level = Level;
            this.HP = HP;
            this.MP = MP;
            this.MoveState = MoveState;
            this.Direction = Driection;
            this.State = State;
            this.Effect = Effect;
            this.PositionX = PositionX;
            this.PositionY = PositionY;
        }
    }
}
