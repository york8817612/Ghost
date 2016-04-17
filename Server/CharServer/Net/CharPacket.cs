using Server.Characters;
using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Common.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Net
{
    public static class CharPacket
    {
        public static void MyChar_Info_Ack(Client gc, List<Character> chars)
        {
            using (OutPacket plew = new OutPacket(ServerMessage.MYCHAR_INFO_ACK))
            {

                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(chars.Count);
                for (int i = 0; i < 4; i++)
                {
                    getCharactersData(plew, (i < chars.Count) ? chars[i] : null);
                }
                plew.WriteHexString("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 01 00 00 00");

                gc.Send(plew);
            }
        }

        public static void Generate_CharLook_Ack(Client gc)
        {
            using (OutPacket plew = new OutPacket(ServerMessage.CREATE_MYCHAR_ACK))
            {

                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteHexString("01 00 18 00");
                plew.WriteInt(1);

                gc.Send(plew);
            }
        }

        /*
         * -2 = 無法創立新角色，請先購買角色擴充道具，最多可同時創立4個角色。
         * -1 = 使用中的名字
         * 0 = 現在無法創立角色，請稍後
         * 1 = 創建成功
         * 2 = 創建成功
         * 3 = 創建成功
         * 4 = 創建成功
         * else = 未知的錯誤
         */
        public static void Create_MyChar_Ack(Client gc, int pos)
        {
            using (OutPacket plew = new OutPacket(ServerMessage.CREATE_MYCHAR_ACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteHexString("01 03 A6 FF");
                plew.WriteInt(pos);

                gc.Send(plew);
            }
        }


        /*
         * 0 = 使用中的名字
         * 1 = 此名稱可以使用
         * 2 = 無法創立新角色，請先購買角色擴充道具，最多可同時創立4個角色。
         * else = 未知的錯誤
         */
        public static void Check_SameName_Ack(Client gc, int state)
        {
            using (OutPacket plew = new OutPacket(ServerMessage.CHECK_SAMENAME_ACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(state);

                gc.Send(plew);
            }
        }

        /*
         * -2 = 未知的錯誤
         * -1 = 角色刪除失敗
         * 1 = 角色刪除成功
         * 2 = 角色刪除成功
         * 3 = 角色刪除成功
         * 4 = 角色刪除成功
         * else = 創建1小時後才能刪除
         */
        public static void Delete_MyChar_Ack(Client gc, int position)
        {
            using (OutPacket plew = new OutPacket(ServerMessage.DELETE_MYCHAR_ACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(position);
                plew.WriteInt(1);
                plew.WriteInt(1);

                gc.Send(plew);
            }
        }

        public static void getCharactersData(OutPacket plew, Character chr)
        {
            plew.WriteString(chr != null ? chr.Name : "", 20);
            plew.WriteString(chr != null ? chr.Title : "", 20);
            plew.WriteByte(1);
            plew.WriteByte(chr != null ? chr.Gender : (byte)0);
            plew.WriteByte(chr != null ? chr.Level : (byte)0);
            plew.WriteByte(chr != null ? chr.Class : (byte)0);
            plew.WriteByte(chr != null ? chr.ClassLV : (byte)0);
            plew.WriteByte(0);
            plew.WriteByte(chr != null ? (byte)0xFF : (byte)0);
            plew.WriteByte(0);
            plew.WriteShort(chr != null ? (short)1 : (short)0);
            plew.WriteShort(chr != null ? (short)1 : (short)0);
            plew.WriteShort(chr != null ? (short)1 : (short)0);
            plew.WriteShort(chr != null ? (short)1 : (short)0);

            Dictionary<ItemTypeConstants.EquipType, int> eq = new Dictionary<ItemTypeConstants.EquipType, int>();
            if (chr != null)
            {
                foreach (Item it in chr.Items)
                {
                    switch (it.slot)
                    {
                        case (byte)ItemTypeConstants.EquipType.Weapon:
                            eq.Add(ItemTypeConstants.EquipType.Weapon, it.ItemID);
                            break;
                        case (byte)ItemTypeConstants.EquipType.Dress:
                            eq.Add(ItemTypeConstants.EquipType.Dress, it.ItemID);
                            break;
                        case (byte)ItemTypeConstants.EquipType.Hat:
                            eq.Add(ItemTypeConstants.EquipType.Hat, it.ItemID);
                            break;
                        case (byte)ItemTypeConstants.EquipType.Face:
                            eq.Add(ItemTypeConstants.EquipType.Face, it.ItemID);
                            break;
                        case (byte)ItemTypeConstants.EquipType.Face2:
                            eq.Add(ItemTypeConstants.EquipType.Face2, it.ItemID);
                            break;
                        case (byte)ItemTypeConstants.EquipType.Mantle:
                            eq.Add(ItemTypeConstants.EquipType.Mantle, it.ItemID);
                            break;
                        case (byte)ItemTypeConstants.EquipType.Outfit:
                            eq.Add(ItemTypeConstants.EquipType.Outfit, it.ItemID);
                            break;
                    }
                }
            }
            plew.WriteInt(eq.ContainsKey(ItemTypeConstants.EquipType.Weapon) ? eq[ItemTypeConstants.EquipType.Weapon] : 0); // 武器[Weapon] 8010101
            plew.WriteInt(eq.ContainsKey(ItemTypeConstants.EquipType.Outfit) ? eq[ItemTypeConstants.EquipType.Outfit] : 0); // [Outfit]     8160351
            plew.WriteInt(eq.ContainsKey(ItemTypeConstants.EquipType.Face) ? eq[ItemTypeConstants.EquipType.Face] : 0);     // 臉下[face2]  9410021
            plew.WriteInt(eq.ContainsKey(ItemTypeConstants.EquipType.Face2) ? eq[ItemTypeConstants.EquipType.Face2] : 0);   // 臉上[face]   8710013
            plew.WriteInt(eq.ContainsKey(ItemTypeConstants.EquipType.Hat) ? eq[ItemTypeConstants.EquipType.Hat] : 0);       // 帽子[hat]    8610011
            plew.WriteInt(chr != null ? chr.Eyes : 0);                                                                      // 眼睛[eye]    9110011
            plew.WriteInt(eq.ContainsKey(ItemTypeConstants.EquipType.Mantle) ? eq[ItemTypeConstants.EquipType.Mantle] : 0); // 服裝[outfit] 9510081
            plew.WriteInt(eq.ContainsKey(ItemTypeConstants.EquipType.Dress) ? eq[ItemTypeConstants.EquipType.Dress] : 0);   // 披風[mantle] 8493122
            plew.WriteInt(chr != null ? chr.Hair : 0);                                                                      // 頭髮[hair]   9010011
            plew.WriteInt(0);
            plew.WriteInt(0);
            plew.WriteInt(chr != null ? chr.Position : 0);
            plew.WriteInt(chr != null ? 1 : 0);
            plew.WriteInt(0);
        }
    }
}
