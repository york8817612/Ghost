using Server.Common.Data;
using Server.Ghost.Characters;

namespace Server.Ghost
{
    public class Storage
    {
        public CharacterStorages Parent { get; set; }

        public int ID { get; private set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public int Spirit { get; set; }
        // 強化系統
        public byte Level1 { get; set; }
        public byte Level2 { get; set; }
        public byte Level3 { get; set; }
        public byte Level4 { get; set; }
        public byte Level5 { get; set; }
        public byte Level6 { get; set; }
        public byte Level7 { get; set; }
        public byte Level8 { get; set; }
        public byte Level9 { get; set; }
        public byte Level10 { get; set; }
        public byte Fusion { get; set; }
        //
        public byte IsLocked { get; set; }
        public int Icon { get; set; }
        public int Term { get; set; }
        public int Type { get; set; }
        public int Slot { get; set; }
        public int Money { get; set; }

        public bool Assigned { get; set; }


        public Character Character
        {
            get
            {
                try
                {
                    return this.Parent.Parent;
                }
                catch
                {
                    return null;
                }
            }
        }

        public Storage(dynamic datum)
        {
            this.ID = datum.id;
            this.Assigned = true;

            this.ItemID = datum.itemID;
            this.Quantity = datum.quantity;
            this.Spirit = datum.spirit;
            // 強化系統
            this.Level1 = (byte)datum.level1;
            this.Level2 = (byte)datum.level2;
            this.Level3 = (byte)datum.level3;
            this.Level4 = (byte)datum.level4;
            this.Level5 = (byte)datum.level5;
            this.Level6 = (byte)datum.level6;
            this.Level7 = (byte)datum.level7;
            this.Level8 = (byte)datum.level8;
            this.Level9 = (byte)datum.level9;
            this.Level10 = (byte)datum.level10;
            this.Fusion = (byte)datum.fusion;
            //
            this.IsLocked = (byte)datum.isLocked;
            this.Icon = datum.icon;
            this.Term = datum.term;
            this.Type = datum.type;
            this.Slot = datum.slot;
            this.Money = datum.money;
        }

        public Storage(int ItemID, int Quantity, int Type, int Slot, int Money)
        {
            this.ItemID = ItemID;
            this.Quantity = Quantity;
            this.Type = Type;
            this.Slot = Slot;
            this.Money = Money;
        }

        public Storage(int ItemID, int Quantity, int Spirit, byte Level1, byte Level2, byte Level3, byte Level4, byte Level5, byte Level6, byte Level7, byte Level8, byte Level9, byte Level10, byte Fusion, byte IsLocked, int Icon, int Term, int Type, int Slot, int Money)
        {
            this.ItemID = ItemID;
            this.Quantity = Quantity;
            this.Spirit = Spirit;
            // 強化系統
            this.Level1 = Level1;
            this.Level2 = Level2;
            this.Level3 = Level3;
            this.Level4 = Level4;
            this.Level5 = Level5;
            this.Level6 = Level6;
            this.Level7 = Level7;
            this.Level8 = Level8;
            this.Level9 = Level9;
            this.Level10 = Level10;
            this.Fusion = Fusion;
            //
            this.IsLocked = IsLocked;
            this.Icon = Icon;
            this.Term = Term;
            this.Type = Type;
            this.Slot = Slot;
            this.Money = Money;
        }

        public void Save()
        {
            dynamic datum = new Datum("Storages");

            datum.cid = this.Character.ID;
            datum.itemID = this.ItemID;
            datum.quantity = this.Quantity;
            datum.spirit = this.Spirit;
            // 強化系統
            datum.level1 = this.Level1;
            datum.level2 = this.Level2;
            datum.level3 = this.Level3;
            datum.level4 = this.Level4;
            datum.level5 = this.Level5;
            datum.level6 = this.Level6;
            datum.level7 = this.Level7;
            datum.level8 = this.Level8;
            datum.level9 = this.Level9;
            datum.level10 = this.Level10;
            datum.fusion = this.Fusion;
            //
            datum.isLocked = this.IsLocked;
            datum.icon = this.Icon;
            datum.term = this.Term;
            datum.type = this.Type;
            datum.slot = this.Slot;
            datum.money = this.Money;

            if (this.Assigned)
            {
                datum.Update("id = '{0}'", this.ID);
            }
            else
            {
                datum.Insert();

                this.ID = Database.Fetch("Storages", "id", "cid = '{0}' && itemID = '{1}' && quantity = '{2}' && spirit = '{3}' && level1 = '{4}' && level2 = '{5}' && level3 = '{6}' && level4 = '{7}' && level5 = '{8}' && level6 = '{9}' && level7 = '{10}' && level8 = '{11}' && level9 = '{12}' && level10 = '{13}' && fusion = '{14}' && isLocked = '{15}' && icon = '{16}' && term = '{17}' && type = '{18}' && slot = '{19}' && money = '{20}'", this.Character.ID, this.ItemID, this.Quantity, this.Spirit, this.Level1, this.Level2, this.Level3, this.Level4, this.Level5, this.Level6, this.Level7, this.Level8, this.Level9, this.Level10, this.Fusion, this.IsLocked, this.Icon, this.Term, this.Type, this.Slot, this.Money);

                this.Assigned = true;
            }
        }

        public void Delete()
        {
            Database.Delete("Storages", "id = '{0}'", this.ID);

            this.Assigned = false;
        }
    }
}
