using Server.Characters;
using Server.Common.Data;

namespace Server
{
    public class Storage
    {
        public CharacterStorages Parent { get; set; }

        public int ID { get; private set; }
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

            this.Money = datum.money;
        }

        public Storage(int money)
        {
            this.Money = money;
        }

        public void Save()
        {
            dynamic datum = new Datum("Storages");

            datum.cid = this.Character.ID;
            datum.money = this.Money;

            if (this.Assigned)
            {
                datum.Update("id = '{0}'", this.ID);
            }
            else
            {
                datum.Insert();

                this.ID = Database.Fetch("Storages", "id", "cid = '{0}' && money = '{1}'", this.Character.ID, this.Money);

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
