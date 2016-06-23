using Server.Common.Constants;
using Server.Common.Data;
using System.Collections;
using System.Collections.Generic;

namespace Server.Ghost.Characters
{
    public class CharacterPets : IEnumerable<Pet>
    {
        public Character Parent { get; private set; }
        private List<Pet> Pets { get; set; }

        public CharacterPets(Character parent)
            : base()
        {
            this.Parent = parent;

            this.Pets = new List<Pet>();
        }

        public void Load()
        {
            foreach (dynamic datum in new Datums("Pets").Populate("cid = '{0}'", this.Parent.ID))
            {
                this.Add(new Pet(datum));
            }
        }

        public void Save()
        {
            foreach (Pet Pet in this)
            {
                Pet.Save();
            }
        }

        public void Delete()
        {
            foreach (Pet Pet in this)
            {
                Pet.Delete();
            }
        }

        public void Add(Pet Pet)
        {
            Pet.Parent = this;
            this.Pets.Add(Pet);
        }

        public void Remove(byte Type, byte Slot)
        {
            Pet Pet = this.Pets.Find(i => (i.Type == Type && i.Slot == Slot));
            this.Pets.Remove(Pet);
            Pet.Delete();
        }

        public List<Pet> getPets()
        {
            return this.Pets;
        }

        public Pet Pet(byte Type, byte Slot)
        {
            Pet Pet = this.Pets.Find(i => (i.Type == Type && i.Slot == Slot));
            return Pet;
        }

        public int ItemID(byte Type, byte Slot)
        {
            Pet Pet = this.Pets.Find(i => (i.Type == Type && i.Slot == Slot));
            if (Pet == null)
                return 0;
            return Pet.ItemID;
        }

        public int DecorateID(byte Type, byte Slot)
        {
            Pet Pet = this.Pets.Find(i => (i.Type == Type && i.Slot == Slot));
            if (Pet == null)
                return 0;
            return Pet.DecorateID;
        }

        public string Name(byte Type, byte Slot)
        {
            Pet Pet = this.Pets.Find(i => (i.Type == Type && i.Slot == Slot));
            if (Pet == null)
                return "";
            return Pet.Name;
        }

        public int Level(byte Type, int Slot)
        {
            Pet Pet = this.Pets.Find(i => (i.Type == Type && i.Slot == Slot));
            if (Pet == null)
                return 0;
            return Pet.Level;
        }

        public int Hp(byte Type, int Slot)
        {
            Pet Pet = this.Pets.Find(i => (i.Type == Type && i.Slot == Slot));
            if (Pet == null)
                return 0;
            return Pet.Hp;
        }

        public int Mp(byte Type, int Slot)
        {
            Pet Pet = this.Pets.Find(i => (i.Type == Type && i.Slot == Slot));
            if (Pet == null)
                return 0;
            return Pet.Mp;
        }

        public int Exp(byte Type, int Slot)
        {
            Pet Pet = this.Pets.Find(i => (i.Type == Type && i.Slot == Slot));
            if (Pet == null)
                return 0;
            return Pet.Exp;
        }

        public byte GetNextFreeSlot(InventoryType.ItemType Type)
        {
            for (byte i = 0; i < 24; i++)
            {
                if (this[Type, i] == null)
                {
                    return i;
                }
            }

            throw new InventoryFullException();
        }

        public Pet this[InventoryType.ItemType type, byte slot]
        {
            get
            {
                foreach (Pet Pet in this)
                {
                    if (Pet.Type == (byte)type && Pet.Slot == slot)
                    {
                        return Pet;
                    }
                }

                return null;
            }
        }

        public IEnumerator<Pet> GetEnumerator()
        {
            return this.Pets.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this.Pets).GetEnumerator();
        }
    }
}
