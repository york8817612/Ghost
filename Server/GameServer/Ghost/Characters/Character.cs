using Server.Common.Data;
using Server.Common.IO;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;
using System.Collections.Generic;
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
        public int Hair { get; set; }
        public int Eyes { get; set; }
        public byte Level { get; set; }
        public byte Class { get; set; }
        public byte ClassLevel { get; set; }
        public byte Guild { get; set; }
        public short Hp { get; set; }
        public short MaxHp { get; set; }
        public short Mp { get; set; }
        public short MaxMp { get; set; }
        public short Fury { get; set; }
        public short MaxFury { get; set; }
        public int Exp { get; set; }
        public int Rank { get; set; }
        public int Money { get; set; }
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
        public short Avoid { get; set; }
        public short Defense { get; set; }
        public short UpgradeDefense { get; set; }
        public short AbilityBonus { get; set; }
        public short SkillBonus { get; set; }
        public byte JumpHeight { get; set; }
        public byte Position { get; set; }

        public bool IsHiding { get; set; }
        public bool IsFuring { get; set; }
        public byte FuringType { get; set; }
        public bool IsAlive { get; set; }
        public bool IsFishing { get; set; }

        public short FuryAttack { get; set; }
        public short FuryMagic { get; set; }
        public short FuryDefense { get; set; }

        public IPAddress IP { get; set; }

        public CharacterItems Items { get; private set; }
        public CharacterPets Pets { get; private set; }
        public CharacterStorages Storages { get; private set; }
        public CharacterSkills Skills { get; private set; }
        public CharacterQuests Quests { get; private set; }
        public CharacterKeyMap Keymap { get; private set; }
        public CharacterTrade Trade { get; set; }
        public CharacterShop Shop { get; set; }

        public CharacterUseSlot UseSlot { get; private set; }
        public CharacterParty Party { get; set; }

        public Character Trader { get; set; }
        public Character Competitor { get; set; }

        public Dictionary<int, Common.Threading.Delay> SkillState { get; private set; }
        public short SkillAttack_10107 { get; set; }
        public short SkillDefense_10107 { get; set; }
        public short SkillDefense_10309 { get; set; }

        private bool Assigned { get; set; }

        public Character(int id = 0, Client gc = null)
        {
            this.ID = id;
            this.Client = gc;

            this.Items = new CharacterItems(this);
            this.Pets = new CharacterPets(this);
            this.Storages = new CharacterStorages(this);
            this.Skills = new CharacterSkills(this);
            this.SkillState = new Dictionary<int, Common.Threading.Delay>();
            this.Quests = new CharacterQuests(this);
            this.Keymap = new CharacterKeyMap(this);
            this.UseSlot = new CharacterUseSlot(this);
            this.IsAlive = true;
            this.IsFishing = false;
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
            this.Guild = (byte)datum.guild;
            this.Hp = (short)datum.hp;
            this.MaxHp = (short)datum.maxHp;
            this.Mp = (short)datum.mp;
            this.MaxMp = (short)datum.maxMp;
            this.Fury = (short)datum.fury;
            this.MaxFury = (short)datum.maxFury;
            this.Exp = datum.exp;
            this.Rank = datum.rank;
            this.Money = datum.money;
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
            this.Avoid = (short)datum.avoid;
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

            this.Items.Load();
            this.Pets.Load();
            this.Storages.Load();
            this.Skills.Load();
            this.Quests.Load();
            this.Keymap.Load();
            this.UseSlot.Load();
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
            datum.guild = this.Guild;
            datum.hp = this.Hp;
            datum.maxHp = this.MaxHp;
            datum.mp = this.Mp;
            datum.maxMp = this.MaxMp;
            datum.fury = this.Fury;
            datum.maxFury = this.MaxFury;
            datum.exp = this.Exp;
            datum.rank = this.Rank;
            datum.money = this.Money;
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
            datum.avoid = this.Avoid;
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
            this.Pets.Save();
            this.Storages.Save();
            this.Skills.Save();
            this.Quests.Save();
            this.Keymap.Save();
            this.UseSlot.Save();

            Log.Inform("角色'{0}'的資料已儲存至資料庫。", this.Name);
        }

        public void Delete()
        {
            this.Items.Delete();
            this.Pets.Delete();
            this.Storages.Delete();
            this.Skills.Delete();
            this.Quests.Delete();
            this.Keymap.Delete();
            this.UseSlot.Delete();

            Database.Delete("Characters", "id = '{0}'", this.ID);

            this.Assigned = false;
        }

        public void LevelUp()
        {
            this.Level++;
            this.Exp = 0;

            switch (this.Class)
            {
                case 1: // 武士
                    this.MaxHp += 13;
                    this.MaxMp += 7;
                    break;
                case 2: // 刺客
                    this.MaxHp += 9;
                    this.MaxMp += 12;
                    break;
                case 3: // 道士
                    this.MaxHp += 7;
                    this.MaxMp += 14;
                    break;
                case 4: // 力士
                    // 未知
                    this.MaxHp += 13;
                    this.MaxMp += 7;
                    break;
                case 5: // 射手
                    // 未知
                    this.MaxHp += 9;
                    this.MaxMp += 12;
                    break;
                default:
                    this.MaxHp += 10;
                    this.MaxMp += 15;
                    break;
            }

            this.Hp = this.MaxHp;
            this.Mp = this.MaxMp;

            if (this.Level % 10 != 0)
                this.AbilityBonus += 4;
            else
                this.AbilityBonus += 8;

            this.SkillBonus += 2;

            Map map = MapFactory.GetMap(this.MapX, this.MapY);
            foreach (Character All in map.Characters)
                StatusPacket.LevelUp(All.Client, this, this.Level);
            StatusPacket.getStatusInfo(Client);
        }

        public void CancelSkill()
        {
            // 狂暴怒氣
            if (SkillState.ContainsKey(10107))
            {
                this.Defense += SkillDefense_10107;
                this.Attack -= SkillAttack_10107;
                this.MaxAttack -= SkillAttack_10107;
                this.UpgradeAttack -= SkillAttack_10107;
            }
            // 防護加持
            if (SkillState.ContainsKey(10309))
            {
                this.Defense -= SkillDefense_10309;
                this.UpgradeDefense -= SkillDefense_10309;
            }
        }
    }
}
