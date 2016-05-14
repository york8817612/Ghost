using Server.Common.Data;
using Server.Ghost.Characters;

namespace Server.Ghost
{
    public class Skill
    {
        public CharacterSkills Parent { get; set; }

        public int ID { get; private set; }
        public int SkillID { get; set; }
        public byte SkillLevel { get; set; }
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

        public Skill(int SkillID, byte SkillLevel, byte Type, byte Slot)
        {
            this.SkillID = SkillID;
            this.SkillLevel = SkillLevel;
            this.Type = Type;
            this.Slot = Slot;
        }

        public Skill(dynamic datum)
        {
            this.ID = datum.id;
            this.Assigned = true;

            this.SkillID = datum.skillId;
            this.SkillLevel = (byte)datum.skillLevel;
            this.Type = (byte)datum.type;
            this.Slot = (byte)datum.slot;
        }

        public void Save()
        {
            dynamic datum = new Datum("Skills");

            datum.cid = this.Character.ID;
            datum.skillId = this.SkillID;
            datum.skillLevel = this.SkillLevel;
            datum.type = this.Type;
            datum.slot = this.Slot;

            if (this.Assigned)
            {
                datum.Update("id = '{0}'", this.ID);
            }
            else
            {
                datum.Insert();

                this.ID = Database.Fetch("Skills", "id", "cid = '{0}' && skillId = '{1}' && skillLevel = '{2}' && type = '{3}' && slot = '{4}'", this.Character.ID, this.SkillID, this.SkillLevel, this.Type, this.Slot);

                this.Assigned = true;
            }
        }

        public void Delete()
        {
            Database.Delete("Skills", "id = '{0}'", this.ID);

            this.Assigned = false;
        }
    }
}
