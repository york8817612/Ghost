using Server.Common.IO.Packet;
using Server.Common.Net;

namespace Server.Ghost
{
    public static class MonsterPacket
    {
        public static void createAllMonster(Client c, Monster[] monster)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.MON_ALLCREATE))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(monster.Length);
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteByte(monster[i] != null ? 1 : 0);
                }
                for (int i = 0; i < 50; i++)
                {//Level
                    plew.WriteByte(monster[i] != null ? monster[i].Level : 0);
                }
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteByte(0);
                }
                for (int i = 0; i < 50; i++)
                {//Facing
                    plew.WriteByte(monster[i] != null ? monster[i].Facing : 0);
                }
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteByte(monster[i] != null ? 1 : 0);
                }
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteByte(0);
                }
                for (int i = 0; i < 50; i++)
                {//IN MAP ID
                    plew.WriteShort(monster[i] != null ? i : 0);
                }
                for (int i = 0; i < 50; i++)
                {//Mob X
                    plew.WriteShort(monster[i] != null ? monster[i].PositionX : 0);
                }
                for (int i = 0; i < 50; i++)
                {//Y
                    plew.WriteShort(monster[i] != null ? monster[i].PositionY : 0);
                }
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteInt(0);
                }
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteInt(0);
                }
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteShort(monster[i] != null ? 5 : 0);
                }
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteShort(monster[i] != null ? 6 : 0);
                }
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteShort(monster[i] != null ? 5 : 0);
                }
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteShort(monster[i] != null ? 1 : 0);
                }
                for (int i = 0; i < 50; i++)
                {//Mobs ID
                    plew.WriteInt(monster[i] != null ? monster[i].MonsterID : 0);
                }
                for (int i = 0; i < 50; i++)
                {//MobSpeed
                    plew.WriteInt(monster[i] != null ? monster[i].Speed : 0);
                }
                for (int i = 0; i < 50; i++)
                {//??
                    plew.WriteHexString(monster[i] != null ? "CB 46" : "00 00");
                }
                for (int i = 0; i < 50; i++)
                {//MobHP
                    plew.WriteInt(monster[i] != null ? monster[i].MP : 0);
                }
                for (int i = 0; i < 50; i++)
                {//MobHP
                    plew.WriteInt(monster[i] != null ? monster[i].HP : 0);
                }
                c.Send(plew);
            }
        }

        public static void spawnMonster(Client c, Monster Monster, int CharacterID, int Damage, short HitX, short HitY)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.MON_SPAWN))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(Monster.State);
                plew.WriteInt(Monster.OriginalID);
                plew.WriteShort(0);
                plew.WriteShort(0);
                plew.WriteInt(Monster.Facing);
                plew.WriteInt(Monster.Speed); // float
                plew.WriteShort(Monster.PositionX);
                plew.WriteShort(Monster.PositionY);
                plew.WriteShort(0);
                plew.WriteShort(0);
                plew.WriteByte(0);
                plew.WriteHexString("00 00 00");
                plew.WriteInt(0);
                plew.WriteInt(0);
                plew.WriteShort(Damage);
                plew.WriteShort(Monster.Effect); // 怪物受到的效果(0: 無、1: 無法移動、2: 中毒、3: 黑暗、4: 未知、5: 冰凍)
                plew.WriteInt(0);
                plew.WriteInt(0);
                plew.WriteShort(HitX); // Hit
                plew.WriteShort(HitY); // Hit
                c.Send(plew);
            }
        }
    }
}
