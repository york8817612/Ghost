using Server.Ghost.Characters;
using Server.Common.Data;
using System;

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
            this.IsLocked = IsLocked ? (byte)1 : (byte)0;
            this.Icon = Icon;
            this.Term = Term;
            this.Type = type;
            this.Slot = slot;
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
            datum.spirit = this.Spirit;
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

                this.ID = Database.Fetch("Items", "id", "cid = '{0}' && itemId = '{1}' && quantity = '{2}' && spirit = '{3}' && isLocked = '{4}' && icon = '{5}' && term = '{6}' && type = '{7}' && slot = '{8}'", this.Character.ID, this.ItemID, this.quantity, this.Spirit, this.IsLocked, this.Icon, this.Term, this.Type, this.Slot);

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
