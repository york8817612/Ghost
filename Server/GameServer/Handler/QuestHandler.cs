using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Ghost.Characters;

namespace Server.Handler
{
    class QuestHandler
    {
        public static void Quest_All_Req(InPacket lea, Client gc)
        {
            short QuestID = lea.ReadShort();
            short Value = lea.ReadShort();
            Quest quest = new Quest(QuestID);
            quest.QuestState = 0x31;
            gc.Character.Quests.Add(quest);
            QuestPacket.getQuestInfo(gc, gc.Character.Quests.getQuests());
        }

        public static void Quest_Done_Req(InPacket lea, Client gc)
        {
            short QuestID = lea.ReadShort();
        }
    }
}
