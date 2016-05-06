using Server.Common.IO.Packet;
using Server.Ghost;
using System.Collections.Generic;

namespace Server.Handler
{
    class SkillHandler
    {
        public static void SkillLevelUp_Req(InPacket lea, Client gc)
        {
            byte inventory = lea.ReadByte();
            byte slot = lea.ReadByte();
            List<Skill> s = gc.Character.Skills.getSkills();
            Skill sl = null;
            foreach (Skill skill in s)
            {
                if (skill.slot == slot)
                {
                    sl = skill;
                    break;
                }
            }
            if (sl == null)
                return;
            SkillPacket.updateSkillLevel(gc, --gc.Character.SkillBonus, inventory, slot, ++sl.SkillLevel);
        }
    }
}
