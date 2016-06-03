using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Ghost;
using Server.Net;
using System.Collections.Generic;

namespace Server.Packet
{
    public static class QuestPacket
    {
        public static void getQuestInfo(Client c, List<Quest> quest)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.QUEST_ALL))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(0);
                plew.WriteInt(0);
                plew.WriteInt(0);
                int value = 0;
                foreach (Quest q in quest)
                {
                    if (q.QuestState == 0x20)
                        continue;
                    plew.WriteShort(q.QuestID);
                    plew.WriteByte(1);
                    plew.WriteHexString("00 00 00 00 00 00 00 00 00 00 00 00 00");
                    value++;
                }

                for (int i = value; i < 14; i++)
                {
                    plew.WriteShort(0);
                    plew.WriteByte(0);
                    plew.WriteHexString("00 00 00 00 00 00 00 00 00 00 00 00 00");
                }

                plew.WriteInt(0);

                for (int i = 0; i < 999; i++)
                {
                    int questState = 0;
                    foreach (Quest q in quest)
                    {
                        questState = (q.QuestState != 0x20 && (q.QuestID - 1) == i ? q.QuestState : 0x20);
                        if (questState != 0x20)
                            break;
                    }
                    plew.WriteByte(questState);
                }
                plew.WriteByte(0);
                c.Send(plew);
            }
        }
    }
}
