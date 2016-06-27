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
            plew.WriteShort(0);
            plew.WriteShort(0);
            Dictionary<InventoryType.EquipType, int> equip = getEquip(chr);
            plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Weapon) ? equip[InventoryType.EquipType.Weapon] : 0); // 武器[Weapon] 8010101
            plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Outfit) ? equip[InventoryType.EquipType.Outfit] : 0); // [Outfit]     8160351
            plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Face) ? equip[InventoryType.EquipType.Face] : 0);     // 臉下[face2]  9410021
            plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Face2) ? equip[InventoryType.EquipType.Face2] : 0);   // 臉上[face]   8710013
            plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Hat) ? equip[InventoryType.EquipType.Hat] : 0);       // 帽子[hat]    8610011
            plew.WriteInt(chr != null ? chr.Eyes : 0);                                                                    // 眼睛[eye]    9110011
            plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Mantle) ? equip[InventoryType.EquipType.Mantle] : 0); // 服裝[outfit] 9510081
            plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Dress) ? equip[InventoryType.EquipType.Dress] : 0);   // 披風[mantle] 8493122
            plew.WriteInt(chr != null ? chr.Hair : 0);                                                                    // 頭髮[Hair]   9010011
        }

        public static Dictionary<InventoryType.EquipType, int> getEquip(Character chr)
        {
            Dictionary<InventoryType.EquipType, int> equip = new Dictionary<InventoryType.EquipType, int>();
            if (chr != null)
            {
                foreach (Item im in chr.Items)
                {
                    if (im.Type != (byte)InventoryType.ItemType.Equip)
                        continue;
                    switch (im.Slot)
                    {
                        case (byte)InventoryType.EquipType.Weapon:
                            equip.Add(InventoryType.EquipType.Weapon, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Outfit:
                            equip.Add(InventoryType.EquipType.Outfit, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Ring:
                            equip.Add(InventoryType.EquipType.Ring, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Necklace:
                            equip.Add(InventoryType.EquipType.Necklace, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Mantle:
                            equip.Add(InventoryType.EquipType.Mantle, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Seal:
                            equip.Add(InventoryType.EquipType.Seal, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Hat:
                            equip.Add(InventoryType.EquipType.Hat, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Hair:
                            equip.Add(InventoryType.EquipType.Hair, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Eyes:
                            equip.Add(InventoryType.EquipType.Eyes, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Face:
                            equip.Add(InventoryType.EquipType.Face, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Pet:
                            equip.Add(InventoryType.EquipType.Pet, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Dress:
                            equip.Add(InventoryType.EquipType.Dress, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Face2:
                            equip.Add(InventoryType.EquipType.Face2, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Earing:
                            equip.Add(InventoryType.EquipType.Earing, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.HairAcc:
                            equip.Add(InventoryType.EquipType.HairAcc, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Toy:
                            equip.Add(InventoryType.EquipType.Toy, im.ItemID);
                            break;
                    }
                }
                return equip;
            }
            return new Dictionary<InventoryType.EquipType, int>();
        }
    }
}
