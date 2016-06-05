using Server.Common.Constants;
using Server.Common.Data;
using Server.Common.IO;
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
            Item item = this.Items.Find(i => (i.type == type && i.slot == slot));
            this.Items.Remove(item);
            item.Delete();
        }

        public void Remove(InventoryType.ItemType type, byte slot)
        {
            Item item = this.Items.Find(i => (i.type == (byte)type && i.slot == slot));
            this.Items.Remove(item);
            item.Delete();
        }

        public List<Item> getItems()
        {
            return this.Items;
        }

        public Item GetItem(byte type, byte slot)
        {
            Item item = this.Items.Find(i => (i.type == type && i.slot == slot));
            return item;
        }

        public int GetItemID(InventoryType.ItemType type, byte slot)
        {
            Item item = this.Items.Find(i => (i.type == (byte)type && i.slot == slot));
            if (item == null)
                return 0;
            return item.ItemID;
        }

        public int GetItemQuantity(InventoryType.ItemType type, byte slot)
        {
            Item item = this.Items.Find(i => (i.type == (byte)type && i.slot == slot));
            if (item == null)
                return 0;
            return item.Quantity;
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
                if (item.type == (byte)type)
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
                    if (item.type == (byte)type && item.slot == slot)
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
