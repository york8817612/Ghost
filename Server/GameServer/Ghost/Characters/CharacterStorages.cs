using Server.Common.Data;
using Server.Ghost.Characters;
using System.Collections;
using System.Collections.Generic;

namespace Server.Ghost
{
    public class CharacterStorages : IEnumerable<Storage>
    {
        public Character Parent { get; private set; }

        private List<Storage> Storages { get; set; }


        public CharacterStorages(Character parent)
            : base()
        {
            this.Parent = parent;

            this.Storages = new List<Storage>();
        }

        public void Load()
        {
            foreach (dynamic datum in new Datums("Storages").Populate("cid = '{0}'", this.Parent.ID))
            {
                this.Add(new Storage(datum));
            }
        }

        public void Save()
        {
            foreach (Storage storage in this)
            {
                storage.Save();
            }
        }

        public void Delete()
        {
            foreach (Storage storage in this)
            {
                storage.Delete();
            }
        }

        public void Add(Storage storage)
        {
            storage.Parent = this;
            this.Storages.Add(storage);
        }

        public void Remove(byte type, byte slot)
        {
            Storage item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == type && i.Slot == slot));
            this.Storages.Remove(item);
            item.Delete();
        }

        public void Remove(byte type, byte slot, int Quantity)
        {
            Storage item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == type && i.Slot == slot));
            int SourceQuantity = item.Quantity;
            item.Quantity = (short)Quantity;
            this.Remove(type, slot);
            int AddQuantity = SourceQuantity - item.Quantity;
            this.Add(new Storage(item.ItemID, AddQuantity, item.Type, item.Slot, 0));
        }

        public Storage GetItem(byte type, byte slot)
        {
            Storage item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == type && i.Slot == slot));
            return item;
        }

        public int GetItemID(byte type, byte slot)
        {
            Storage Storage = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == type && i.Slot == slot));
            if (Storage == null)
                return 0;
            return Storage.ItemID;
        }

        public int GetItemQuantity(byte type, byte slot)
        {
            Storage Storage = this.Storages.Find(i => (i.Type == type && i.Slot == slot));
            if (Storage == null)
                return 0;
            return Storage.Quantity;
        }

        public List<Storage> getStorages()
        {
            return this.Storages;
        }

        public IEnumerator<Storage> GetEnumerator()
        {
            return this.Storages.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this.Storages).GetEnumerator();
        }
    }
}
