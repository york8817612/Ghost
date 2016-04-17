using Server.Common.Data;
using System.Collections;
using System.Collections.Generic;

namespace Server.Characters
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
