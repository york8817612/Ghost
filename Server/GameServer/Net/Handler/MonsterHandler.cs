using Server.Common.Constants;
using Server.Common.IO;
using Server.Common.IO.Packet;
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
                for (int i = 0; i < Monster.Drops.Count; i++)
                {
                    Monster.Drops[i].PositionX = Monster.PositionX;
                    Monster.Drops[i].PositionY = Monster.PositionY - 50;
                    map.MonsterDrop.Add(new Item(Monster.Drops[i].ItemID, 0x63, 0x63, Monster.Drops[i].Quantity));
                    MapPacket.MonsterDrop(gc, Monster);
                }
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
