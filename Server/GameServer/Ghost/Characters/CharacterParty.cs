using System.Collections;
using System.Collections.Generic;

namespace Server.Ghost.Characters
{
    public class CharacterParty : IEnumerable<Member>
    {
        public Character Parent { get; private set; }

        private List<Member> Members { get; set; }

        public CharacterParty(Character parent)
            : base()
        {
            this.Parent = parent;

            this.Members = new List<Member>();
        }

        public List<Member> getMembers()
        {
            return this.Members;
        }

        public IEnumerator<Member> GetEnumerator()
        {
            return this.Members.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this.Members).GetEnumerator();
        }
    }
}
