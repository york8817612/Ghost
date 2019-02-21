using Server.Ghost.Characters;
using System.Net;
namespace Server.Ghost
{
    public class Member
    {
        public Character Character { get; set; }
        public Member(Character chr)
        {
            this.Character = chr;
        }
    }
}