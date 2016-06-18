using System.Collections;
using System.Collections.Generic;

namespace Server.Ghost.Characters
{
    public class CharacterParty : IEnumerable<PartyMember>
    {
        public Character Parent { get; private set; }

        private List<PartyMember> Members { get; set; }

        public CharacterParty(Character parent)
            : base()
        {
            this.Parent = parent;

            this.Members = new List<PartyMember>();
        }

        public List<PartyMember> getMembers()
        {
            return this.Members;
        }

        public IEnumerator<PartyMember> GetEnumerator()
        {
            return this.Members.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this.Members).GetEnumerator();
        }
    }
}
