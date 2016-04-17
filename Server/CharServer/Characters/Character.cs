using Server.Common.Data;
using Server.Common.IO;
using Server.Net;

namespace Server.Characters
{
    public sealed class Character
    {
        public Client Client { get; private set; }
        public int ID { get; private set; }
        public int AccountID { get; set; }
        public byte WorldID { get; set; }

        public string Name { get; set; }
        public string Title { get; set; }
        public byte Gender { get; set; }
        public int Hair { get; set; }
        public int Eyes { get; set; }
        public byte Level { get; set; }
        public byte Class { get; set; }
        public byte ClassLV { get; set; }
        public int Hp { get; set; }
        public int MaxHp { get; set; }
        public short Sp { get; set; }
        public short MaxSp { get; set; }
        public int Exp { get; set; }
        public int Rank { get; set; }
        public short MapX { get; set; }
        public short MapY { get; set; }
        public short PlayerX { get; set; }
        public short PlayerY { get; set; }
        public short Str { get; set; }
        public short Dex { get; set; }
        public short Vit { get; set; }
        public short Int { get; set; }
        public byte Position { get; set; }

        public byte ip_1 { get; set; }
        public byte ip_2 { get; set; }
        public byte ip_3 { get; set; }
        public byte ip_4 { get; set; }

        public CharacterItems Items { get; private set; }

        private bool Assigned { get; set; }

        public Character(int id = 0, Client gc = null)
        {
            this.ID = id;
            this.Client = gc;

            this.Items = new CharacterItems(this);
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
            this.Hair = datum.hair;
            this.Eyes = datum.eyes;
            this.Level = (byte)datum.level;
            this.Class = (byte)datum.classId;
            this.ClassLV = (byte)datum.classLv;
            this.Hp = datum.hp;
            this.MaxHp = datum.maxHp;
            this.Sp = (short)datum.sp;
            this.MaxSp = (short)datum.maxSp;
            this.Exp = datum.exp;
            this.Rank = datum.rank;
            this.Str = (short)datum.c_str;
            this.Dex = (short)datum.c_dex;
            this.Vit = (short)datum.c_vit;
            this.Int = (short)datum.c_int;
            this.MapX = (short)datum.mapX;
            this.MapY = (short)datum.mapY;
            this.PlayerX = (short)datum.playerX;
            this.PlayerY = (short)datum.playerY;
            this.Position = (byte)datum.position;

            this.Items.Load();
        }

        public void Save()
        {
            dynamic datum = new Datum("Characters");

            datum.accountId = this.AccountID;
            datum.worldId = this.WorldID;
            datum.name = this.Name;
            datum.title = this.Title;
            datum.gender = this.Gender;
            datum.hair = this.Hair;
            datum.eyes = this.Eyes;
            datum.level = this.Level;
            datum.classId = this.Class;
            datum.classLv = this.ClassLV;
            datum.hp = this.Hp;
            datum.maxHp = this.MaxHp;
            datum.sp = this.Sp;
            datum.maxSp = this.MaxSp;
            datum.exp = this.Exp;
            datum.rank = this.Rank;
            datum.c_str = this.Str;
            datum.c_dex = this.Dex;
            datum.c_vit = this.Vit;
            datum.c_int = this.Int;
            datum.mapX = this.MapX;
            datum.mapY = this.MapY;
            datum.playerX = this.PlayerX;
            datum.playerY = this.PlayerY;
            datum.position = this.Position;

            if (this.Assigned)
            {
                datum.Update("id = '{0}'", this.ID);
            }
            else
            {
                datum.Insert();

                this.ID = Database.Fetch("Characters", "id", "name = '{0}'", this.Name);

                this.Assigned = true;
            }

            this.Items.Save();

            Log.Inform("角色'{0}'的資料已儲存至資料庫。", this.Name);
        }

        public void Delete()
        {
            this.Items.Delete();

            Database.Delete("Characters", "id = '{0}'", this.ID);

            this.Assigned = false;
        }
    }
}
