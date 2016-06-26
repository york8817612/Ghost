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
                case 33: // [利爪術]
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
                case 64: // 
                    chr.Items.Add(new Item(8990020, 4, Slot));
                    InventoryHandler.UpdateInventory(gc, 4);
                    break;
                case 77: // [兩個金塊]
                    chr.Items.Add(new Item(8990023, 4, Slot));
                    InventoryHandler.UpdateInventory(gc, 4);
                    break;
                case 80: // [薇薇安的腰]
                    chr.Items.Add(new Item(8990026, 4, Slot));
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
                // [擊退清野江怪物]
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
                case 79: // [製鹽的石磨]
                case 358:// [ 壁破力 ](力士)
                case 359:// [ 真功彈強 ](力士) 
                case 360:// [ 武月真氣 ](力士)
                case 620:// [觀首真眼](射手)
                case 622:// [飛鳥壁護](射手)
                    Quest.RequireMonster = 20;
                    break;
                // 怪物 x30
                case 85: // [少女的眼淚第2階段]
                case 619: // [鎮水液彈](射手)
                    Quest.RequireMonster = 30;
                    break;
                // 怪物 x100
                case 109: // [遺失的仙女服]
                    Quest.RequireMonster = 100;
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
            int WeaponID = 0;
            foreach (Item item in chr.Items)
            {
                if (item.Type == (byte)InventoryType.ItemType.Equip && item.Slot == (byte)InventoryType.EquipType.Weapon)
                {
                    WeaponID = item.ItemID;
                    break;
                }
            }
            switch (QuestID)
            {
                case 2: // [蒐集美人魚鱗片]
                    chr.Money += 200;
                    InventoryPacket.getInvenMoney(gc, chr.Money, 200);
                    break;
                case 3: // [委託送書]
                    chr.Money += 300;
                    chr.Exp += 30;
                    chr.Fame += 1;
                    InventoryPacket.getInvenMoney(gc, chr.Money, 300);
                    StatusPacket.UpdateExp(gc);
                    StatusPacket.UpdateFame(gc, 1);
                    break;
                case 4: // [委託送書2]
                    chr.Money += 400;
                    chr.Exp += 30;
                    chr.Fame += 1;
                    InventoryPacket.getInvenMoney(gc, chr.Money, 400);
                    StatusPacket.UpdateExp(gc);
                    StatusPacket.UpdateFame(gc, 1);
                    break;
                case 5: // [農夫的請託]
                    chr.Money += 600;
                    chr.Exp += 50;
                    chr.Fame += 1;
                    InventoryPacket.getInvenMoney(gc, chr.Money, 600);
                    StatusPacket.UpdateExp(gc);
                    StatusPacket.UpdateFame(gc, 1);
                    break;
                case 6: // [金係係武器店的工作服]
                    chr.Money += 1200;
                    chr.Exp += 200;
                    chr.Fame += 5;
                    InventoryPacket.getInvenMoney(gc, chr.Money, 1200);
                    StatusPacket.UpdateExp(gc);
                    StatusPacket.UpdateFame(gc, 5);
                    break;
                case 7: // [寶芝林的藥材]
                    chr.Money += 1500;
                    chr.Exp += 300;
                    chr.Items.Add(new Item(8810011, (byte)InventoryType.ItemType.Spend3, chr.Items.GetNextFreeSlot(InventoryType.ItemType.Spend3), 20));
                    chr.Items.Add(new Item(8820011, (byte)InventoryType.ItemType.Spend3, chr.Items.GetNextFreeSlot(InventoryType.ItemType.Spend3), 40));
                    InventoryPacket.getInvenMoney(gc, chr.Money, 1500);
                    StatusPacket.UpdateExp(gc);
                    InventoryHandler.UpdateInventory(gc, 3);
                    break;
                case 11: // [守衛的慰勞品]
                    chr.Exp += 100;
                    chr.Fame += 2;
                    StatusPacket.UpdateExp(gc);
                    StatusPacket.UpdateFame(gc, 2);
                    break;
                case 14: // [封印豬大長]
                    chr.Money += 54000;
                    chr.Exp += 5000;
                    InventoryPacket.getInvenMoney(gc, chr.Money, 54000);
                    StatusPacket.UpdateExp(gc);
                    break;
                case 52: // [送通知單]
                    chr.Money += 500;
                    chr.Exp += 40;
                    chr.Fame += 1;
                    InventoryPacket.getInvenMoney(gc, chr.Money, 500);
                    StatusPacket.UpdateExp(gc);
                    StatusPacket.UpdateFame(gc, 1);
                    break;
                case 53: // [守衛的請託]
                    chr.Money += 500;
                    chr.Exp += 40;
                    chr.Fame += 1;
                    InventoryPacket.getInvenMoney(gc, chr.Money, 500);
                    StatusPacket.UpdateExp(gc);
                    StatusPacket.UpdateFame(gc, 1);
                    break;
                case 55: // [害了了防具店的衣服材料]
                    chr.Money += 10000;
                    chr.Items.Add(new Item(8510031, (byte)InventoryType.ItemType.Equip2, chr.Items.GetNextFreeSlot(InventoryType.ItemType.Equip2)));
                    InventoryPacket.getInvenMoney(gc, chr.Money, 10000);
                    InventoryHandler.UpdateInventory(gc, 2);
                    break;
                case 56: // [金係係武器店的關節炎]
                    chr.Money += 30000;
                    chr.Exp += 8000;
                    InventoryPacket.getInvenMoney(gc, chr.Money, 30000);
                    StatusPacket.UpdateExp(gc);
                    break;
                case 58: // [封印狗骨頭]
                    chr.Money += 270000;
                    chr.Exp += 15000;
                    InventoryPacket.getInvenMoney(gc, chr.Money, 270000);
                    StatusPacket.UpdateExp(gc);
                    break;
                case 59: // [遞送中藥材]
                    chr.Money += 60000;
                    chr.Exp += 20000;
                    InventoryPacket.getInvenMoney(gc, chr.Money, 60000);
                    StatusPacket.UpdateExp(gc);
                    break;
                case 114: // [新外型]
                    chr.Money += 10000;
                    chr.Fame += 1;
                    InventoryPacket.getInvenMoney(gc, chr.Money, 10000);
                    StatusPacket.UpdateFame(gc, 1);
                    break;
                case 115: // [老父親的白內障]
                    chr.Exp += 1000;
                    chr.Fame += 2;
                    chr.Items.Add(new Item(8820031, (byte)InventoryType.ItemType.Spend3, chr.Items.GetNextFreeSlot(InventoryType.ItemType.Spend3), 5));
                    chr.Items.Add(new Item(8850021, (byte)InventoryType.ItemType.Spend3, chr.Items.GetNextFreeSlot(InventoryType.ItemType.Spend3), 3));
                    StatusPacket.UpdateExp(gc);
                    StatusPacket.UpdateFame(gc, 2);
                    InventoryHandler.UpdateInventory(gc, 3);
                    break;
                case 116: // [幫忙家務事1]
                    chr.Exp += 1500;
                    chr.Fame += 1;
                    chr.Items.Add(new Item(8820031, (byte)InventoryType.ItemType.Spend3, chr.Items.GetNextFreeSlot(InventoryType.ItemType.Spend3), 10));
                    StatusPacket.UpdateExp(gc);
                    StatusPacket.UpdateFame(gc, 1);
                    InventoryHandler.UpdateInventory(gc, 3);
                    break;
                case 128: // [職務代理]
                    chr.Fame += 1;
                    chr.Items.Add(new Item(8810031, (byte)InventoryType.ItemType.Spend3, chr.Items.GetNextFreeSlot(InventoryType.ItemType.Spend3), 5));
                    chr.Items.Add(new Item(8310241, (byte)InventoryType.ItemType.Equip2, chr.Items.GetNextFreeSlot(InventoryType.ItemType.Equip2)));
                    StatusPacket.UpdateFame(gc, 1);
                    InventoryHandler.UpdateInventory(gc, 3);
                    InventoryHandler.UpdateInventory(gc, 2);
                    break;
                case 129: // [有去無回]
                    chr.Money += 50000;
                    InventoryPacket.getInvenMoney(gc, chr.Money, 50000);
                    break;
                case 675: // [ 往黃泉之路1 ]
                    chr.Exp += 1500;
                    StatusPacket.UpdateExp(gc);
                    break;
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
                            chr.Attack = 3;
                            chr.MaxAttack = 5;
                            chr.Magic = 4;
                            chr.MaxMagic = 4;
                            chr.Defense = 12;
                            chr.Class = 1;
                            if (WeaponID != 0)
                                 InventoryHandler.UpdateCharacterInventoryStatus(gc, WeaponID, true);
                            GamePacket.Message(gc, 11);
                            break;
                        case 19: // 刺客(2)
                            chr.Attack = 3;
                            chr.MaxAttack = 5;
                            chr.Magic = 4;
                            chr.MaxMagic = 4;
                            chr.Defense = 12;
                            chr.Class = 2;
                            if (WeaponID != 0)
                                InventoryHandler.UpdateCharacterInventoryStatus(gc, WeaponID, true);
                            GamePacket.Message(gc, 12);
                            break;
                        case 21: // 道士(3)
                            chr.Attack = 3;
                            chr.MaxAttack = 5;
                            chr.Magic = 4;
                            chr.MaxMagic = 4;
                            chr.Defense = 12;
                            chr.Class = 3;
                            if (WeaponID != 0)
                                InventoryHandler.UpdateCharacterInventoryStatus(gc, WeaponID, true);
                            GamePacket.Message(gc, 13);
                            break;
                        case 351: // 力士(4)
                            chr.Attack = 3;
                            chr.MaxAttack = 5;
                            chr.Magic = 4;
                            chr.MaxMagic = 4;
                            chr.Defense = 12;
                            chr.Class = 4;
                            if (WeaponID != 0)
                                InventoryHandler.UpdateCharacterInventoryStatus(gc, WeaponID, true);
                            GamePacket.Message(gc, 58);
                            break;
                        case 612: // 射手(5)
                            chr.Attack = 3;
                            chr.MaxAttack = 5;
                            chr.Magic = 4;
                            chr.MaxMagic = 4;
                            chr.Defense = 12;
                            chr.Class = 5;
                            if (WeaponID != 0)
                                InventoryHandler.UpdateCharacterInventoryStatus(gc, WeaponID, true);
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