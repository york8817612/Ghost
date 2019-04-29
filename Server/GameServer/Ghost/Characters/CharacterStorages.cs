using Server.Common.Constants;
using Server.Common.Data;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using System.Collections;
using System.Collections.Generic;

namespace Server.Ghost
{
    public class CharacterStorages : IEnumerable<Storage>
    {
        public Character Parent { get; private set; }

        private List<Storage> Storages { get; set; }


        public CharacterStorages(Character Parent)
            : base()
        {
            this.Parent = Parent;

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
            foreach (Storage Storage in this)
            {
                Storage.Save();
            }
        }

        public void Delete()
        {
            foreach (Storage Storage in this)
            {
                Storage.Delete();
            }
        }

        public void Add(Storage Storage)
        {
            Storage.Parent = this;
            this.Storages.Add(Storage);
        }

        public void Remove(byte Type, byte Slot)
        {
            Storage item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == Type && i.Slot == Slot));
            this.Storages.Remove(item);
            item.Delete();
        }

        public void Remove(byte Type, byte Slot, int Quantity)
        {
            Storage Item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == Type && i.Slot == Slot));
            this.Remove(Type, Slot);
            this.Add(new Storage(Item.ItemID, (Item.Quantity - Quantity), Type, Slot, 0));
        }

        public Storage GetItem(byte Type, byte Slot)
        {
            Storage Item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == Type && i.Slot == Slot));
            return Item;
        }

        public int ItemID(InventoryType.ItemType Type, byte Slot)
        {
            Storage Item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.ItemID;
        }

        public int Quantity(InventoryType.ItemType Type, byte Slot)
        {
            Storage Item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Quantity;
        }

        public int Spirit(InventoryType.ItemType Type, byte Slot)
        {
            Storage Item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == (byte)Type && i.Slot == Slot));

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
            Storage Item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Level1;
        }

        public byte Level2(InventoryType.ItemType Type, byte Slot)
        {
            Storage Item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Level2;
        }

        public byte Level3(InventoryType.ItemType Type, byte Slot)
        {
            Storage Item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Level3;
        }

        public byte Level4(InventoryType.ItemType Type, byte Slot)
        {
            Storage Item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Level4;
        }

        public byte Level5(InventoryType.ItemType Type, byte Slot)
        {
            Storage Item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Level5;
        }

        public byte Level6(InventoryType.ItemType Type, byte Slot)
        {
            Storage Item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Level6;
        }

        public byte Level7(InventoryType.ItemType Type, byte Slot)
        {
            Storage Item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Level7;
        }

        public byte Level8(InventoryType.ItemType Type, byte Slot)
        {
            Storage Item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Level8;
        }

        public byte Level9(InventoryType.ItemType Type, byte Slot)
        {
            Storage Item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Level9;
        }

        public byte Level10(InventoryType.ItemType Type, byte Slot)
        {
            Storage Item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Level10;
        }

        public byte Fusion(InventoryType.ItemType Type, byte Slot)
        {
            Storage Item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Fusion;
        }

        public byte IsLocked(InventoryType.ItemType Type, byte Slot)
        {
            Storage Item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.IsLocked;
        }

        public int Icon(InventoryType.ItemType Type, byte Slot)
        {
            Storage Item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Icon;
        }

        public int Term(InventoryType.ItemType Type, byte Slot)
        {
            Storage Item = this.Storages.Find(i => (i.ItemID != 0 && i.Quantity != 0 && i.Type == (byte)Type && i.Slot == Slot));
            if (Item == null)
                return 0;
            return Item.Term;
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
