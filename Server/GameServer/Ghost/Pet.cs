using Server.Common.Data;
using Server.Ghost.Characters;

namespace Server.Ghost
{
    public class Pet
    {
        public CharacterPets Parent { get; set; }

        public int ID { get; private set; }
        public int ItemID { get; private set; }
        public int DecorateID { get; private set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }
        public int Exp { get; set; }
        public byte Type { get; set; }
        public byte Slot { get; set; }

        public bool Assigned { get; set; }

        public Character Character
        {
            get
            {
                try
                {
                    return this.Parent.Parent;
                }
                catch
                {
                    return null;
                }
            }
        }

        public Pet(int ItemID, int DecorateID, string Name, int Level, int Hp, int Mp, int Exp, byte Type, byte Slot)
        {
            this.ItemID = ItemID;
            this.DecorateID = DecorateID;
            this.Name = Name;
            this.Level = Level;
            this.Hp = Hp;
            this.Mp = Mp;
            this.Exp = Exp;
            this.Type = Type;
            this.Slot = Slot;
        }

        public Pet(dynamic datum)
        {
            this.ID = datum.id;
            this.Assigned = true;

            this.ItemID = datum.itemId;
            this.DecorateID = datum.decorateId;
            this.Name = datum.name;
            this.Level = datum.level;
            this.Hp = datum.hp;
            this.Mp = datum.mp;
            this.Exp = datum.exp;
            this.Type = (byte)datum.type;
            this.Slot = (byte)datum.slot;
        }

        public void Save()
        {
            dynamic datum = new Datum("Pets");

            datum.cid = this.Character.ID;
            datum.itemId = this.ItemID;
            datum.decorateId = this.DecorateID;
            datum.name = this.Name;
            datum.level = this.Level;
            datum.hp = this.Hp;
            datum.mp = this.Mp;
            datum.exp = this.Exp;
            datum.type = this.Type;
            datum.slot = this.Slot;

            if (this.Assigned)
            {
                datum.Update("id = '{0}'", this.ID);
            }
            else
            {
                datum.Insert();

                this.ID = Database.Fetch("Pets", "id", "cid = '{0}' && itemId = '{1}' && decorateId = '{2}' && name = '{3}' && level = '{4}' && hp = '{5}' && mp = '{6}' && exp = '{7}' && type = '{8}' && slot = '{9}'", this.Character.ID, this.ItemID, this.DecorateID, this.Name, this.Level, this.Hp, this.Mp, this.Exp, this.Type, this.Slot);

                this.Assigned = true;
            }
        }

        public void Delete()
        {
            Database.Delete("Pets", "id = '{0}'", this.ID);

            this.Assigned = false;
        }
    }
}
