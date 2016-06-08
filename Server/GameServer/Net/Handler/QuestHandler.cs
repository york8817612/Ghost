using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Net;
using Server.Packet;

namespace Server.Handler
{
    class QuestHandler
    {
        public static void Quest_All_Req(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            int QuestID = lea.ReadShort();
            Quest Quest = new Quest(QuestID);
            Quest.QuestState = 0x31;
            chr.Quests.Add(Quest);
            QuestPacket.getQuestInfo(gc, chr.Quests.getQuests());
            switch (Quest.QuestID)
            {
                // 怪物 x 3
                case 16: // 武士轉職
                case 19: // 刺客轉職
                case 21: // 道士轉職
                case 351: // 力士轉職
                case 612: // 射手轉職
                    Quest.RequireMonster = 3;
                    break;
                // 怪物 x 5
                case 614: // 崩天擊砲(射手)
                    Quest.RequireMonster = 5;
                    break;
                // 怪物 x 10
                case 613: // 恨夜擊弓(射手)
                case 621: // 舞影走(射手)
                    Quest.RequireMonster = 10;
                    break;
                // 怪物 x20
                case 28: // 狂暴怒氣(武士)
                case 29: // 氣力轉換(武士)
                case 30: // 強氣護體(武士)
                case 31: // 強化格檔(武士)
                case 38: // 餵毒術(刺客)
                case 39: // 解毒術(刺客)
                case 40: // 霧影術(刺客)
                case 41: // 閃擊技(刺客)
                case 620: // 觀首真眼(射手)
                case 622: // 飛鳥壁護(射手)
                    Quest.RequireMonster = 20;
                    break;
                // 怪物 x30
                case 619: // 鎮水液彈(射手)
                    Quest.RequireMonster = 30;
                    break;
                default:
                    Quest.RequireMonster = 100;
                    break;
            }
            Log.Inform("QuestID = {0}", QuestID);
        }

        public static void Quest_Update_Req(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            int QuestID = lea.ReadShort();
            int MonsterID = lea.ReadInt();
            Quest Quest = chr.Quests.Quest(QuestID);
            if (Quest.RequireMonster > 0)
                Quest.CompleteMonster++;
            QuestPacket.UpdateQuest(gc, Quest.CompleteMonster, QuestID, (byte)1, Quest.CompleteMonster == Quest.RequireMonster ? (byte)0 : (byte)1);
        }

        public static void Quest_Done_Req(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            int QuestID = lea.ReadShort();
            Quest Quest = chr.Quests.Quest(QuestID);
            Quest.QuestState = 0x32;
            switch (Quest.QuestID)
            {
                // 轉職任務
                case 16: // 武士(1)
                case 19: // 刺客(2)
                case 21: // 道士(3)
                case 351: // 力士(4)
                case 612: // 射手(5)
                    chr.Str = 3;
                    chr.Dex = 3;
                    chr.Vit = 3;
                    chr.Int = 3;
                    chr.AbilityBonus = 40;
                    switch (Quest.QuestID)
                    {
                        case 16:
                            chr.Class = 1;
                            break;
                        case 19:
                            chr.Class = 2;
                            break;
                        case 21:
                            chr.Class = 3;
                            break;
                        case 351:
                            chr.Class = 4;
                            break;
                        case 612:
                            chr.Class = 5;
                            break;
                    }
                    StatusPacket.getStatusInfo(gc);
                    break;
                // 技能任務(武士)
                case 22: // 利刃術
                    chr.Skills.Add(new Skill(10101, 1, 1, 0));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 23: // 霸刀術
                    chr.Skills.Add(new Skill(10102, 1, 1, 1));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 24: // 劍氣穿心
                    chr.Skills.Add(new Skill(10105, 1, 1, 2));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 25: // 烈空斬
                    chr.Skills.Add(new Skill(10103, 1, 1, 3));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 26: // 開山突擊
                    chr.Skills.Add(new Skill(10106, 1, 1, 4));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 27: // 點穴定身
                    chr.Skills.Add(new Skill(10108, 1, 1, 5));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 28: // 狂暴怒氣
                    chr.Skills.Add(new Skill(10107, 1, 1, 6));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 29: // 氣力轉換
                    chr.Skills.Add(new Skill(10104, 1, 1, 7));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 30: // 強氣護體
                    chr.Skills.Add(new Skill(10109, 1, 1, 8));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 31: // 強化格檔
                    chr.Skills.Add(new Skill(10110, 1, 1, 9));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                // 技能任務(刺客)
                case 32: // 鬼手術
                    chr.Skills.Add(new Skill(10201, 1, 1, 0));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 33: // 利爪術
                    chr.Skills.Add(new Skill(10202, 1, 1, 1));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 34: // 索命貫擊
                    chr.Skills.Add(new Skill(10203, 1, 1, 2));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 35: // 崩擊爪
                    chr.Skills.Add(new Skill(10206, 1, 1, 3));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 36: // 雙鏢飛擊
                    chr.Skills.Add(new Skill(10209, 1, 1, 4));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 37: // 疾刺爪
                    chr.Skills.Add(new Skill(10208, 1, 1, 5));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 38: // 餵毒術
                    chr.Skills.Add(new Skill(10204, 1, 1, 6));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 39: // 解毒術
                    chr.Skills.Add(new Skill(10205, 1, 1, 7));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 40: // 霧影術
                    chr.Skills.Add(new Skill(10207, 1, 1, 8));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 41: // 閃擊技
                    chr.Skills.Add(new Skill(10210, 1, 1, 9));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                // 技能任務(射手)
                case 613: // 恨夜擊弓
                    chr.Skills.Add(new Skill(10501, 1, 1, 0));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 614: // 崩天擊砲
                    chr.Skills.Add(new Skill(10502, 1, 1, 1));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 615: // 派蚣觸
                    chr.Skills.Add(new Skill(10503, 1, 1, 2));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 616: // 拂焦狂彈
                    chr.Skills.Add(new Skill(10504, 1, 1, 3));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 617: // 鷹爪飛弓
                    chr.Skills.Add(new Skill(10505, 1, 1, 4));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 618: // 軸還飛擊
                    chr.Skills.Add(new Skill(10506, 1, 1, 5));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 619: // 鎮水液彈
                    chr.Skills.Add(new Skill(10507, 1, 1, 6));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 620: // 觀首真眼
                    chr.Skills.Add(new Skill(10508, 1, 1, 7));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 621: // 舞影走
                    chr.Skills.Add(new Skill(10509, 1, 1, 8));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                case 622: // 飛鳥壁護
                    chr.Skills.Add(new Skill(10510, 1, 1, 9));
                    SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
                    break;
                default:
                    break;
            }
            QuestPacket.getQuestInfo(gc, chr.Quests.getQuests());
        }

        public static void Quest_GiveUp_Req(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            int QuestID = lea.ReadShort();
            Quest Quest = chr.Quests.Quest(QuestID);
            Quest.QuestState = 0x20;
            chr.Quests.Remove(Quest);
            QuestPacket.getQuestInfo(gc, chr.Quests.getQuests());
        }
    }
}
