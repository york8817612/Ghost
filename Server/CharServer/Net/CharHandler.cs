using Server.Accounts;
using Server.Characters;
using Server.Common.Constants;
using Server.Common.Data;
using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Security;
using System;
using System.Collections.Generic;

namespace Server.Net
{
    public static class CharHandler
    {
        public static void MyChar_Info_Req(InPacket lea, Client gc)
        {
            string[] data = lea.ReadString(lea.Available).Split(new[] { (char)0x20 }, StringSplitOptions.None);
            int encryptKey = int.Parse(data[1]);
            string username = data[2];
            string password = data[4];

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
                    foreach (dynamic datum in new Datums("Characters").PopulateWith("id", "accountId = '{0}' && worldId = '{1}' ORDER BY position ASC", gc.Account.ID, gc.WorldID))
                    {
                        Character character = new Character(datum.id, gc);
                        character.Load(false);
                        gc.Account.Characters.Add(character);
                    }
                    CharPacket.MyChar_Info_Ack(gc, gc.Account.Characters);
                    Log.Success("Login Success!");
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
        }

        public static void Create_MyChar_Req(InPacket lea, Client gc)
        {
            string name = lea.ReadString(20);
            int gender = lea.ReadByte();
            int value1 = lea.ReadByte();
            int value2 = lea.ReadByte();
            int value3 = lea.ReadByte();
            int eyes = lea.ReadInt();
            int hair = lea.ReadInt();
            int weapon = lea.ReadInt();
            int armor = lea.ReadInt();

            Character chr = new Character();

            chr.AccountID = gc.Account.ID;
            chr.WorldID = gc.WorldID;
            chr.Name = name;
            chr.Title = "江湖人";
            chr.Level = 1;
            chr.Class = 0;
            chr.ClassLevel = 0xFF;
            chr.Gender = (byte)gender;
            chr.Eyes = eyes;
            chr.Hair = hair;
            chr.MapX = 1;
            chr.MapY = 1;
            chr.Str = 3;
            chr.Dex = 3;
            chr.Vit = 3;
            chr.Int = 3;
            chr.Hp = 75;
            chr.MaxHp = 75;
            chr.Mp = 25;
            chr.MaxMp = 25;
            chr.Fury = 0;
            chr.MaxFury = 1200;
            chr.Exp = 0;
            chr.Money = 0;
            chr.Attack = 1;
            chr.MaxAttack = 10;
            chr.Magic = 1;
            chr.MaxMagic = 3;
            chr.Defense = 10;
            chr.JumpHeight = 3;

            int pos = 1;
            foreach (Character cc in gc.Account.Characters)
            {
                if (cc.Position != pos)
                {
                    break;
                }
                pos++;
            }

            chr.Position = (byte)(pos);

            chr.Items.Add(new Item(weapon, (byte)ItemTypeConstants.EquipType.Weapon, (byte)ItemTypeConstants.ItemType.Equip1));
            chr.Items.Add(new Item(armor, (byte)ItemTypeConstants.EquipType.Outfit, (byte)ItemTypeConstants.ItemType.Equip1));
            chr.Items.Add(new Item(8510020, (byte)ItemTypeConstants.EquipType.Seal, (byte)ItemTypeConstants.ItemType.Equip2));


            if ((gc.Account.Characters.Count + 1) <= 4)
            {
                chr.Save();
                gc.Account.Characters.Insert(pos - 1, chr);
                pos = (chr.Position << 8) + 1;
            }
            else if (Database.Exists("Characters", "name = '{0}'", name))
            {
                pos = -1;
            }
            else if ((gc.Account.Characters.Count + 1) > 4)
            {
                pos = -2;
            }
            else
            {
                pos = 0;
            }
            CharPacket.Create_MyChar_Ack(gc, pos);
        }

        public static void Check_SameName_Req(InPacket lea, Client gc)
        {
            string name = lea.ReadString(20);
            CharPacket.Check_SameName_Ack(gc, (Database.Exists("Characters", "name = '{0}'", name) ? 0 : 1));
        }

        public static void Delete_MyChar_Req(InPacket lea, Client gc)
        {
            int position = lea.ReadInt();

            gc.Account.Characters[position].Delete();
            gc.Account.Characters.Remove(gc.Account.Characters[position]);

            CharPacket.Delete_MyChar_Ack(gc, position + 1);
        }
    }
}
