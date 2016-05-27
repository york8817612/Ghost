using Server.Common.Constants;
using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Net;
using Server.Packet;
using System;

namespace Server.Handler
{
    class MonsterHandler
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
            Map map = Maps.GetMap(chr.MapX, chr.MapY);
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
                map.Monster.Remove(Monster);
                chr.Exp += 10;
                if (chr.Exp >= GameConstants.getExpNeededForLevel(chr.Level))
                    chr.LevelUp();
                StatusPacket.updateExp(gc);
            } else
            {
                Monster.State = 7;
                if ((chr.PlayerX < HitX && Monster.Direction == 1) || (chr.PlayerX > HitX && Monster.Direction == -1))
                    Monster.Direction = Monster.Direction * -1;
            }
            MonsterPacket.spawnMonster(gc, Monster, CharacterID, Damage, HitX, HitY);
        }
    }
}
