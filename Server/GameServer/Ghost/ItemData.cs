namespace Server.Ghost
{
    public class ItemData
    {
        public readonly int ItemID;
        public readonly string ItemName;
        public readonly byte Job;
        public readonly byte Level;
        public readonly short Attack;
        public readonly short MagicAttack;
        public readonly short AttackRange;
        public readonly short Defense;
        public readonly byte Speed;
        public readonly int Hp;
        public readonly int Mp;
        public readonly int Price;

        // 消耗品
        public ItemData(int ItemID, string ItemName, int Hp, int Mp, int Price)
        {
            this.ItemID = ItemID;
            this.ItemName = ItemName;
            this.Job = 0xFF;
            this.Level = 0xFF;
            this.Attack = -1;
            this.AttackRange = -1;
            this.Defense = -1;
            this.Speed = 0;
            this.Hp = Hp;
            this.Mp = Mp;
            this.Price = Price;
        }

        // 其他裝備
        public ItemData(int ItemID, string ItemName, byte Job, byte Level, short Defense, int Price)
        {
            this.ItemID = ItemID;
            this.ItemName = ItemName;
            this.Job = Job;
            this.Level = Level;
            this.Attack = -1;
            this.AttackRange = -1;
            this.Defense = Defense;
            this.Speed = 0;
            this.Hp = -1;
            this.Mp = -1;
            this.Price = Price;
        }

        // 武器
        public ItemData(int ItemID, string ItemName, byte Job, byte Level, short Attack, short MagicAttack, short AttackRange, byte Speed, int Price)
        {
            this.ItemID = ItemID;
            this.ItemName = ItemName;
            this.Job = Job;
            this.Level = Level;
            this.Attack = Attack;
            this.MagicAttack = MagicAttack;
            this.AttackRange = AttackRange;
            this.Defense = -1;
            this.Speed = Speed;
            this.Hp = -1;
            this.Mp = -1;
            this.Price = Price;
        }

        // 其他
        public ItemData(int ItemID, string ItemName, int Price)
        {
            this.ItemID = ItemID;
            this.ItemName = ItemName;
            this.Job = 0xFF;
            this.Level = 0xFF;
            this.Attack = -1;
            this.AttackRange = -1;
            this.Defense = -1;
            this.Speed = 0;
            this.Hp = -1;
            this.Mp = -1;
            this.Price = Price;
        }

        public ItemData(int ItemID, string ItemName, byte Job, byte Level, short Attack, short MagicAttack, short AttackRange, byte Speed, int Hp, int Mp, int Price)
        {
            this.ItemID = ItemID;
            this.ItemName = ItemName;
            this.Job = Job;
            this.Level = Level;
            this.Attack = Attack;
            this.MagicAttack = MagicAttack;
            this.AttackRange = AttackRange;
            this.Defense = -1;
            this.Speed = Speed;
            this.Hp = Hp;
            this.Mp = Mp;
            this.Price = Price;
        }
    }
}
