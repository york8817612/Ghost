using Server.Common.Constants;
using Server.Common.Data;
using System.Collections;
using System.Collections.Generic;

namespace Server.Ghost.Characters
{
    public class CharacterItems : IEnumerable<Item>
    {
        public Character Parent { get; private set; }

        private List<Item> Items { get; set; }

        public CharacterItems(Character parent)
            : base()
        {
            this.Parent = parent;

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

        public void RemoveItem(byte type, byte slot)
        {
            Item item = this.Items.Find(i => (i.type == type && i.slot == slot));
            this.Items.Remove(item);
            item.Delete();
        }

        public void RemoveItem(InventoryType.ItemType type, byte slot)
        {
            Item item = this.Items.Find(i => (i.type == (byte)type && i.slot == slot));
            this.Items.Remove(item);
            item.Delete();
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
