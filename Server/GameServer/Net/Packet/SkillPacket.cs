using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Ghost;
using Server.Net;
using System.Collections.Generic;

namespace Server.Packet
{
    public static class SkillPacket
    {
        public static void getSkillInfo(Client c, List<Skill> skill)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.SKILL_ALL))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                // 共用(0轉)
                for (int i = 0; i < 10; i++)
                {
                    int skillID = 0;
                    foreach (Skill s in skill)
                    {
                        skillID = (s.Type == 0 && s.Slot == i ? s.SkillID : 0);
                        if (skillID > 0)
                            break;
                    }
                    plew.WriteShort(skillID);
                }
                for (int i = 0; i < 10; i++)
                {
                    int skillLevel = 0;
                    foreach (Skill s in skill)
                    {
                        skillLevel = (s.Type == 0 && s.Slot == i ? s.SkillLevel : 0);
                        if (skillLevel > 0)
                            break;
                    }
                    plew.WriteByte(skillLevel);
                }

                // 1轉
                for (int i = 0; i < 10; i++)
                {
                    int skillID = 0;
                    foreach (Skill s in skill)
                    {
                        skillID = (s.Type == 1 && s.Slot == i ? s.SkillID : 0);
                        if (skillID > 0)
                            break;
                    }
                    plew.WriteShort(skillID);
                }
                for (int i = 0; i < 10; i++)
                {
                    int skillLevel = 0;
                    foreach (Skill s in skill)
                    {
                        skillLevel = (s.Type == 1 && s.Slot == i ? s.SkillLevel : 0);
                        if (skillLevel > 0)
                            break;
                    }
                    plew.WriteByte(skillLevel);
                }

                // 2轉
                for (int i = 0; i < 10; i++)
                {
                    int skillID = 0;
                    foreach (Skill s in skill)
                    {
                        skillID = (s.Type == 2 && s.Slot == i ? s.SkillID : 0);
                        if (skillID > 0)
                            break;
                    }
                    plew.WriteShort(skillID);
                }
                for (int i = 0; i < 10; i++)
                {
                    int skillLevel = 0;
                    foreach (Skill s in skill)
                    {
                        skillLevel = (s.Type == 2 && s.Slot == i ? s.SkillLevel : 0);
                        if (skillLevel > 0)
                            break;
                    }
                    plew.WriteByte(skillLevel);
                }

                // 3轉
                for (int i = 0; i < 20; i++)
                {
                    int skillID = 0;
                    foreach (Skill s in skill)
                    {
                        skillID = (s.Type == 3 && s.Slot == i ? s.SkillID : 0);
                        if (skillID > 0)
                            break;
                    }
                    plew.WriteShort(skillID);
                }
                for (int i = 0; i < 20; i++)
                {
                    int skillLevel = 0;
                    foreach (Skill s in skill)
                    {
                        skillLevel = (s.Type == 3 && s.Slot == i ? s.SkillLevel : 0);
                        if (skillLevel > 0)
                            break;
                    }
                    plew.WriteByte(skillLevel);
                }

                // 4轉
                for (int i = 0; i < 10; i++)
                {
                    int skillID = 0;
                    foreach (Skill s in skill)
                    {
                        skillID = (s.Type == 4 && s.Slot == i ? s.SkillID : 0);
                        if (skillID > 0)
                            break;
                    }
                    plew.WriteInt(skillID);
                }
                for (int i = 0; i < 10; i++)
                {
                    int skillLevel = 0;
                    foreach (Skill s in skill)
                    {
                        skillLevel = (s.Type == 4 && s.Slot == i ? s.SkillLevel : 0);
                        if (skillLevel > 0)
                            break;
                    }
                    plew.WriteByte(skillLevel);
                }
                plew.WriteInt(0);
                c.Send(plew);
            }
        }

        public static void updateSkillLevel(Client c, short skillBonus, byte type, byte slot, byte level)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.SKILL_LEVELUP_ACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteShort(skillBonus);
                plew.WriteByte(type);
                plew.WriteByte(slot);
                plew.WriteByte(level);
                c.Send(plew);
            }
        }
    }
}
