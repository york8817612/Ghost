using Server.Common.Data;
using Server.Ghost.Characters;

namespace Server.Ghost
{
    public class Quest
    {
        public CharacterQuests Parent { get; set; }

        public int ID { get; private set; }
        public int QuestID { get; set; }
        public byte QuestStage { get; set; }
        public int RequireMonster { get; set; }
        public int CompleteMonster { get; set; }
        public byte QuestState { get; set; }

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

        public Quest(dynamic datum)
        {
            this.ID = datum.id;
            this.Assigned = true;

            this.QuestID = datum.questId;
            this.QuestStage = (byte)datum.stage;
            this.RequireMonster = datum.requireMonster;
            this.CompleteMonster = datum.completeMonster;
            this.QuestState = (byte)datum.questState;
        }

        public Quest(int QuestID)
        {
            this.QuestID = QuestID;
            this.QuestStage = 0;
            this.RequireMonster = 0;
            this.CompleteMonster = 0;
            this.QuestState = 0x20;
        }

        public void Save()
        {
            dynamic datum = new Datum("Quests");

            datum.cid = this.Character.ID;
            datum.questID = this.QuestID;
            datum.stage = this.QuestStage;
            datum.requireMonster = this.RequireMonster;
            datum.completeMonster = this.CompleteMonster;
            datum.questState = this.QuestState;

            if (this.Assigned)
            {
                datum.Update("id = '{0}'", this.ID);
            }
            else
            {
                datum.Insert();

                this.ID = Database.Fetch("Quests", "id", "cid = '{0}' && questID = '{1}' && stage = '{2}' && requireMonster = '{3}' && completeMonster = '{4}' && questState = '{5}'", this.Character.ID, this.QuestID, this.QuestStage, this.RequireMonster, this.CompleteMonster, this.QuestState);

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
