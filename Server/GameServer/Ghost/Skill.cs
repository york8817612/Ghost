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
        public byte slot { get; set; }

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

        public Skill(int skillID, byte skillLevel, byte slot)
        {
            this.SkillID = skillID;
            this.SkillLevel = skillLevel;
            this.slot = slot;
        }

        public Skill(dynamic datum)
        {
            this.ID = datum.id;
            this.Assigned = true;

            this.SkillID = datum.skillId;
            this.SkillLevel = (byte)datum.skillLevel;
            this.slot = (byte)datum.slot;
        }

        public void Save()
        {
            dynamic datum = new Datum("Skills");

            datum.cid = this.Character.ID;
            datum.skillId = this.SkillID;
            datum.skillLevel = this.SkillLevel;
            datum.slot = this.slot;

            if (this.Assigned)
            {
                datum.Update("id = '{0}'", this.ID);
            }
            else
            {
                datum.Insert();

                this.ID = Database.Fetch("Skills", "id", "cid = '{0}' && skillId = '{1}' && skillLevel = '{2}' && slot = '{3}'", this.Character.ID, this.SkillID, this.SkillLevel, this.slot);

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
