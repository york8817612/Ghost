using Server.Common.Constants;
using Server.Common.Data;
using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Security;
using Server.Ghost;
using Server.Ghost.Accounts;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;
using System;
using System.Collections.Generic;
using System.Net;

namespace Server.Handler
{
    public static class GameHandler
    {
        public static void Game_Log_Req(InPacket lea, Client gc)
        {
            //int re = SearchBytes(lea.Content, new byte[] { 0x0 });
            string[] data = lea.ReadString(0x100/*re*/).Split(new[] { (char)0x20 }, StringSplitOptions.None);
            int encryptKey = int.Parse(data[1]);
            string username = data[2];
            string password = data[4];
            int selectCharacter = lea.ReadByte();
            IPAddress hostid = lea.ReadIPAddress();

            gc.SetAccount(new Account(gc));

            try
            {
                gc.Account.Load(username);
                var pe = new PasswordEncrypt(encryptKey);
                string encryptPassword = pe.encrypt(gc.Account.Password, gc.RetryLoginCount > 0 ? password.ToCharArray() : null);

                if (!password.Equals(encryptPassword))
                {
                    gc.Dispose();
                    Log.Error("Login Fail!");
                }
                else
                {
                    gc.Account.Characters = new List<Character>();
                    foreach (dynamic datum in new Datums("Characters").PopulateWith("id", "accountId = '{0}' ORDER BY position ASC", gc.Account.ID))
                    {
                        Character character = new Character(datum.id, gc);
                        character.Load(false);
                        character.IP = hostid;
                        gc.Account.Characters.Add(character);
                    }
                    gc.SetCharacter(gc.Account.Characters[selectCharacter]);
                }
                Log.Inform("Password = {0}", password);
                //Log.Inform("encryptKey = {0}", encryptKey);
                //Log.Inform("encryptPassword = {0}", encryptPassword);
            }
            catch (NoAccountException)
            {
                gc.Dispose();
                Log.Error("Login Fail!");
            }

            Character chr = gc.Character;
            chr.CharacterID = gc.CharacterID;
            MapFactory.AllCharacters.Add(chr);

            StatusPacket.UpdateHpMp(gc, 0, 0, 0, 0);
            GamePacket.FW_DISCOUNTFACTION(gc);
            StatusPacket.getStatusInfo(gc);
            InventoryPacket.getCharacterEquip(gc);
            SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
            QuestPacket.getQuestInfo(gc, chr.Quests.getQuests());
            GamePacket.getQuickSlot(gc, chr.Keymap);
            StoragePacket.getStoreInfo(gc);
            StoragePacket.getStoreMoney(gc);
            MapPacket.enterMapStart(gc);
            InventoryPacket.getInvenCash(gc);
            CashShopPacket.MgameCash(gc);
            CashShopPacket.GuiHonCash(gc);
            InventoryPacket.getInvenEquip(gc);
            InventoryPacket.getInvenEquip1(gc);
            InventoryPacket.getInvenEquip2(gc);
            InventoryPacket.getInvenSpend3(gc);
            InventoryPacket.getInvenOther4(gc);
            InventoryPacket.getInvenPet5(gc);
        }

        public static void Command_Req(InPacket lea, Client gc)
        {
            string[] cmd = lea.ReadString(60).Split(new[] { (char)0x20 }, StringSplitOptions.None);

            if (gc.Account.Master == 0 || cmd.Length < 1)
                return;
            var chr = gc.Character;
            Character victim = null;

            switch (cmd[0])
            {
                case "//notice":
                    if (cmd.Length != 2)
                        break;
                    foreach (Character all in MapFactory.AllCharacters)
                    {
                        GamePacket.getNotice(all.Client, 3, cmd[1]);
                    }
                    break;
                case "//item":
                    if (cmd.Length != 2)
                        break;
                    chr.Items.Add(new Item(int.Parse(cmd[1]), InventoryType.getItemType(int.Parse(cmd[1])), chr.Items.GetNextFreeSlot((InventoryType.ItemType)InventoryType.getItemType(int.Parse(cmd[1])))));
                    InventoryPacket.getInvenEquip1(gc);
                    InventoryPacket.getInvenEquip2(gc);
                    InventoryPacket.getInvenSpend3(gc);
                    InventoryPacket.getInvenOther4(gc);
                    InventoryPacket.getInvenPet5(gc);
                    break;
                case "//money":
                    if (cmd.Length != 2)
                        break;
                    chr.Money = int.Parse(cmd[1]);
                    InventoryPacket.getInvenMoney(gc, chr.Money, int.Parse(cmd[1]));
                    break;
                case "//levelup":
                    chr.LevelUp();
                    break;
                case "//gogo":
                    if (cmd.Length != 3)
                        break;
                    MapPacket.warpToMapAuth(gc, true, short.Parse(cmd[1]), short.Parse(cmd[2]), -1, -1);
                    break;
                case "//warp":
                    if (cmd.Length != 2)
                        break;
                    foreach (Character find in MapFactory.AllCharacters)
                    {
                        if (find.Name.Equals(cmd[1]))
                        {
                            victim = find;
                        }
                    }
                    if (victim != null)
                    {
                        chr.MapX = victim.MapX;
                        chr.MapY = victim.MapY;
                        chr.PlayerX = victim.PlayerX;
                        chr.PlayerY = victim.PlayerY;
                        MapPacket.warpToMapAuth(gc, true, chr.MapX, chr.MapY, chr.PlayerX, chr.PlayerY);
                    }
                    break;
                case "//ban":
                    if (cmd.Length != 2)
                        break;
                    foreach (Character find in MapFactory.AllCharacters)
                    {
                        if (find.Name.Equals(cmd[1]))
                        {
                            victim = find;
                        }
                    }
                    if (victim != null)
                    {
                        dynamic datum = new Datum("accounts");
                        victim.Client.Account.Banned = 1;
                        victim.Client.Dispose();
                    }
                    break;
                case "//save":
                    for (int i = 0; i < MapFactory.AllCharacters.Count; i++)
                        MapFactory.AllCharacters[i].Client.Dispose();
                    //GameServer.IsAlive = false;
                    break;
                //case "//test":
                //    PartyPacket.PartyInvite(gc);
                //    break;
                //case "//test2":
                //    PartyPacket.PartyInvite(gc, 1, 1);
                //    break;
                //case "//test3":
                //    PartyPacket.PartyInvite(gc, 1 , 0);
                //    break;
                default:
                    break;
            }
        }

        public static void Quick_Slot_Req(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            int KeymapType = lea.ReadShort();
            int KeymapSlot = lea.ReadShort();
            int SkillID = lea.ReadInt();
            int SkillType = lea.ReadShort();
            int SkillSlot = lea.ReadShort();

            string QuickSlotName = "";
            switch (KeymapType)
            {
                case 0:
                    switch (KeymapSlot)
                    {
                        case 0:
                            QuickSlotName = "Z";
                            break;
                        case 1:
                            QuickSlotName = "X";
                            break;
                        case 2:
                            QuickSlotName = "C";
                            break;
                        case 3:
                            QuickSlotName = "V";
                            break;
                        case 4:
                            QuickSlotName = "B";
                            break;
                        case 5:
                            QuickSlotName = "N";
                            break;
                    }
                    break;
                case 1:
                    switch (KeymapSlot)
                    {
                        case 0:
                            QuickSlotName = "1";
                            break;
                        case 1:
                            QuickSlotName = "2";
                            break;
                        case 2:
                            QuickSlotName = "3";
                            break;
                        case 3:
                            QuickSlotName = "4";
                            break;
                        case 4:
                            QuickSlotName = "5";
                            break;
                        case 5:
                            QuickSlotName = "6";
                            break;
                    }
                    break;
                case 2:
                    switch (KeymapSlot)
                    {
                        case 0:
                            QuickSlotName = "Insert";
                            break;
                        case 1:
                            QuickSlotName = "Home";
                            break;
                        case 2:
                            QuickSlotName = "PageUp";
                            break;
                        case 3:
                            QuickSlotName = "Delete";
                            break;
                        case 4:
                            QuickSlotName = "End";
                            break;
                        case 5:
                            QuickSlotName = "PageDown";
                            break;
                    }
                    break;
                case 3:
                    switch (KeymapSlot)
                    {
                        case 0:
                            QuickSlotName = "7";
                            break;
                        case 1:
                            QuickSlotName = "8";
                            break;
                        case 2:
                            QuickSlotName = "9";
                            break;
                        case 3:
                            QuickSlotName = "0";
                            break;
                        case 4:
                            QuickSlotName = "-";
                            break;
                        case 5:
                            QuickSlotName = "=";
                            break;
                    }
                    break;
            }
            if (SkillID == -1 && SkillType == -1 && SkillSlot == -1)
            {
                chr.Keymap.Remove(QuickSlotName);
                return;
            }
            chr.Keymap.Remove(QuickSlotName);
            chr.Keymap.Add(QuickSlotName, new Shortcut(SkillID, (byte)SkillType, (byte)SkillSlot));
        }

        //private static int SearchBytes(byte[] haystack, byte[] needle)
        //{
        //    var len = needle.Length;
        //    var limit = haystack.Length - len;
        //    for (var i = 0; i <= limit; i++)
        //    {
        //        var k = 0;
        //        for (; k < len; k++)
        //        {
        //            if (needle[k] != haystack[i + k]) break;
        //        }
        //        if (k == len) return i;
        //    }
        //    return -1;
        //}
    }
}
