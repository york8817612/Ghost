using Server.Common.Data;
using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Security;
using Server.Ghost.Accounts;
using Server.Ghost.Characters;
using System;
using System.Collections.Generic;
using System.Net;

namespace Server.Net
{
    public static class GameHandler
    {


        private static int SearchBytes(byte[] haystack, byte[] needle)
        {
            var len = needle.Length;
            var limit = haystack.Length - len;
            for (var i = 0; i <= limit; i++)
            {
                var k = 0;
                for (; k < len; k++)
                {
                    if (needle[k] != haystack[i + k]) break;
                }
                if (k == len) return i;
            }
            return -1;
        }

        public static void Game_Log_Req(InPacket lea, Client gc)
        {
            int re = SearchBytes(lea.Content, new byte[] { 0x0 });
            string[] data = lea.ReadString(re).Split(new[] { (char)0x20 }, StringSplitOptions.None);
            int encryptKey = int.Parse(data[1]);
            string username = data[2];
            string password = data[4].Replace("\v", "");
            lea.Skip(9);
            int ops = lea.ReadByte();
            int selectCharacter = 0;
            if (ops == 4)
            {
                selectCharacter = lea.ReadByte();
            }
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
                    foreach (dynamic datum in new Datums("Characters").PopulateWith("id", "accountId = '{0}' && worldId = '{1}'", gc.Account.ID, GameServer.WorldID))
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

            GamePacket.updateCharacterHpSp(gc, chr.Hp, chr.Sp, 0, 0);
            GamePacket.FW_DISCOUNTFACTION(gc);
            GamePacket.getQuestInfo(gc);
            GamePacket.getCharacterStatus(gc);
            GamePacket.getCharacterEquip(gc);
            //GamePacket.getCharacterInvenAll(gc);
            GamePacket.getCharacterSkill(gc);
            GamePacket.getQuickSlot(gc);
            GamePacket.getStoreInfo(gc);
            GamePacket.getStoreInfo(gc);
            //GamePacket.getStoreInfo(gc);
            //GamePacket.getStoreInfo(gc);
            GamePacket.getStoreMoney(gc, 0);
            GamePacket.enterMapStart(gc);
            GamePacket.INVEN_CASH(gc);
            //GamePacket.INVEN_EQUIP(gc);
            GamePacket.getInvenEquip1(gc, 24, chr.Items.getItems());
            GamePacket.getInvenEquip2(gc, 24, chr.Items.getItems());
            GamePacket.getInvenSpend3(gc, 24, chr.Items.getItems());
            GamePacket.getInvenOther4(gc, 24, chr.Items.getItems());
            GamePacket.INVEN_PET5(gc);
        }

        public static void Command_Req(InPacket lea, Client gc)
        {
            string[] data = lea.ReadString(30).Split(new[] { (char)0x20 }, StringSplitOptions.None);

            if (data.Length < 1)
                return;

            switch (data[0])
            {
                case "//gogo":
                    if (data.Length != 3)
                        break;
                    GamePacket.warpToMapAuth(gc, true, Convert.ToInt16(data[1]), Convert.ToInt16(data[2]), -1, -1);
                    break;
                case "//notice":
                    if (data.Length != 2)
                        break;
                    GamePacket.getNotice(gc, 3, data[1]);
                    break;
                case "//item":
                    if (data.Length != 2)
                        break;

                    break;
            }
        }

        public static void Chat_Req(InPacket lea, Client gc)
        {
            lea.ReadInt();
            lea.ReadInt();
            int charId = lea.ReadInt();
            lea.ReadInt();
            lea.ReadBytes(20);
            string message = lea.ReadString(200);
            GamePacket.CHAT(gc, message);
        }

        public static void WarpToMap_Req(InPacket lea, Client gc)
        {
            int playerId = lea.ReadInt();
            short mapX = lea.ReadShort();
            short mapY = lea.ReadShort();
            short playerX = lea.ReadShort();
            short playerY = lea.ReadShort();
            gc.Character.MapX = mapX;
            gc.Character.MapY = mapY;
            gc.Character.PlayerX = playerX;
            gc.Character.PlayerY = playerY;
            GamePacket.warpToMap(gc, playerId, mapX, mapY, playerX, playerY);
            if (mapX == 3 && mapY == 1)
            {
                //gc.SendPacket(Packet.Game.Monster.createAllMonster());
                //gc.SendPacket(Packet.Game.Monster.spawnMonster());
            }
        }

        public static void UseWater_Req(InPacket lea, Client gc)
        {
            int hp = lea.ReadInt();
            short mp = lea.ReadShort();
            short maxFury = lea.ReadShort();
            short fury = lea.ReadShort();
            GamePacket.updateCharacterHpSp(gc, hp, mp, maxFury, fury);
        }

        public static void WarpToMapAuth_Req(InPacket lea, Client gc)
        {
            short mapX = lea.ReadShort();
            short mapY = lea.ReadShort();
            short playerX = lea.ReadShort();
            short playerY = lea.ReadShort();
            bool mapExist = true;
            GamePacket.warpToMapAuth(gc, mapExist, mapX, mapY, playerX, playerY);
        }
    }
}
