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
    public static class MonsterHandler
    {
        public static void AttackMonster_Req(InPacket lea, Client gc)
        {
            short CharacterID = lea.ReadShort();
            short OriginalID = lea.ReadShort();
            lea.ReadShort();
            short Damage = lea.ReadShort();
            short HitX = lea.ReadShort();
            short HitY = lea.ReadShort();
            short SkillID = lea.ReadShort();
            var chr = gc.Character;
            Map Map = MapFactory.GetMap(chr.MapX, chr.MapY);
            Monster Monster = Map.getMonsterByOriginalID(OriginalID);
            if (Monster == null)
                return;
            Monster.HP -= Damage;
            switch (SkillID)
            {
                case 10304:
                case 10305:
                    Random rnd = new Random();
                    if (rnd.Next(0, 2) == 0)
                        Monster.Effect = 5;
                    break;
                default:
                    //Log.Inform("[Attack Monster] SkillID = {0}", SkillID);
                    break;
            }
            if (Monster.HP <= 0)
            {
                if (Monster.IsAlive == false)
                    return;
                Monster.State = 9;
                Monster.Effect = 0;
                //map.Monster.Remove(Monster);
                Monster.IsAlive = false;
                chr.Exp += Monster.Exp;
                if (chr.Exp >= GameConstants.getExpNeededForLevel(chr.Level))
                    chr.LevelUp();
                StatusPacket.UpdateExp(gc);

                // 加入要掉落物品
                int Max_Count = 2; // 設定最大物品掉落數
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

                // 無 : 1%
                // 9900001 : 20%
                // 9900002 : 19%
                // 9900003 : 20%
                // 9900004 : 40%

                int[] Soul = {
                    0,
                    9900001, 9900001, 9900001, 9900001, 9900001, 9900001, 9900001, 9900001, 9900001, 9900001, 9900001, 9900001, 9900001, 9900001, 9900001, 9900001, 9900001, 9900001, 9900001, 9900001, // 20%
                    9900002, 9900002, 9900002, 9900002, 9900002, 9900002, 9900002, 9900002, 9900002, 9900002, 9900002, 9900002, 9900002, 9900002, 9900002, 9900002, 9900002, 9900002, 9900002, // 19%
                    9900003, 9900003, 9900003, 9900003, 9900003, 9900003, 9900003, 9900003, 9900003, 9900003, 9900003, 9900003, 9900003, 9900003, 9900003, 9900003, 9900003, 9900003, 9900003, 9900003, // 20%
                    9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004, 9900004 // 40%
                };

                int rnd = Randomizer.Next(0, 100);
                if (rnd != 0)
                    Monster.Drops.Add(new Drop(0, Soul[rnd], 20));

                //int Max_Soul_Count = 1; // 設定最大物品掉落數
                //int Current_Soul_Count = 0;
                //int[] Soul = new int[] { 15000, 250000, 800000, 650000 };
                //for (int i = 1; i < 5; i++)
                //{
                //    if (Max_Soul_Count == Current_Soul_Count)
                //        break;

                //    if ((Randomizer.Next(999999) / GameServer.Rates.Loot) < Soul[i-1])
                //    {
                //        Monster.Drops.Add(new Drop(0, 9900001 + (i -1), 20));
                //        Current_Soul_Count++;
                //    }
                //}

                short rndMoney = (short)(Monster.Exp + Randomizer.Next(6));

                if (rndMoney != 0) // 少數怪物未寫入經驗值
                    Monster.Drops.Add(new Drop(0, InventoryType.getMoneyStyle(rndMoney), rndMoney)); // 錢

                for (int i = 0; i < Monster.Drops.Count; i++)
                {
                    Monster.Drops[i].PositionX = Monster.PositionX;
                    Monster.Drops[i].PositionY = Monster.PositionY - 50;
                    //Item it = new Item(Monster.Drops[i].ItemID, 0x63, 0x63, Monster.Drops[i].Quantity);
                    Monster.Drops[i].ID = Map.ObjectID;
                    Map.Item.Add(Map.ObjectID, new Drop(Map.ObjectID, Monster.Drops[i].ItemID, Monster.Drops[i].Quantity));
                    Map.ObjectID++;
                }
                foreach (Character All in Map.Characters)
                {
                    MapPacket.MonsterDrop(All.Client, Monster);
                }
                Monster.Drops.Clear();
            }
            else
            {
                Monster.State = 7;
                if (chr.PlayerX < HitX && Monster.Direction == 1)
                    Monster.Direction = 0xFF;
                else if (chr.PlayerX > HitX && Monster.Direction == 0xFF)
                    Monster.Direction = 1;
            }

            foreach (Character All in Map.Characters)
                MonsterPacket.spawnMonster(All.Client, Monster, CharacterID, Damage, HitX, HitY);

            if (Monster.State == 7 && Monster.AttackType > 0)
            {
                Monster.State = 3;
                foreach (Character All in Map.Characters)
                    MonsterPacket.spawnMonster(All.Client, Monster, CharacterID, 0, HitX, HitY);
            }
        }
    }
}
