using Server.Common.Data;
using System.Collections;
using System.Collections.Generic;

namespace Server.Ghost.Characters
{
    public class CharacterQuests : IEnumerable<Quest>
    {
        public Character Parent { get; private set; }

        private List<Quest> Quests { get; set; }

        public CharacterQuests(Character parent)
            : base()
        {
            this.Parent = parent;

            this.Quests = new List<Quest>();
        }

        public void Load()
        {
            foreach (dynamic datum in new Datums("Quests").Populate("cid = '{0}'", this.Parent.ID))
            {
                this.Add(new Quest(datum));
            }
        }

        public void Save()
        {
            foreach (Quest quest in this)
            {
                quest.Save();
            }
        }

        public void Delete()
        {
            foreach (Quest quest in this)
            {
                quest.Delete();
            }
        }

        public void Add(Quest quest)
        {
            quest.Parent = this;
            this.Quests.Add(quest);
        }

        public List<Quest> getQuests()
        {
            return this.Quests;
        }

        public IEnumerator<Quest> GetEnumerator()
        {
            return this.Quests.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this.Quests).GetEnumerator();
        }
    }
}
