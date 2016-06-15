using Server.Common.Constants;
using Server.Common.Data;
using Server.Ghost.Characters;
using System.Collections.Generic;

namespace Server.Ghost
{
    public class CharacterUseSlot : Dictionary<byte, byte>
    {
        public Character Parent { get; private set; }

        public CharacterUseSlot(Character parent)
        {
            this.Parent = parent;
        }

        public void Load()
        {
            foreach (dynamic datum in new Datums("useslot").Populate("cid = '{0}'", this.Parent.ID))
            {
                this.Add((byte)datum.type, (byte)datum.slot);
            }
        }

        public int Slot(InventoryType.ItemType Type)
        {
            foreach (KeyValuePair<byte, byte> UseSlot in this)
            {
                if (UseSlot.Key == (byte)Type)
                    return UseSlot.Value;
            }
            return -1;
        }

        public void Save()
        {
            this.Delete();
            foreach (KeyValuePair<byte, byte> UseSlot in this)
            {
                dynamic datum = new Datum("useslot");

                datum.cid = this.Parent.ID;
                datum.type = UseSlot.Key;
                datum.slot = UseSlot.Value;
                datum.Insert();
            }
        }

        public void Delete()
        {
            Database.Delete("useslot", "cid = '{0}'", this.Parent.ID);
        }
    }
}
