using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Ghost;

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
            var chr = gc.Character;
            Monster Monster = gc.Character.Map.getMonsterByOriginalID(OriginalID);
            if (Monster == null)
                return;
            Monster.HP -= Damage;
            if (Monster.HP <= 0)
            {
                Monster.State = 0x09;
                chr.Exp += 10;
                if (chr.Exp >= GameConstants.getExpNeededForLevel(chr.Level))
                    chr.LevelUp();
                StatusPacket.updateExp(gc);
            } else
            {
                Monster.State = 0x07;
            }
            MonsterPacket.spawnMonster(gc, Monster, CharacterID, Damage, HitX, HitY);
        }
    }
}
