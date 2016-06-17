using Server.Common.Data;
using System.Collections.Generic;

namespace Server.Characters
{
    public class CharacterKeyMap : Dictionary<string, Shortcut>
    {
        public Character Parent { get; private set; }

        public CharacterKeyMap(Character parent)
        {
            this.Parent = parent;
        }

        public void Load()
        {
            foreach (dynamic datum in new Datums("keymaps").Populate("cid = '{0}'", this.Parent.ID))
            {
                this.Add(datum.quickslot, new Shortcut(datum.skillID, (byte)datum.type, (byte)datum.slot));
            }
        }

        public int SkillID(string key)
        {
            try
            {
                return this[key].SkillID;
            }
            catch
            {
                return -1;
            }
        }

        public int Type(string key)
        {
            try
            {
                return this[key].Type;
            }
            catch
            {
                return -1;
            }
        }

        public int Slot(string key)
        {
            try
            {
                return this[key].Slot;
            }
            catch
            {
                return -1;
            }
        }

        public void Save()
        {
            this.Delete();
            foreach (KeyValuePair<string, Shortcut> shortcut in this)
            {
                dynamic datum = new Datum("keymaps");

                datum.cid = this.Parent.ID;
                datum.quickslot = shortcut.Key;
                datum.skillID = shortcut.Value.SkillID;
                datum.type = shortcut.Value.Type;
                datum.slot = shortcut.Value.Slot;

                datum.Insert();
            }
        }

        public void Delete()
        {
            Database.Delete("keymaps", "cid = '{0}'", this.Parent.ID);
        }
    }
}
