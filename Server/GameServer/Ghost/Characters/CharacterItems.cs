using Server.Common.Constants;
using Server.Common.Data;
using Server.Ghost.Provider;
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

            ItemData Data = ItemFactory.GetItemData(Item.ItemID);

            if (Data == null)
                return 0;

            if (Item.Spirit > Data.Spirit)
                return Data.Spirit;

            return Item.Spirit;
        }

        public byte Level1(InventoryType.ItemType Type, byte Slot)
        {
            Item Item = this.Items.Find(i => (i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Level1;
        }

        public byte Level2(InventoryType.ItemType Type, byte Slot)
        {
            Item Item = this.Items.Find(i => (i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Level2;
        }

        public byte Level3(InventoryType.ItemType Type, byte Slot)
        {
            Item Item = this.Items.Find(i => (i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Level3;
        }

        public byte Level4(InventoryType.ItemType Type, byte Slot)
        {
            Item Item = this.Items.Find(i => (i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Level4;
        }

        public byte Level5(InventoryType.ItemType Type, byte Slot)
        {
            Item Item = this.Items.Find(i => (i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Level5;
        }

        public byte Level6(InventoryType.ItemType Type, byte Slot)
        {
            Item Item = this.Items.Find(i => (i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Level6;
        }

        public byte Level7(InventoryType.ItemType Type, byte Slot)
        {
            Item Item = this.Items.Find(i => (i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Level7;
        }

        public byte Level8(InventoryType.ItemType Type, byte Slot)
        {
            Item Item = this.Items.Find(i => (i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Level8;
        }

        public byte Level9(InventoryType.ItemType Type, byte Slot)
        {
            Item Item = this.Items.Find(i => (i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Level9;
        }

        public byte Level10(InventoryType.ItemType Type, byte Slot)
        {
            Item Item = this.Items.Find(i => (i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Level10;
        }

        public byte Fusion(InventoryType.ItemType Type, byte Slot)
        {
            Item Item = this.Items.Find(i => (i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Fusion;
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
