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
            Monster Monster = gc.Character.Map.getMonsterByOriginalID(OriginalID);
            if (Monster == null)
                return;
            MonsterPacket.spawnMonster(gc, Monster, CharacterID, Damage, HitX, HitY);
        }
    }
}
