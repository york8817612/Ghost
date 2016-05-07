using Server.Common.IO.Packet;
using Server.Ghost;
using System.Collections.Generic;

namespace Server.Handler
{
    class SkillHandler
    {
        public static void SkillLevelUp_Req(InPacket lea, Client gc)
        {
            byte type = lea.ReadByte();
            byte slot = lea.ReadByte();
            List<Skill> s = gc.Character.Skills.getSkills();
            Skill sl = null;
            foreach (Skill skill in s)
            {
                if (skill.Type == type && skill.Slot == slot)
                {
                    sl = skill;
                    break;
                }
            }
            if (sl == null)
                return;
            SkillPacket.updateSkillLevel(gc, --gc.Character.SkillBonus, type, slot, ++sl.SkillLevel);
        }
    }
}
