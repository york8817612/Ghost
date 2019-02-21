using Server.Ghost.Characters;
using Server.Common.Data;
using System;
using Server.Ghost.Provider;

namespace Server.Ghost
{
    public class Item
    {
        public CharacterItems Parent { get; set; }

        public int ID { get; private set; }
        public int ItemID { get; private set; }
        private short maxPerStack;
        private short quantity;
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
        public byte Type { get; set; }
        public byte Slot { get; set; }

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

        public short MaxPerStack
        {
            get
            {
                if (maxPerStack == 0)
                {
                    maxPerStack = 100;
                }
                return maxPerStack;
            }
            set
            {
                maxPerStack = value;
            }
        }

        public short Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value > this.MaxPerStack)
                {
                    throw new ArgumentException("Quantity too high.");
                }
                else
                {
                    quantity = value;
                }
            }
        }

        public Item(int itemID, byte type, byte slot, short quantity = 1)
        {
            this.ItemID = itemID;
            switch (type)
            {
                case 0:
                case 1:
                case 2:
                case 5:
                    this.MaxPerStack = 1;
                    break;
                case 3:
                case 4:
                case 6:
                    this.MaxPerStack = 100;
                    break;
                case 0x63:
                    this.MaxPerStack = Int16.MaxValue;
                    break;
                default:
                    this.MaxPerStack = 1;
                    break;
            }
            this.Quantity = quantity;
            this.Spirit = 0;
            // 強化系統
            this.Level1 = 0;
            this.Level2 = 0;
            this.Level3 = 0;
            this.Level4 = 0;
            this.Level5 = 0;
            this.Level6 = 0;
            this.Level7 = 0;
            this.Level8 = 0;
            this.Level9 = 0;
            this.Level10 = 0;
            this.Fusion = 0;
            //
            this.IsLocked = 0;
            this.Icon = 0;
            this.Term = -1;
            this.Type = type;
            this.Slot = slot;
        }

        public Item(int itemID, bool IsLocked, byte Icon, int Term, byte type, byte slot, short quantity = 1)
        {
            this.ItemID = itemID;
            switch (type)
            {
                case 0:
                case 1:
                case 2:
                case 5:
                    this.MaxPerStack = 1;
                    break;
                case 3:
                case 4:
                case 6:
                    this.MaxPerStack = 100;
                    break;
                case 0x63:
                    this.MaxPerStack = Int16.MaxValue;
                    break;
                default:
                    this.MaxPerStack = 1;
                    break;
            }
            this.Quantity = quantity;
            this.Spirit = 0;
            // 強化系統
            this.Level1 = 0;
            this.Level2 = 0;
            this.Level3 = 0;
            this.Level4 = 0;
            this.Level5 = 0;
            this.Level6 = 0;
            this.Level7 = 0;
            this.Level8 = 0;
            this.Level9 = 0;
            this.Level10 = 0;
            this.Fusion = 0;
            //
            this.IsLocked = IsLocked ? (byte)1 : (byte)0;
            this.Icon = Icon;
            this.Term = Term;
            this.Type = type;
            this.Slot = slot;
        }

        public Item(int ItemID, short Quantity, int Spirit, byte Level1, byte Level2, byte Level3, byte Level4, byte Level5, byte Level6, byte Level7, byte Level8, byte Level9, byte Level10, byte Fusion, byte IsLocked, int Icon, int Term, byte Type, byte Slot)
        {
            this.ItemID = ItemID;
            switch (Type)
            {
                case 0:
                case 1:
                case 2:
                case 5:
                    this.MaxPerStack = 1;
                    break;
                case 3:
                case 4:
                case 6:
                    this.MaxPerStack = 100;
                    break;
                case 0x63:
                    this.MaxPerStack = Int16.MaxValue;
                    break;
                default:
                    this.MaxPerStack = 1;
                    break;
            }
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
        }

        public Item(dynamic datum)
        {
            this.ID = datum.id;
            this.Assigned = true;

            this.ItemID = datum.itemId;
            switch ((byte)(datum.type))
            {
                case 0:
                case 1:
                case 2:
                case 5:
                    this.MaxPerStack = 1;
                    break;
                case 3:
                case 4:
                case 6:
                    this.MaxPerStack = 100;
                    break;
                default:
                    this.MaxPerStack = 1;
                    break;
            }
            this.Quantity = (short)datum.quantity;
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
            this.Type = (byte)datum.type;
            this.Slot = (byte)datum.slot;
        }

        public void Save()
        {
            dynamic datum = new Datum("Items");

            datum.cid = this.Character.ID;
            datum.itemId = this.ItemID;
            datum.quantity = this.Quantity;

            ItemData Data = ItemFactory.GetItemData(this.ItemID);

            if (this.Spirit > Data.Spirit)
                this.Spirit = Data.Spirit;

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

            if (this.Assigned)
            {
                datum.Update("id = '{0}'", this.ID);
            }
            else
            {
                datum.Insert();

                this.ID = Database.Fetch("Items", "id", "cid = '{0}' && itemId = '{1}' && quantity = '{2}' && spirit = '{3}' && level1 = '{4}' && level2 = '{5}' && level3 = '{6}' && level4 = '{7}' && level5 = '{8}' && level6 = '{9}' && level7 = '{10}' && level8 = '{11}' && level9 = '{12}' && level10 = '{13}' && fusion = '{14}' && isLocked = '{15}' && icon = '{16}' && term = '{17}' && type = '{18}' && slot = '{19}'", this.Character.ID, this.ItemID, this.quantity, this.Spirit, this.Level1, this.Level2, this.Level3, this.Level4, this.Level5, this.Level6, this.Level7, this.Level8, this.Level9, this.Level10, this.Fusion, this.IsLocked, this.Icon, this.Term, this.Type, this.Slot);

                this.Assigned = true;
            }
        }

        public void Delete()
        {
            Database.Delete("Items", "id = '{0}'", this.ID);

            this.Assigned = false;
        }
    }
}
