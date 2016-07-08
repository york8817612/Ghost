using Server.Common.Data;
using Server.Net;
using System.Net;

namespace Server.Ghost.Characters
{
    public sealed class Character
    {
        public Client Client { get; private set; }
        public int ID { get; private set; }
        public int AccountID { get; set; }
        public byte WorldID { get; set; }

        public int CharacterID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public byte Gender { get; set; }
        public byte Level { get; set; }
        public byte Class { get; set; }
        public byte ClassLevel { get; set; }
        public byte Guild { get; set; }
        public short MapX { get; set; }
        public short MapY { get; set; }

        public IPAddress IP { get; set; }

        private bool Assigned { get; set; }

        public Character(int id = 0, Client gc = null)
        {
            this.ID = id;
            this.Client = gc;
        }

        public void Load(bool IsFullLoad = true)
        {
            dynamic datum = new Datum("Characters");

            datum.Populate("id = '{0}'", this.ID);

            this.ID = datum.id;
            this.Assigned = true;

            this.AccountID = datum.accountId;
            this.WorldID = (byte)datum.worldId;
            this.Name = datum.name;
            this.Title = datum.title;
            this.Gender = (byte)datum.gender;
            this.Level = (byte)datum.level;
            this.Class = (byte)datum.classId;
            this.ClassLevel = (byte)datum.classLv;
            this.Guild = (byte)datum.guild;
            this.MapX = (short)datum.mapX;
            this.MapY = (short)datum.mapY;
        }
    }
}
