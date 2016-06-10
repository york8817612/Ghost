using Server.Common.Data;
using Server.Ghost.Characters;

namespace Server.Ghost
{
    public class Storage
    {
        public CharacterStorages Parent { get; set; }

        public int ID { get; private set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public int Type { get; set; }
        public int Slot { get; set; }
        public int Money { get; set; }

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

        public Storage(dynamic datum)
        {
            this.ID = datum.id;
            this.Assigned = true;

            this.ItemID = datum.itemID;
            this.Quantity = datum.quantity;
            this.Type = datum.type;
            this.Slot = datum.slot;
            this.Money = datum.money;
        }

        public Storage(int ItemID, int Quantity, int Type, int Slot, int money)
        {
            this.ItemID = ItemID;
            this.Quantity = Quantity;
            this.Type = Type;
            this.Slot = Slot;
            this.Money = money;
        }

        public void Save()
        {
            dynamic datum = new Datum("Storages");

            datum.cid = this.Character.ID;
            datum.itemID = this.ItemID;
            datum.quantity = this.Quantity;
            datum.type = this.Type;
            datum.slot = this.Slot;
            datum.money = this.Money;

            if (this.Assigned)
            {
                datum.Update("id = '{0}'", this.ID);
            }
            else
            {
                datum.Insert();

                this.ID = Database.Fetch("Storages", "id", "cid = '{0}' && itemID = '{1}' && quantity = '{2}' && type = '{3}' && slot = '{4}' && money = '{5}'", this.Character.ID, this.ItemID, this.Quantity, this.Type, this.Slot, this.Money);

                this.Assigned = true;
            }
        }

        public void Delete()
        {
            Database.Delete("Storages", "id = '{0}'", this.ID);

            this.Assigned = false;
        }
    }
}
