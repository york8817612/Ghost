using System;

namespace Server.Ghost.Characters
{
    public class SkillFullException : Exception
    {
        public override string Message
        {
            get
            {
                return "Skill full";
            }
        }
    }
}
