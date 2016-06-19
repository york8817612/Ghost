using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Common.Utilities;
using Server.Ghost;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;
using System;

namespace Server.Handler
{
    public static class ActionHandler
    {
        public static void p_Move_c(InPacket lea, Client c)
        {
            int CharacterID = lea.ReadInt();
            float PositionX = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            float PositionY = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            int Speed = lea.ReadInt(); // start = 00 00 40 40 , end = 00 00 00 00
            int MoveDirection = lea.ReadByte(); // right = 01 , left = FF

            if (c != null && Speed == 0)
            {
                if (c.Character != null)
                {
                    c.Character.PlayerX = ((short)PositionX);
                    c.Character.PlayerY = ((short)PositionY);
                    Console.WriteLine("Player New Pos X:{0}, Y:{1}", c.Character.PlayerX, c.Character.PlayerY);
                }
            }

            Console.WriteLine("Player {0} Move To {1} X:{2}, Y:{3}", Speed == 0 ? "End" : "Start", MoveDirection == 1 ? "Right" : "Left", PositionX, PositionY);
        }

        public static void p_Jump_c(InPacket lea, Client c)
        {
            lea.ReadInt();
            lea.ReadInt();
            float PositionX = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            float PositionY = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);


            if (c != null)
            {
                if (c.Character != null)
                {
                    c.Character.PlayerX = ((short)PositionX);
                    c.Character.PlayerY = ((short)PositionY);
                    Console.WriteLine("Player New Pos X:{0}, Y:{1}", c.Character.PlayerX, c.Character.PlayerY);
                }
            }
        }

        public static void p_Speed_c(InPacket lea, Client c)
        {
            lea.ReadInt();
            lea.ReadInt();
            lea.ReadInt();
            float PositionX = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            float PositionY = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);


            if (c != null)
            {
                if (c.Character != null)
                {
                    c.Character.PlayerX = ((short)PositionX);
                    c.Character.PlayerY = ((short)PositionY);
                    Console.WriteLine("Player New Pos X:{0}, Y:{1}", c.Character.PlayerX, c.Character.PlayerY);
                }
            }
        }

        public static void p_Damage_c(InPacket lea, Client c)
        {
            //int CharacterID = lea.ReadInt();
            //short Damage = lea.ReadShort();
            //var chr = c.Character;
            //chr.Hp -= Damage;
        }

        public static void p_Dead_c(InPacket lea, Client c)
        {
            //var chr = c.Character;
            //int CharacterID = lea.ReadInt();
            //MapPacket.userDead(c);
            //chr.IsAlive = false;
            //chr.Exp -= (int)(chr.Exp * 0.2);
        }

        public static void p_Move(InPacket lea, Client c)
        {
            int CharacterID = lea.ReadInt();
            float posX = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            float posY = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);

            if (c != null)
            {
                if (c.Character != null)
                {
                    c.Character.PlayerX = ((short)posX);
                    c.Character.PlayerY = ((short)posY);
                    Console.WriteLine("Player New Pos X:{0}, Y:{1}", c.Character.PlayerX, c.Character.PlayerY);
                }
            }
        }

        public static void Pet_Move_C(InPacket lea, Client c)
        {
            int CharacterID = lea.ReadInt();
            float posX = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            float posY = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            int Speed = lea.ReadInt();
        }

        public static void Pet_Attack_C(InPacket lea, Client c)
        {
            int CharacterID = lea.ReadInt();
            lea.ReadShort();
            lea.ReadShort();
            int OriginalID = lea.ReadShort();
            lea.ReadInt();
            int Damage = lea.ReadShort();
            var chr = c.Character;
            Map map = MapFactory.GetMap(chr.MapX, chr.MapY);
            Monster Monster = map.getMonsterByOriginalID(OriginalID);
            if (Monster == null)
                return;
            Monster.HP -= Damage;
            if (Monster.HP <= 0)
            {
                if (Monster.IsAlive == false)
                    return;
                Monster.State = 9;
                //map.Monster.Remove(Monster);
                Monster.IsAlive = false;
                chr.Exp += Monster.Exp;
                if (chr.Exp >= GameConstants.getExpNeededForLevel(chr.Level))
                    chr.LevelUp();
                StatusPacket.UpdateExp(c);

                // 加入要掉落物品
                int Max_Count = 3; // 設定最大物品掉落數
                int Current_Count = 0;
                foreach (Loot loot in MobFactory.Drop_Data)
                {
                    if (Current_Count == Max_Count)
                        break;

                    if (loot.MobID == Monster.MonsterID)
                    {
                        if ((Randomizer.Next(999999) / GameServer.Rates.Loot) < loot.Chance)
                        {
                            Monster.Drops.Add(new Drop(0, loot.ItemID, (short)Randomizer.Next(loot.MinimumQuantity, loot.MaximumQuantity)));
                            Current_Count++;
                        }
                    }
                }

                // 加入要掉落靈魂
                //【藍色鬼魂】能恢復20%的鬼力值
                //【綠色鬼魂】能恢復40%的鬼力值
                //【紅色鬼魂】累積憤怒計量值用，當憤怒計滿之後能轉為憤怒狀態，攻防都會*1.2倍
                //【紫色鬼魂】能吸收到封印裝備，蒐集越多越能增加封印物合成的成功機率
                int Max_Soul_Count = 1; // 設定最大物品掉落數
                int Current_Soul_Count = 0;
                int[] Soul = new int[] { 15000, 250000, 800000, 650000 };
                for (int i = 1; i < 5; i++)
                {
                    if (Max_Soul_Count == Current_Soul_Count)
                        break;

                    if ((Randomizer.Next(999999) / GameServer.Rates.Loot) < Soul[i - 1])
                    {
                        Monster.Drops.Add(new Drop(0, 9900001 + (i - 1), 20));
                        Current_Soul_Count++;
                    }
                }

                short rndMoney = (short)(Monster.Exp + Randomizer.Next(6));
                Monster.Drops.Add(new Drop(0, InventoryType.getMoneyStyle(rndMoney), rndMoney)); // 錢

                for (int i = 0; i < Monster.Drops.Count; i++)
                {
                    Monster.Drops[i].PositionX = Monster.PositionX;
                    Monster.Drops[i].PositionY = Monster.PositionY - 50;
                    Item it = new Item(Monster.Drops[i].ItemID, 0x63, 0x63, Monster.Drops[i].Quantity);
                    Monster.Drops[i].ID = map.ObjectID;
                    map.CharacterItem.Add(map.ObjectID, it);
                    map.ObjectID++;
                }
                foreach (Character All in map.Characters)
                {
                    MapPacket.MonsterDrop(All.Client, Monster);
                }
            }
            else
            {
                Monster.State = 7;
            }
            foreach (Character All in map.Characters)
                MonsterPacket.spawnMonster(All.Client, Monster, CharacterID, Damage, 0, 0);
            if (Monster.IsAlive && Monster.AttackType > 0)
            {
                Monster.State = 3;
                foreach (Character All in map.Characters)
                    MonsterPacket.spawnMonster(All.Client, Monster, CharacterID, Damage, 0, 0);
            }
        }
    }
}
