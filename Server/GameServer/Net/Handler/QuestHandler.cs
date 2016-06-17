using Server.Common.Constants;
using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Net;
using Server.Packet;

namespace Server.Handler
{
    public static class QuestHandler
    {
        public static void Quest_All_Req(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            int QuestID = lea.ReadShort();
            byte Slot = chr.Items.GetNextFreeSlot(InventoryType.ItemType.Other4);
            Quest Quest = new Quest(QuestID);
            Quest.QuestState = 0x31;
            chr.Quests.Add(Quest);
            QuestPacket.getQuestInfo(gc, chr.Quests.getQuests());
            switch (Quest.QuestID)
            {
                // 
                case 3: // [委託送書]
                    chr.Items.Add(new Item(8990002, 4, Slot));
                    InventoryHandler.UpdateInventory(gc, 4);
                    break;
                case 4: // [委託送書2]
                    chr.Items.Add(new Item(8990003, 4, Slot));
                    InventoryHandler.UpdateInventory(gc, 4);
                    break;
                case 18: // [守衛的慰勞品2]
                    chr.Items.Add(new Item(8990004, 4, Slot));
                    InventoryHandler.UpdateInventory(gc, 4);
                    break;

                // 技能任務(武士)
                case 22: // [利刃術]
                    chr.Items.Add(new Item(8990006, 4, Slot));
                    InventoryHandler.UpdateInventory(gc, 4);
                    break;
                case 23: // [霸刀術]
                    chr.Items.Add(new Item(8990009, 4, Slot));
                    InventoryHandler.UpdateInventory(gc, 4);
                    break;

                // 技能任務(刺客)
                case 32: // [鬼手術]
                    chr.Items.Add(new Item(8990007, 4, Slot));
                    InventoryHandler.UpdateInventory(gc, 4);
                    break;
                case 33: // [利爪術] [Test]
                    chr.Items.Add(new Item(8990010, 4, Slot));
                    InventoryHandler.UpdateInventory(gc, 4);
                    break;

                // 技能任務(道士)
                case 42: // [扇魂術]
                    chr.Items.Add(new Item(8990008, 4, Slot));
                    InventoryHandler.UpdateInventory(gc, 4);
                    break;
                case 43: // [杖擊術]
                    chr.Items.Add(new Item(8990011, 4, Slot));
                    InventoryHandler.UpdateInventory(gc, 4);
                    break;

                // 技能任務(力士)
                case 352: // [ 光熱地斧 ]
                    chr.Items.Add(new Item(8990076, 4, Slot));
                    InventoryHandler.UpdateInventory(gc, 4);
                    break;
                case 353: // [ 光熱地斧 ]
                    chr.Items.Add(new Item(8990077, 4, Slot));
                    InventoryHandler.UpdateInventory(gc, 4);
                    break;

                // 
                case 52: // [送通知單]
                    chr.Items.Add(new Item(8990012, 4, Slot));
                    InventoryHandler.UpdateInventory(gc, 4);
                    break;
                case 53: // [守衛的請託]
                    chr.Items.Add(new Item(8990013, 4, Slot));
                    InventoryHandler.UpdateInventory(gc, 4);
                    break;
                case 59: // [遞送中藥材]
                    chr.Items.Add(new Item(8990018, 4, Slot));
                    InventoryHandler.UpdateInventory(gc, 4);
                    break;
                case 60: // [選擇派系]
                    chr.Items.Add(new Item(8990019, 4, Slot));
                    InventoryHandler.UpdateInventory(gc, 4);
                    break;
                // 怪物 x 1
                case 612:// [神射手轉職]
                    Quest.RequireMonster = 1;
                    break;
                // 怪物 x 2
                case 361:// [ 猛龍承招 ]
                    Quest.RequireMonster = 2;
                    break;
                // 怪物 x 3
                case 16: // [武士 轉職]
                case 19: // [刺客 轉職]
                case 21: // [道士 轉職]
                case 351:// [力士 轉職]
                    Quest.RequireMonster = 3;
                    break;
                // 怪物 x 5
                case 614: // [崩天擊砲](射手)
                    Quest.RequireMonster = 5;
                    break;
                // 怪物 x 10
                case 613: // [恨夜擊弓](射手)
                case 621: // [舞影走](射手)
                    Quest.RequireMonster = 10;
                    break;
                // 怪物 x20
                case 28: // [狂暴怒氣](武士)
                case 29: // [氣力轉換](武士)
                case 30: // [強氣護體](武士)
                case 31: // [強化格擋](武士)
                case 38: // [餵毒術](刺客)
                case 39: // [解毒術](刺客)
                case 40: // [霧影術](刺客)
                case 41: // [閃擊技](刺客)
                case 44: // [玄冰擊](道士)
                case 46: // [冰凍大地](道士)
                case 47: // [矇蔽蝕眼](道士)
                case 48: // [震退](道士)
                case 51: // [陰陽幻移](道士)
                case 358:// [ 壁破力 ](力士)
                case 359:// [ 真功彈強 ](力士) 
                case 360:// [ 武月真氣 ](力士)
                case 620:// [觀首真眼](射手)
                case 622:// [飛鳥壁護](射手)
                    Quest.RequireMonster = 20;
                    break;
                // 怪物 x30
                case 619: // [鎮水液彈](射手)
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
            QuestPacket.UpdateQuest(gc, Quest.CompleteMonster, QuestID, 1, Quest.QuestStage);
        }

        public static void Quest_Done_Req(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            int QuestID = lea.ReadShort();
            Quest Quest = chr.Quests.Quest(QuestID);
            Quest.QuestState = 0x32;
            QuestCompleteHandler(gc, Quest.QuestID);
            chr.Quests.Save();
            QuestPacket.getQuestInfo(gc, chr.Quests.getQuests());
        }

        public static void Quest_Done2_Req(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            int NpcID = lea.ReadInt();
            int ItemID = lea.ReadInt();
            int QuestID = lea.ReadShort();
            Quest Quest = chr.Quests.Quest(QuestID);
            Quest.QuestState = 0x32;
            QuestCompleteHandler(gc, Quest.QuestID);
            chr.Quests.Save();
            QuestPacket.getQuestInfo(gc, chr.Quests.getQuests());
        }

        public static void Quest_Return_Req(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            int NpcID = lea.ReadInt();
            int QuestID = lea.ReadShort();
            int Stage = lea.ReadShort();
            Quest Quest = chr.Quests.Quest(QuestID);
            Quest.QuestStage = (byte)Stage;
            if (Quest.QuestState == 0x31)
                QuestPacket.UpdateQuest(gc, Quest.CompleteMonster, QuestID, 1, (byte)Stage);
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

        public static void LearnSkill(Client gc)
        {
            var chr = gc.Character;
            SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
            GamePacket.Message(gc, 10);
        }

        public static void QuestCompleteHandler(Client gc, int QuestID)
        {
            var chr = gc.Character;
            switch (QuestID)
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
                    switch (QuestID)
                    {
                        case 16: // 武士(1)
                            chr.Attack = 9;
                            chr.MaxAttack = 11;
                            chr.Magic = 4;
                            chr.MaxMagic = 4;
                            chr.Defense = 12;
                            chr.Class = 1;
                            GamePacket.Message(gc, 11);
                            break;
                        case 19: // 刺客(2)
                            chr.Attack = 9;
                            chr.MaxAttack = 11;
                            chr.Magic = 4;
                            chr.MaxMagic = 4;
                            chr.Defense = 12;
                            chr.Class = 2;
                            GamePacket.Message(gc, 12);
                            break;
                        case 21: // 道士(3)
                            chr.Attack = 8;
                            chr.MaxAttack = 10;
                            chr.Magic = 11;
                            chr.MaxMagic = 13;
                            chr.Defense = 14;
                            chr.Class = 3;
                            GamePacket.Message(gc, 13);
                            break;
                        case 351: // 力士(4)
                            chr.Attack = 9;
                            chr.MaxAttack = 11;
                            chr.Magic = 4;
                            chr.MaxMagic = 4;
                            chr.Defense = 12;
                            chr.Class = 4;
                            GamePacket.Message(gc, 58);
                            break;
                        case 612: // 射手(5)
                            chr.Attack = 9;
                            chr.MaxAttack = 11;
                            chr.Magic = 4;
                            chr.MaxMagic = 4;
                            chr.Defense = 12;
                            chr.Class = 5;
                            GamePacket.Message(gc, 136);
                            break;
                    }
                    StatusPacket.getStatusInfo(gc);
                    break;

                // 技能任務(武士)
                case 22: // 利刃術
                    chr.Skills.Add(new Skill(10101, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 23: // 霸刀術
                    chr.Skills.Add(new Skill(10102, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 24: // 劍氣穿心
                    chr.Skills.Add(new Skill(10105, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 25: // 烈空斬
                    chr.Skills.Add(new Skill(10103, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 26: // 開山突擊
                    chr.Skills.Add(new Skill(10106, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 27: // 點穴定身
                    chr.Skills.Add(new Skill(10108, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 28: // 狂暴怒氣
                    chr.Skills.Add(new Skill(10107, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 29: // 氣力轉換
                    chr.Skills.Add(new Skill(10104, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 30: // 強氣護體
                    chr.Skills.Add(new Skill(10109, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 31: // 強化格檔
                    chr.Skills.Add(new Skill(10110, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;

                // 技能任務(刺客)
                case 32: // 鬼手術
                    chr.Skills.Add(new Skill(10201, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 33: // 利爪術
                    chr.Skills.Add(new Skill(10202, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 34: // 索命貫擊
                    chr.Skills.Add(new Skill(10203, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 35: // 崩擊爪
                    chr.Skills.Add(new Skill(10206, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 36: // 雙鏢飛擊
                    chr.Skills.Add(new Skill(10209, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 37: // 疾刺爪
                    chr.Skills.Add(new Skill(10208, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 38: // 餵毒術
                    chr.Skills.Add(new Skill(10204, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 39: // 解毒術
                    chr.Skills.Add(new Skill(10205, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 40: // 霧影術
                    chr.Skills.Add(new Skill(10207, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 41: // 閃擊技
                    chr.Skills.Add(new Skill(10210, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;

                // 技能任務(道士)
                case 42: // 扇魂術
                    chr.Skills.Add(new Skill(10301, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 43: // 杖擊術
                    chr.Skills.Add(new Skill(10302, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 44: // 玄冰擊
                    chr.Skills.Add(new Skill(10304, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 45: // 火箭矢
                    chr.Skills.Add(new Skill(10303, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 46: // 冰凍大地
                    chr.Skills.Add(new Skill(10305, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 47: // 矇蔽蝕眼
                    chr.Skills.Add(new Skill(10306, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 48: // 震退
                    chr.Skills.Add(new Skill(10307, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 49: // 瞬移術
                    chr.Skills.Add(new Skill(10308, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 50: // 防護加持
                    chr.Skills.Add(new Skill(10309, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 51: // 陰陽幻移
                    chr.Skills.Add(new Skill(10310, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;

                // 技能任務(力士)
                case 352: // 光熱地斧
                    chr.Skills.Add(new Skill(10401, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 353: // 逆根強輪
                    chr.Skills.Add(new Skill(10402, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 354: // 太擊出手
                    chr.Skills.Add(new Skill(10403, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 355: // 鐵炮巨針
                    chr.Skills.Add(new Skill(10404, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 356: // 翻天虎退
                    chr.Skills.Add(new Skill(10405, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 357: // 川流旋魔
                    chr.Skills.Add(new Skill(10406, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 358: // 壁破力
                    chr.Skills.Add(new Skill(10407, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 359: // 真功彈強
                    chr.Skills.Add(new Skill(10408, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 360: // 武月真氣
                    chr.Skills.Add(new Skill(10409, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 361: // 猛龍承招
                    chr.Skills.Add(new Skill(10410, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;

                // 技能任務(射手)
                case 613: // 恨夜擊弓
                    chr.Skills.Add(new Skill(10501, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 614: // 崩天擊砲
                    chr.Skills.Add(new Skill(10502, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 615: // 派蚣觸
                    chr.Skills.Add(new Skill(10503, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 616: // 拂焦狂彈
                    chr.Skills.Add(new Skill(10504, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 617: // 鷹爪飛弓
                    chr.Skills.Add(new Skill(10505, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 618: // 軸還飛擊
                    chr.Skills.Add(new Skill(10506, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 619: // 鎮水液彈
                    chr.Skills.Add(new Skill(10507, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 620: // 觀首真眼
                    chr.Skills.Add(new Skill(10508, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 621: // 舞影走
                    chr.Skills.Add(new Skill(10509, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                case 622: // 飛鳥壁護
                    chr.Skills.Add(new Skill(10510, 1, 1, chr.Skills.GetNextFreeSlot(1)));
                    LearnSkill(gc);
                    break;
                default:
                    break;
            }
        }
    }
}