namespace Server.Ghost
{
    public class Monster
    {
        public int OriginalID { get; set; }
        public int MonsterID { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Speed { get; set; }
        public int Facing { get; set; }
        public byte State { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public Monster(int OriginalID, int MonsterID, int Level, int HP, int MP, int Speed, int Facing, byte State, int PositionX, int PositionY)
        {
            this.OriginalID = OriginalID;
            this.MonsterID = MonsterID;
            this.Level = Level;
            this.HP = HP;
            this.MP = MP;
            this.Speed = Speed;
            this.Facing = Facing;
            this.State = State;
            this.PositionX = PositionX;
            this.PositionY = PositionY;
        }
    }
}
