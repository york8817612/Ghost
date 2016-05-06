using Server.Common.Data;
using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Security;
using Server.Ghost;
using Server.Ghost.Accounts;
using Server.Ghost.Characters;
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
            //lea.Skip(206);
            int selectCharacter = lea.ReadByte();
            IPAddress hostid = lea.ReadIPAddress();

            gc.SetAccount(new Account(gc));

            try
            {
                gc.Account.Load(username);
                var pe = new PasswordEncrypt(encryptKey);
                string encryptPassword = pe.encrypt(gc.Account.Password);
                if (!password.Equals(encryptPassword))
                {
                    gc.Dispose();
                    Log.Error("Login Fail!");
                }
                else if (gc.Account.Banned > 0)
                {
                    gc.Dispose();
                }
                else
                {
                    gc.Account.Characters = new List<Character>();
                    foreach (dynamic datum in new Datums("Characters").PopulateWith("id", "accountId = '{0}' ORDER BY position ASC", gc.Account.ID))
                    {
                        Character character = new Character(datum.id, gc);
                        character.Load(false);
                        gc.Account.Characters.Add(character);
                    }
                    gc.SetCharacter(gc.Account.Characters[selectCharacter]);
                }
                Log.Inform("Password = {0}", password);
                Log.Inform("encryptKey = {0}", encryptKey);
                Log.Inform("encryptPassword = {0}", encryptPassword);
            }
            catch (NoAccountException)
            {
                if (false)
                {
                    // TODO: Auto registration.
                }
                else
                {
                    gc.Dispose();
                    Log.Error("Login Fail!");
                }
            }

            Character chr = gc.Character;
            chr.CharacterID = gc.CharacterID;

            StatusPacket.updateHpMp(gc, chr.Hp, chr.Mp, chr.MaxFury, chr.Fury);
            GamePacket.FW_DISCOUNTFACTION(gc);
            QuestPacket.getQuestInfo(gc);
            StatusPacket.getStatusInfo(gc);
            InventoryPacket.getCharacterEquip(gc);
            //GamePacket.getCharacterInvenAll(gc);
            SkillPacket.getSkillInfo(gc, chr.Skills.getSkills());
            QuestPacket.getQuickSlot(gc);
            InventoryPacket.getStoreInfo(gc);
            InventoryPacket.getStoreInfo(gc);
            InventoryPacket.getStoreMoney(gc, 0);
            MapPacket.enterMapStart(gc);
            InventoryPacket.getInvenEquip(gc);
            InventoryPacket.getInvenEquip1(gc);
            InventoryPacket.getInvenEquip2(gc);
            InventoryPacket.getInvenSpend3(gc);
            InventoryPacket.getInvenOther4(gc);
            InventoryPacket.getInvenPet5(gc);
            InventoryPacket.getInvenCash(gc);
        }

        public static void Command_Req(InPacket lea, Client gc)
        {
            string[] command = lea.ReadString(60).Split(new[] { (char)0x20 }, StringSplitOptions.None);

            if (gc.Account.Master == 0 || command.Length < 1)
                return;

            switch (command[0])
            {
                case "//notice":
                    if (command.Length != 2)
                        break;
                    GamePacket.getNotice(gc, 3, command[1]);
                    break;
                case "//item":
                    if (command.Length != 4 || Convert.ToByte(command[2]) < 0 || Convert.ToByte(command[2]) > 23 || Convert.ToByte(command[3]) == 0)
                        break;
                    gc.Character.Items.Add(new Item(Convert.ToInt32(command[1]), Convert.ToByte(command[2]), Convert.ToByte(command[3])));
                    InventoryPacket.getInvenEquip1(gc);
                    InventoryPacket.getInvenEquip2(gc);
                    InventoryPacket.getInvenSpend3(gc);
                    InventoryPacket.getInvenOther4(gc);
                    InventoryPacket.getInvenPet5(gc);
                    break;
                case "//levelup":
                    StatusPacket.levelUp(gc, gc.Character.Level++);
                    StatusPacket.getStatusInfo(gc);
                    break;
                case "//gogo":
                    if (command.Length != 3)
                        break;
                    MapPacket.warpToMapAuth(gc, true, Convert.ToInt16(command[1]), Convert.ToInt16(command[2]), -1, -1);
                    break;
                default:
                    break;
            }
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
