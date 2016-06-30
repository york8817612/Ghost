using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Ghost.Characters;
using Server.Net;

namespace Server.Packet
{
    public static class GamePacket
    {
        public static void Game_Log_Ack(Client c, int characterID)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.GAMELOG))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(characterID);
                plew.WriteInt(ServerConstants.CLIENT_VERSION);
                plew.WriteInt(14199);
                plew.WriteInt(57429138); // TimeLogin
                plew.WriteByte(byte.Parse(c.Title.Split('.')[0]));
                plew.WriteByte(byte.Parse(c.Title.Split('.')[1]));
                plew.WriteByte(byte.Parse(c.Title.Split('.')[2]));
                plew.WriteByte(byte.Parse(c.Title.Split('.')[3]));
                plew.WriteLong(c.SessionID); // Key

                c.Send(plew);
            }
        }

        public static void getNotice(Client c, byte type, string message)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.NOTICE))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteByte(type);
                plew.WriteString(message, 60);
                plew.WriteHexString("00 00 00 00 00 00 00");

                c.Send(plew);
            }
        }

        public static void InvenUseSpendShout(Client c, Character chr, string message)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_USESPEND_SHOUT_ACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteByte(1); // 頻道
                plew.WriteString(chr.Name, 20);
                plew.WriteString(message, 65);
                plew.WriteShort(1); // 類型
                c.Send(plew);
            }
        }

        public static void Message(Client c, int Message)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.MESSAGE))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(31102);
                plew.WriteInt(Message);
                c.Send(plew);
            }
        }

        public static void getQuickSlot(Client c, CharacterKeyMap keymaps)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.QUICKSLOTALL))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                // Z
                plew.WriteInt(keymaps.SkillID("Z")); // 技能ID
                plew.WriteShort(keymaps.Type("Z")); // 技能類型
                plew.WriteShort(keymaps.Slot("Z")); // 技能欄位

                // X
                plew.WriteInt(keymaps.SkillID("X")); // 技能ID
                plew.WriteShort(keymaps.Type("X")); // 技能類型
                plew.WriteShort(keymaps.Slot("X")); // 技能欄位

                // C
                plew.WriteInt(keymaps.SkillID("C")); // 技能ID
                plew.WriteShort(keymaps.Type("C")); // 技能類型
                plew.WriteShort(keymaps.Slot("C")); // 技能欄位

                // V
                plew.WriteInt(keymaps.SkillID("V")); // 技能ID
                plew.WriteShort(keymaps.Type("V")); // 技能類型
                plew.WriteShort(keymaps.Slot("V")); // 技能欄位


                // B
                plew.WriteInt(keymaps.SkillID("B")); // 技能ID
                plew.WriteShort(keymaps.Type("B")); // 技能類型
                plew.WriteShort(keymaps.Slot("B")); // 技能欄位

                // N
                plew.WriteInt(keymaps.SkillID("N")); // 技能ID
                plew.WriteShort(keymaps.Type("N")); // 技能類型
                plew.WriteShort(keymaps.Slot("N")); // 技能欄位

                // ============================================

                // 1
                plew.WriteInt(keymaps.SkillID("1")); // 技能ID
                plew.WriteShort(keymaps.Type("1")); // 技能類型
                plew.WriteShort(keymaps.Slot("1")); // 技能欄位

                // 2
                plew.WriteInt(keymaps.SkillID("2")); // 技能ID
                plew.WriteShort(keymaps.Type("2")); // 技能類型
                plew.WriteShort(keymaps.Slot("2")); // 技能欄位

                // 3
                plew.WriteInt(keymaps.SkillID("3")); // 技能ID
                plew.WriteShort(keymaps.Type("3")); // 技能類型
                plew.WriteShort(keymaps.Slot("3")); // 技能欄位

                // 4
                plew.WriteInt(keymaps.SkillID("4")); // 技能ID
                plew.WriteShort(keymaps.Type("4")); // 技能類型
                plew.WriteShort(keymaps.Slot("4")); // 技能欄位


                // 5
                plew.WriteInt(keymaps.SkillID("5")); // 技能ID
                plew.WriteShort(keymaps.Type("5")); // 技能類型
                plew.WriteShort(keymaps.Slot("5")); // 技能欄位

                // 6
                plew.WriteInt(keymaps.SkillID("6")); // 技能ID
                plew.WriteShort(keymaps.Type("6")); // 技能類型
                plew.WriteShort(keymaps.Slot("6")); // 技能欄位

                // ============================================

                // Insert
                plew.WriteInt(keymaps.SkillID("Insert")); // 技能ID
                plew.WriteShort(keymaps.Type("Insert")); // 技能類型
                plew.WriteShort(keymaps.Slot("Insert")); // 技能欄位

                // Home
                plew.WriteInt(keymaps.SkillID("Home")); // 技能ID
                plew.WriteShort(keymaps.Type("Home")); // 技能類型
                plew.WriteShort(keymaps.Slot("Home")); // 技能欄位

                // PageUp
                plew.WriteInt(keymaps.SkillID("PageUp")); // 技能ID
                plew.WriteShort(keymaps.Type("PageUp")); // 技能類型
                plew.WriteShort(keymaps.Slot("PageUp")); // 技能欄位

                // Delete
                plew.WriteInt(keymaps.SkillID("Delete")); // 技能ID
                plew.WriteShort(keymaps.Type("Delete")); // 技能類型
                plew.WriteShort(keymaps.Slot("Delete")); // 技能欄位


                // End
                plew.WriteInt(keymaps.SkillID("End")); // 技能ID
                plew.WriteShort(keymaps.Type("End")); // 技能類型
                plew.WriteShort(keymaps.Slot("End")); // 技能欄位

                // PageDown
                plew.WriteInt(keymaps.SkillID("PageDown")); // 技能ID
                plew.WriteShort(keymaps.Type("PageDown")); // 技能類型
                plew.WriteShort(keymaps.Slot("PageDown")); // 技能欄位

                // ============================================

                // 7
                plew.WriteInt(keymaps.SkillID("7")); // 技能ID
                plew.WriteShort(keymaps.Type("7")); // 技能類型
                plew.WriteShort(keymaps.Slot("7")); // 技能欄位

                // 8
                plew.WriteInt(keymaps.SkillID("8")); // 技能ID
                plew.WriteShort(keymaps.Type("8")); // 技能類型
                plew.WriteShort(keymaps.Slot("8")); // 技能欄位

                // 9
                plew.WriteInt(keymaps.SkillID("9")); // 技能ID
                plew.WriteShort(keymaps.Type("9")); // 技能類型
                plew.WriteShort(keymaps.Slot("9")); // 技能欄位

                // 0
                plew.WriteInt(keymaps.SkillID("0")); // 技能ID
                plew.WriteShort(keymaps.Type("0")); // 技能類型
                plew.WriteShort(keymaps.Slot("0")); // 技能欄位


                // -
                plew.WriteInt(keymaps.SkillID("-")); // 技能ID
                plew.WriteShort(keymaps.Type("-")); // 技能類型
                plew.WriteShort(keymaps.Slot("-")); // 技能欄位

                // =
                plew.WriteInt(keymaps.SkillID("=")); // 技能ID
                plew.WriteShort(keymaps.Type("=")); // 技能類型
                plew.WriteShort(keymaps.Slot("=")); // 技能欄位
                c.Send(plew);
            }
        }

        public static void FW_DISCOUNTFACTION(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.FW_DISCOUNTFACTION))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteHexString("00 00 00 00 64 00 00 00 00 00 00 00 64 00 00 00 00 70 40 00 E8 03 D2 A8 74 A9 00 00 84 D1");

                c.Send(plew);
            }
        }

        public static void PuzzleInfo(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PUZZLE))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteHexString("40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40 40");
                c.Send(plew);
            }
        }

        public static void PuzzleUpdate(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PUZZLE_UPDATE))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteHexString("31 4D 0F 00"); // 怪物ID
                plew.WriteHexString("20 00 43 E4");
                c.Send(plew);
            }
        }
    }
}