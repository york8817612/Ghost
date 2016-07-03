namespace Server.Ghost
{
    public class ItemData
    {
        public readonly int ItemID;
        public readonly string ItemName;
        public readonly byte Job;
        public readonly byte Level;
        public readonly short Str = -1;
        public readonly short Dex = -1;
        public readonly short Vit = -1;
        public readonly short Int = -1;
        public readonly short Attack = -1;
        public readonly short Magic = -1;
        public readonly short Avoid = -1;
        public readonly short Defense = -1;
        public readonly short Hp = -1;
        public readonly short Mp = -1;
        public readonly short AttackRange = -1;
        public readonly byte Speed;
        public readonly byte Refining;
        public readonly byte Fusion;
        public readonly int Type = -1;
        public readonly int Recover = -1;
        public readonly int Spirit = -1;
        public readonly int Price;

        // 消耗品
        public ItemData(int ItemID, string ItemName, int Type, int Recover, int Price)
        {
            this.ItemID = ItemID;
            this.ItemName = ItemName;
            this.Job = 0xFF;
            this.Level = 0xFF;
            this.Attack = -1;
            this.AttackRange = -1;
            this.Defense = -1;
            this.Speed = 0;
            this.Type = Type;
            this.Recover = Recover;
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
        public ItemData(int ItemID, string ItemName, byte Job, byte Level, short Attack, short MagicAttack, short AttackRange, byte Speed, int Price, byte Fusion)
        {
            this.ItemID = ItemID;
            this.ItemName = ItemName;
            this.Job = Job;
            this.Level = Level;
            this.Attack = Attack;
            this.Magic = MagicAttack;
            this.AttackRange = AttackRange;
            this.Defense = -1;
            this.Speed = Speed;
            this.Hp = -1;
            this.Mp = -1;
            this.Price = Price;
            this.Fusion = Fusion;
        }

        // 衣服
        public ItemData(int ItemID, string ItemName, byte Job, byte Level, short Defense, int Price, byte Fusion)
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
            this.Fusion = Fusion;
        }

        // 服裝
        public ItemData(int ItemID, string ItemName, byte Job, byte Level, short Defense, short Str, short Dex, short Vit, short Int, int Price, byte Fusion)
        {
            this.ItemID = ItemID;
            this.ItemName = ItemName;
            this.Job = Job;
            this.Level = Level;
            this.Defense = Defense;
            this.Str = Str;
            this.Dex = Dex;
            this.Vit = Vit;
            this.Int = Int;
            this.Price = Price;
            this.Fusion = Fusion;
        }

        // 帽子
        public ItemData(int ItemID, string ItemName, short Str, short Dex, short Vit, short Int, short Hp, short Mp, int Price)
        {
            this.ItemID = ItemID;
            this.ItemName = ItemName;
            this.Str = Str;
            this.Dex = Dex;
            this.Vit = Vit;
            this.Int = Int;
            this.Hp = Hp;
            this.Mp = Mp;
            this.Price = Price;
        }

        // 戒指
        public ItemData(int ItemID, string ItemName, byte Job, byte Level, short Str, short Dex, short Vit, short Int, short MagicAttack, short Avoid, short Attack, short Defense, short Hp, short Mp, byte Refining, int Price)
        {
            this.ItemID = ItemID;
            this.ItemName = ItemName;
            this.Job = Job;
            this.Level = Level;
            this.Str = Str;
            this.Dex = Dex;
            this.Vit = Vit;
            this.Int = Int;
            this.Magic = MagicAttack;
            this.Avoid = Avoid;
            this.Attack = Attack;
            this.AttackRange = -1;
            this.Defense = Defense;
            this.Speed = 0;
            this.Hp = Hp;
            this.Mp = Mp;
            this.Refining = Refining;
            this.Price = Price;
        }

        // 項鍊
        public ItemData(int ItemID, string ItemName, byte Job, byte Level, short Defense, short Hp, short Mp, int Price)
        {
            this.ItemID = ItemID;
            this.ItemName = ItemName;
            this.Job = Job;
            this.Level = Level;
            this.Attack = -1;
            this.AttackRange = -1;
            this.Defense = Defense;
            this.Speed = 0;
            this.Hp = Hp;
            this.Mp = Mp;
            this.Price = Price;
        }

        // 披風
        public ItemData(int ItemID, string ItemName, byte Job, byte Level, short Str, short Dex, short Vit, short Int, int Price)
        {
            this.ItemID = ItemID;
            this.ItemName = ItemName;
            this.Job = Job;
            this.Level = Level;
            this.Str = Str;
            this.Dex = Dex;
            this.Vit = Vit;
            this.Int = Int;
            this.Price = Price;
        }

        // 封印箱
        public ItemData(int ItemID, string ItemName, int Spirit, int Price)
        {
            this.ItemID = ItemID;
            this.ItemName = ItemName;
            this.Spirit = Spirit;
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

        public ItemData(int ItemID, string ItemName, byte Job, byte Level, short Attack, short MagicAttack, short AttackRange, byte Speed, short Hp, short Mp, int Price)
        {
            this.ItemID = ItemID;
            this.ItemName = ItemName;
            this.Job = Job;
            this.Level = Level;
            this.Attack = Attack;
            this.Magic = MagicAttack;
            this.AttackRange = AttackRange;
            this.Defense = -1;
            this.Speed = Speed;
            this.Hp = Hp;
            this.Mp = Mp;
            this.Price = Price;
        }
    }
}
