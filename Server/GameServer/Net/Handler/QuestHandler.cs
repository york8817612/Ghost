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
            Log.Inform("任務ID = {0}", QuestID);
        }

        public static void Quest_Update_Req(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            int QuestID = lea.ReadShort();
            int MonsterID = lea.ReadInt();
            Quest Quest = chr.Quests.Quest(QuestID);
            int NeedMonster = 3;
            Quest.KillMonster++;
            QuestPacket.UpdateQuest(gc, Quest.KillMonster, QuestID, (byte)1, Quest.KillMonster == NeedMonster ? (byte)0 : (byte)1);
        }

        public static void Quest_Done_Req(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            int QuestID = lea.ReadShort();
            Quest Quest = chr.Quests.Quest(QuestID);
            Quest.QuestState = 0x32;
            switch (Quest.QuestID)
            {
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
                case 614:
                    chr.Skills.Add(new Skill(10501, 1, 1, 0));
                    break;
                case 615:
                    chr.Skills.Add(new Skill(10502, 1, 1, 1));
                    break;
                case 616:
                    chr.Skills.Add(new Skill(10503, 1, 1, 2));
                    break;
                case 617:
                    chr.Skills.Add(new Skill(10504, 1, 1, 3));
                    break;
                case 618:
                    chr.Skills.Add(new Skill(10505, 1, 1, 4));
                    break;
                case 619:
                    chr.Skills.Add(new Skill(10506, 1, 1, 5));
                    break;
                case 620:
                    chr.Skills.Add(new Skill(10507, 1, 1, 6));
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
