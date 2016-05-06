using Server.Common.Constants;
using Server.Common.Data;
using Server.Common.IO;
using System;

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
        public int Hair { get; set; }
        public int Eyes { get; set; }
        public byte Level { get; set; }
        public byte Class { get; set; }
        public byte ClassLevel { get; set; }
        public int Hp { get; set; }
        public int MaxHp { get; set; }
        public short Mp { get; set; }
        public short MaxMp { get; set; }
        public short Fury { get; set; }
        public short MaxFury { get; set; }
        public int Exp { get; set; }
        public int Fame { get; set; }
        public int Money { get; set; }
        public int Rank { get; set; }
        public short MapX { get; set; }
        public short MapY { get; set; }
        public short PlayerX { get; set; }
        public short PlayerY { get; set; }
        public short Str { get; set; }
        public short Dex { get; set; }
        public short Vit { get; set; }
        public short Int { get; set; }
        public short UpgradeStr { get; set; }
        public short UpgradeDex { get; set; }
        public short UpgradeVit { get; set; }
        public short UpgradeInt { get; set; }
        public short Attack { get; set; }
        public short MaxAttack { get; set; }
        public short UpgradeAttack { get; set; }
        public short Magic { get; set; }
        public short MaxMagic { get; set; }
        public short UpgradeMagic { get; set; }
        public short Defense { get; set; }
        public short UpgradeDefense { get; set; }
        public short AbilityBonus { get; set; }
        public short SkillBonus { get; set; }
        public byte JumpHeight { get; set; }
        public byte Position { get; set; }

        public Map Map { get; private set; }
        public Inventory[] Inventory { get; private set; }
        public CharacterItems Items { get; private set; }
        public CharacterSkills Skills { get; private set; }

        private bool Assigned { get; set; }

        public Character(int id = 0, Client gc = null)
        {
            this.ID = id;
            this.Client = gc;

            this.Inventory = new Inventory[6];
            Inventory[0] = new Inventory(InventoryType.ItemType.Equip, this);
            Inventory[1] = new Inventory(InventoryType.ItemType.Equip1, this);
            Inventory[2] = new Inventory(InventoryType.ItemType.Equip2, this);
            Inventory[3] = new Inventory(InventoryType.ItemType.Spend3, this);
            Inventory[4] = new Inventory(InventoryType.ItemType.Other4, this);
            Inventory[5] = new Inventory(InventoryType.ItemType.Pet5, this);
            this.Items = new CharacterItems(this);
            this.Skills = new CharacterSkills(this);
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
            this.ClassLevel = (byte)datum.classLv;
            this.Hp = datum.hp;
            this.MaxHp = datum.maxHp;
            this.Mp = (short)datum.mp;
            this.MaxMp = (short)datum.maxMp;
            this.Fury = (short)datum.fury;
            this.MaxFury = (short)datum.maxFury;
            this.Exp = datum.exp;
            this.Fame = datum.fame;
            this.Rank = datum.rank;
            this.Str = (short)datum.c_str;
            this.Dex = (short)datum.c_dex;
            this.Vit = (short)datum.c_vit;
            this.Int = (short)datum.c_int;
            this.UpgradeStr = (short)datum.upgradeStr;
            this.UpgradeDex = (short)datum.upgradeDex;
            this.UpgradeVit = (short)datum.upgradeVit;
            this.UpgradeInt = (short)datum.upgradeInt;
            this.Attack = (short)datum.attack;
            this.MaxAttack = (short)datum.maxAttack;
            this.UpgradeAttack = (short)datum.upgradeAttack;
            this.Magic = (short)datum.magic;
            this.MaxMagic = (short)datum.maxMagic;
            this.UpgradeMagic = (short)datum.upgradeMagic;
            this.Defense = (short)datum.defense;
            this.UpgradeDefense = (short)datum.upgradeDefense;
            this.AbilityBonus = (short)datum.abilityBonus;
            this.SkillBonus = (short)datum.skillBonus;
            this.JumpHeight = (byte)datum.jumpHeight;
            this.MapX = (short)datum.mapX;
            this.MapY = (short)datum.mapY;
            this.PlayerX = (short)datum.playerX;
            this.PlayerY = (short)datum.playerY;
            this.Position = (byte)datum.position;

            this.Inventory[0].Load(InventoryType.ItemType.Equip);
            this.Inventory[1].Load(InventoryType.ItemType.Equip1);
            this.Inventory[2].Load(InventoryType.ItemType.Equip2);
            this.Inventory[3].Load(InventoryType.ItemType.Spend3);
            this.Inventory[4].Load(InventoryType.ItemType.Other4);
            this.Inventory[5].Load(InventoryType.ItemType.Pet5);
            this.Items.Load();
            this.Skills.Load();
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
            datum.classLv = this.ClassLevel;
            datum.hp = this.Hp;
            datum.maxHp = this.MaxHp;
            datum.mp = this.Mp;
            datum.maxMp = this.MaxMp;
            datum.fury = this.Fury;
            datum.maxFury = this.MaxFury;
            datum.exp = this.Exp;
            datum.fame = this.Fame;
            datum.rank = this.Rank;
            datum.c_str = this.Str;
            datum.c_dex = this.Dex;
            datum.c_vit = this.Vit;
            datum.c_int = this.Int;
            datum.upgradeStr = this.UpgradeStr;
            datum.upgradeDex = this.UpgradeDex;
            datum.upgradeVit = this.UpgradeVit;
            datum.upgradeInt = this.UpgradeInt;
            datum.attack = this.Attack;
            datum.maxAttack = this.MaxAttack;
            datum.upgradeAttack = this.UpgradeAttack;
            datum.magic = this.Magic;
            datum.maxMagic = this.MaxMagic;
            datum.upgradeMagic = this.UpgradeMagic;
            datum.defense = this.Defense;
            datum.upgradeDefense = this.UpgradeDefense;
            datum.abilityBonus = this.AbilityBonus;
            datum.skillBonus = this.SkillBonus;
            datum.jumpHeight = this.JumpHeight;
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
            this.Skills.Save();

            Log.Inform("角色'{0}'的資料已儲存至資料庫。", this.Name);
        }

        public void Delete()
        {
            this.Items.Delete();
            this.Skills.Delete();

            Database.Delete("Characters", "id = '{0}'", this.ID);

            this.Assigned = false;
        }

        public Map SetMap(Map map)
        {
            return this.Map = map;
        }

        public Inventory getInventory(InventoryType.ItemType type)
        {
            return Inventory[(byte)type];
        }
    }
}
