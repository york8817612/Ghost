using Server.Common.Constants;
using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Utilities;
using Server.Ghost;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;
using System;
using System.Collections.Generic;

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
            Map map = MapFactory.GetMap(chr.MapX, chr.MapY);
            Monster Monster = map.getMonsterByOriginalID(OriginalID);
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
                    Log.Inform("[攻擊怪物] SkillID = {0}", SkillID);
                    break;
            }
            if (Monster.HP <= 0)
            {
                Monster.State = 9;
                //map.Monster.Remove(Monster);
                Monster.IsAlive = false;
                chr.Exp += Monster.Exp;
                if (chr.Exp >= GameConstants.getExpNeededForLevel(chr.Level))
                    chr.LevelUp();
                StatusPacket.UpdateExp(gc);

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

                    if ((Randomizer.Next(999999) / GameServer.Rates.Loot) < Soul[i-1])
                    {
                        Monster.Drops.Add(new Drop(0, 9900001 + (i -1), 20));
                        Current_Soul_Count++;
                    }
                }

                short rndMoney = (short)(Monster.Exp + Randomizer.Next(6));
                Monster.Drops.Add(new Drop(0, InventoryType.getMoneyStyle(rndMoney), rndMoney)); // 錢

                for (int i = 0; i < Monster.Drops.Count; i++)
                {
                    Monster.Drops[i].PositionX = Monster.PositionX - (5 * i);
                    Monster.Drops[i].PositionY = Monster.PositionY - 50;
                    Item it = new Item(Monster.Drops[i].ItemID, 0x63, 0x63, Monster.Drops[i].Quantity);
                    Monster.Drops[i].ID = map.ObjectID;
                    map.CharacterItem.Add(map.ObjectID, it);
                    map.ObjectID++;
                }
                MapPacket.MonsterDrop(gc, Monster);
            }
            else
            {
                Monster.State = 7;
                if (chr.PlayerX < HitX && Monster.Direction == 1)
                    Monster.Direction = 0xFF;
                else if (chr.PlayerX > HitX && Monster.Direction == 0xFF)
                    Monster.Direction = 1;
            }
            foreach (Character All in map.Characters)
                MonsterPacket.spawnMonster(All.Client, Monster, CharacterID, Damage, HitX, HitY);
        }
    }
}
