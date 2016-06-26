using Server.Common.Constants;
using Server.Common.Data;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Server.Ghost.Characters
{
    public class CharacterItems : IEnumerable<Item>
    {
        public Character Parent { get; private set; }
        public Dictionary<InventoryType.ItemType, byte> MaxSlots { get; private set; }
        private List<Item> Items { get; set; }

        public CharacterItems(Character parent)
            : base()
        {
            this.Parent = parent;

            this.MaxSlots = new Dictionary<InventoryType.ItemType, byte>(Enum.GetValues(typeof(InventoryType.ItemType)).Length);

            this.MaxSlots.Add(InventoryType.ItemType.Equip1, 24);
            this.MaxSlots.Add(InventoryType.ItemType.Equip2, 24);
            this.MaxSlots.Add(InventoryType.ItemType.Spend3, 24);
            this.MaxSlots.Add(InventoryType.ItemType.Other4, 24);
            this.MaxSlots.Add(InventoryType.ItemType.Pet5, 24);
            this.MaxSlots.Add(InventoryType.ItemType.Cash, 20);

            this.Items = new List<Item>();
        }

        public void Load()
        {
            foreach (dynamic datum in new Datums("Items").Populate("cid = '{0}'", this.Parent.ID))
            {
                this.Add(new Item(datum));
            }
        }

        public void Save()
        {
            foreach (Item item in this)
            {
                item.Save();
            }
        }

        public void Delete()
        {
            foreach (Item item in this)
            {
                item.Delete();
            }
        }

        public void Add(Item item)
        {
            if (item.Quantity > 0)
            {
                item.Parent = this;
                this.Items.Add(item);
            }
        }

        public void Remove(byte type, byte slot)
        {
            Item item = this.Items.Find(i => (i.Type == type && i.Slot == slot));
            this.Items.Remove(item);
            item.Delete();
        }

        public void Remove(InventoryType.ItemType type, byte slot)
        {
            Item item = this.Items.Find(i => (i.Type == (byte)type && i.Slot == slot));
            this.Items.Remove(item);
            item.Delete();
        }

        public void Remove(byte Type, byte Slot, int Quantity)
        {
            Item Item = this.Items.Find(i => (i.Type == Type && i.Slot == Slot));
            this.Remove(Type, Slot);
            this.Add(new Item(Item.ItemID, Type, Slot, (short)(Item.Quantity - Quantity)));
        }

        public void Remove(int ItemID)
        {
            Item item = this.Items.Find(i => (i.ItemID == ItemID));
            this.Items.Remove(item);
            item.Delete();
        }

        public List<Item> getItems()
        {
            return this.Items;
        }

        public Item getItem(byte type, byte slot)
        {
            Item item = this.Items.Find(i => (i.Type == type && i.Slot == slot));
            return item;
        }

        public int ItemID(InventoryType.ItemType type, byte slot)
        {
            Item item = this.Items.Find(i => (i.Type == (byte)type && i.Slot == slot));
            if (item == null)
                return 0;
            return item.ItemID;
        }

        public int Quantity(InventoryType.ItemType type, byte slot)
        {
            Item item = this.Items.Find(i => (i.Type == (byte)type && i.Slot == slot));
            if (item == null)
                return 0;
            return item.Quantity;
        }

        public int Spirit(InventoryType.ItemType Type, byte Slot)
        {
            Item Item = this.Items.Find(i => (i.Type == (byte)Type && i.Slot == Slot));

            if (Item == null)
                return 0;

            double Spirit = 0;

            switch (Item.ItemID)
            {
                case 8510011:
                    Spirit = (double)Item.Spirit / 100 * 100;
                    if (Spirit > 100)
                        return 100;
                    break;
                case 8510021:
                    Spirit = (double)Item.Spirit / 130 * 100;
                    if (Spirit > 130)
                        return 100;
                    break;
                case 8510031:
                    Spirit = (double)Item.Spirit / 169 * 100;
                    if (Spirit > 169)
                        return 100;
                    break;
                case 8510041:
                    Spirit = (double)Item.Spirit / 220 * 100;
                    if (Spirit > 220)
                        return 100;
                    break;
                case 8510051:
                    Spirit = (double)Item.Spirit / 286 * 100;
                    if (Spirit > 286)
                        return 100;
                    break;
                case 8510061:
                    Spirit = (double)Item.Spirit / 371 * 100;
                    if (Spirit > 371)
                        return 100;
                    break;
                case 8510071:
                    Spirit = (double)Item.Spirit / 483 * 100;
                    if (Spirit > 483)
                        return 100;
                    break;
                case 8510081:
                    Spirit = (double)Item.Spirit / 627 * 100;
                    if (Spirit > 627)
                        return 100;
                    break;
                case 8510091:
                    Spirit = (double)Item.Spirit / 816 * 100;
                    if (Spirit > 816)
                        return 100;
                    break;
                case 8510101:
                    Spirit = (double)Item.Spirit / 1060 * 100;
                    if (Spirit > 1060)
                        return 100;
                    break;
                default:
                    return 0;
            }
            return (int)Spirit;
        }

        public byte IsLocked(InventoryType.ItemType type, byte slot)
        {
            Item item = this.Items.Find(i => (i.Type == (byte)type && i.Slot == slot));
            if (item == null)
                return 0;
            return item.IsLocked;
        }

        public int Icon(InventoryType.ItemType type, byte slot)
        {
            Item item = this.Items.Find(i => (i.Type == (byte)type && i.Slot == slot));
            if (item == null)
                return 0;
            return item.Icon;
        }

        public int Term(InventoryType.ItemType type, byte slot)
        {
            Item item = this.Items.Find(i => (i.Type == (byte)type && i.Slot == slot));
            if (item == null)
                return 0;
            return item.Term;
        }

        public byte GetNextFreeSlot(InventoryType.ItemType type)
        {
            for (byte i = 0; i < this.MaxSlots[type]; i++)
            {
                if (this[type, i] == null)
                {
                    return i;
                }
            }

            throw new InventoryFullException();
        }

        public bool IsFull(InventoryType.ItemType type)
        {
            short count = 0;

            foreach (Item item in this)
            {
                if (item.Type == (byte)type)
                {
                    count++;
                }
            }

            return (count == this.MaxSlots[type]);
        }

        public Item this[InventoryType.ItemType type, byte slot]
        {
            get
            {
                foreach (Item item in this)
                {
                    if (item.Type == (byte)type && item.Slot == slot)
                    {
                        return item;
                    }
                }

                return null;
            }
        }

        public IEnumerator<Item> GetEnumerator()
        {
            return this.Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this.Items).GetEnumerator();
        }
    }
}
