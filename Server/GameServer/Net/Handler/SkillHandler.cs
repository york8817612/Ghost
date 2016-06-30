using Server.Common.IO.Packet;
using Server.Common.Threading;
using Server.Ghost;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;
using System.Collections.Generic;

namespace Server.Handler
{
    public static class SkillHandler
    {
        public static void UseSkill_Req(InPacket lea, Client gc)
        {
            byte Type = lea.ReadByte();
            byte Slot = lea.ReadByte();
            byte Level = lea.ReadByte();
            byte NumOfTargets = lea.ReadByte();
            int Active = lea.ReadInt();
            var chr = gc.Character;
            
            Map Map = MapFactory.GetMap(chr.MapX, chr.MapY);

            if (Type == 0 || Type == 1 || Type == 2 || Type == 3 || Type == 4)
            {
                Skill skill = null;
                foreach (Skill sl in chr.Skills.getSkills())
                {
                    if (sl.Type.Equals(Type) && sl.Slot.Equals(Slot) && sl.SkillLevel.Equals(Level))
                    {
                        skill = sl;
                    }
                }
                switch (skill.SkillID)
                {
                    case 0:
                        break;
                    case 1:
                        if (skill.SkillLevel < 5)
                            chr.Mp -= 2;
                        else
                            chr.Mp -= 4;
                        break;
                    case 2:
                        break;
                    case 3:
                        if (Active == 1)
                        {
                            Delay ddl = new Delay(1, false, null);
                            chr.SkillState.Add(skill.SkillID, ddl);
                            chr.SkillState[skill.SkillID] = new Delay(8000, true, () =>
                            {
                                int addHp = 0, addMp = 0;
                                if ((chr.Hp + 8) < chr.MaxHp)
                                {
                                    addHp = 8;
                                }
                                else
                                {
                                    addHp = chr.MaxHp - chr.Hp;
                                    if (addHp > 8)
                                        addHp = 8;
                                }
                                if ((chr.Mp + 2) < chr.MaxMp)
                                {
                                    addMp = 2;
                                }
                                else
                                {
                                    addMp = chr.MaxMp - chr.Mp;
                                    if (addMp > 2)
                                        addMp = 2;
                                }
                                chr.Hp += (short)addHp;
                                chr.Mp += (short)addMp;
                                StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
                            }
                            );
                            chr.SkillState[skill.SkillID].Execute();
                        }
                        else
                        {
                            chr.SkillState[skill.SkillID].Cancel();
                            chr.SkillState.Remove(skill.SkillID);
                        }
                        break;
                    case 4:
                        chr.Mp -= (short)5;
                        StatusPacket.UpdateHpMp(gc, chr.Hp, chr.Mp, chr.Fury, chr.MaxFury);
                        break;
                    case 10207: // 霧影術
                        chr.IsHiding = true;
                        foreach (Character All in Map.Characters)
                            StatusPacket.Hide(All.Client, chr);
                        break;
                    default:
                        //Log.Inform("[Use Skill] SkillID = {0}", skill.SkillID);
                        break;
                }
            }
        }

        public static void SkillLevelUp_Req(InPacket lea, Client gc)
        {
            byte Type = lea.ReadByte();
            byte Slot = lea.ReadByte();

            var chr = gc.Character;

            if (chr.SkillBonus < 1)
                return;

            List<Skill> s = chr.Skills.getSkills();
            Skill sl = null;
            foreach (Skill skill in s)
            {
                if (skill.Type == Type && skill.Slot == Slot)
                {
                    sl = skill;
                    break;
                }
            }

            if (sl == null || (sl.SkillID == 1 && sl.SkillLevel + 1 > 5) || (sl.SkillID == 2 && sl.SkillLevel + 1 > 10) || (sl.SkillID == 3 && sl.SkillLevel + 1 > 20) || (sl.SkillID == 4 && sl.SkillLevel + 1 > 20) || sl.SkillLevel + 1 > 20)
                return;

            chr.SkillBonus--;
            sl.SkillLevel++;

            SkillPacket.updateSkillLevel(gc, chr.SkillBonus, Type, Slot, sl.SkillLevel);
        }
    }
}
