using Server.Common.Data;
using System.Collections;
using System.Collections.Generic;

namespace Server.Characters
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
