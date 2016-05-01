using Server.Common.IO.Packet;
using Server.Ghost;

namespace Server.Handler
{
    class SkillHandler
    {
        public static void SkillLevelUp_Req(InPacket lea, Client gc)
        {
            byte inventory = lea.ReadByte();
            byte slot = lea.ReadByte();
            byte skillLevel = 0;
            for (int i = 0; i < 7; i++)
            {
                foreach (Skill s in gc.Character.Skills.getSkills())
                {
                    skillLevel = (s.slot == i ? s.SkillLevel : (byte)0);
                    if (skillLevel > 0)
                    {
                        s.SkillLevel++;
                        gc.Character.SkillBonus--;
                        SkillPacket.setSkillLevel(gc, gc.Character.SkillBonus, inventory, slot, s.SkillLevel);
                        break;
                    }
                }
                if (skillLevel > 0)
                    break;
            }
        }
    }
}
