using Server.Characters;
using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Common.Net;
using System.Collections.Generic;

namespace Server.Ghost
{
    public static class CharPacket
    {
        public static void MyChar_Info_Ack(Client gc, List<Character> chars)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.MYCHAR_INFO_ACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(chars.Count);
                //for (int i = 0; i < 4; i++)
                //{
                //    getCharactersData(plew, (i < chars.Count) ? chars[i] : null);
                //}
                for (int i = 0; i < 4; i++)
                {
                    bool isCreate = false;
                    foreach (Character chr in chars)
                    {
                        if (chr.Position == (i + 1))
                        {
                            getCharactersData(plew, chr);
                            isCreate = true;
                            break;
                        }
                    }
                    if (!isCreate)
                    {
                        getCharactersData(plew, null);
                    }
                }
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
            using (OutPacket plew = new OutPacket(ServerOpcode.CHECK_SAMENAME_ACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(state);

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
        public static void Create_MyChar_Ack(Client gc, int position)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.CREATE_MYCHAR_ACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(position);

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
            using (OutPacket plew = new OutPacket(ServerOpcode.DELETE_MYCHAR_ACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(position);

                gc.Send(plew);
            }
        }

        public static void getCharactersData(OutPacket plew, Character chr)
        {
            plew.WriteString(chr != null ? chr.Name : "", 20);
            plew.WriteString(chr != null ? chr.Title : "", 20);
            plew.WriteByte(chr != null ? chr.Gender : 0);
            plew.WriteByte(chr != null ? chr.Level : 0);
            plew.WriteByte(chr != null ? chr.Class : 0);
            plew.WriteByte(chr != null ? chr.ClassLevel : 0);
            plew.WriteByte(0);
            plew.WriteByte(0);
            plew.WriteByte(0);
            plew.WriteByte(0);
            plew.WriteShort(chr != null ? 1 : 0);
            plew.WriteShort(chr != null ? 1 : 0);

            Dictionary<ItemTypeConstants.EquipType, int> eq = new Dictionary<ItemTypeConstants.EquipType, int>();
            if (chr != null)
            {
                foreach (Item im in chr.Items)
                {
                    if (im.type != (byte)ItemTypeConstants.ItemType.Equip)
                        continue;
                    switch (im.slot)
                    {
                        case (byte)ItemTypeConstants.EquipType.Weapon:
                            eq.Add(ItemTypeConstants.EquipType.Weapon, im.ItemID);
                            break;
                        case (byte)ItemTypeConstants.EquipType.Outfit:
                            eq.Add(ItemTypeConstants.EquipType.Outfit, im.ItemID);
                            break;
                        case (byte)ItemTypeConstants.EquipType.Mantle:
                            eq.Add(ItemTypeConstants.EquipType.Mantle, im.ItemID);
                            break;
                        case (byte)ItemTypeConstants.EquipType.Hat:
                            eq.Add(ItemTypeConstants.EquipType.Hat, im.ItemID);
                            break;
                        case (byte)ItemTypeConstants.EquipType.Face:
                            eq.Add(ItemTypeConstants.EquipType.Face, im.ItemID);
                            break;
                        case (byte)ItemTypeConstants.EquipType.Dress:
                            eq.Add(ItemTypeConstants.EquipType.Dress, im.ItemID);
                            break;
                        case (byte)ItemTypeConstants.EquipType.Face2:
                            eq.Add(ItemTypeConstants.EquipType.Face2, im.ItemID);
                            break;
                    }
                }
            }
            plew.WriteInt(eq.ContainsKey(ItemTypeConstants.EquipType.Weapon) ? eq[ItemTypeConstants.EquipType.Weapon] : 0); // 武器[Weapon] 8010101
            plew.WriteInt(eq.ContainsKey(ItemTypeConstants.EquipType.Outfit) ? eq[ItemTypeConstants.EquipType.Outfit] : 0); // 衣服[Outfit] 8160351
            plew.WriteInt(eq.ContainsKey(ItemTypeConstants.EquipType.Face) ? eq[ItemTypeConstants.EquipType.Face] : 0);     // 臉下[Face2]  9410021
            plew.WriteInt(eq.ContainsKey(ItemTypeConstants.EquipType.Face2) ? eq[ItemTypeConstants.EquipType.Face2] : 0);   // 臉上[Face]   8710013
            plew.WriteInt(eq.ContainsKey(ItemTypeConstants.EquipType.Hat) ? eq[ItemTypeConstants.EquipType.Hat] : 0);       // 帽子[Hat]    8610011
            plew.WriteInt(chr != null ? chr.Eyes : 0);                                                                      // 眼睛[Eye]    9110011
            plew.WriteInt(eq.ContainsKey(ItemTypeConstants.EquipType.Mantle) ? eq[ItemTypeConstants.EquipType.Mantle] : 0); // 服裝[Dress]  9510081
            plew.WriteInt(eq.ContainsKey(ItemTypeConstants.EquipType.Dress) ? eq[ItemTypeConstants.EquipType.Dress] : 0);   // 披風[Mantle] 8493122
            plew.WriteInt(chr != null ? chr.Hair : 0);                                                                      // 頭髮[Hair]   9010011
        }
    }
}
