using Server.Common.Data;
using Server.Ghost.Characters;

namespace Server.Ghost
{
    public class Quest
    {
        public CharacterQuests Parent { get; set; }

        public int ID { get; private set; }
        public int QuestID { get; set; }
        public byte QuestState { get; set; }
        public int KillMonster { get; set; }

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

        public Quest(int QuestID)
        {
            this.QuestID = QuestID;
            this.QuestState = 0x20;
            this.KillMonster = 0;
        }

        public Quest(dynamic datum)
        {
            this.ID = datum.id;
            this.Assigned = true;

            this.QuestID = datum.questId;
            this.QuestState = (byte)datum.questState;
        }

        public void Save()
        {
            dynamic datum = new Datum("Quests");

            datum.cid = this.Character.ID;
            datum.questID = this.QuestID;
            datum.questState = this.QuestState;

            if (this.Assigned)
            {
                datum.Update("id = '{0}'", this.ID);
            }
            else
            {
                datum.Insert();

                this.ID = Database.Fetch("Quests", "id", "cid = '{0}' && questID = '{1}' && questState = '{2}'", this.Character.ID, this.QuestID, this.QuestState);

                this.Assigned = true;
            }
        }

        public void Delete()
        {
            Database.Delete("Quests", "id = '{0}'", this.ID);

            this.Assigned = false;
        }
    }
}
