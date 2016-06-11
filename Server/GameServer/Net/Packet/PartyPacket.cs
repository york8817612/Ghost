using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Net;

namespace Server.Packet
{
    public static class PartyPacket
    {
        public static void PartyInvite(Client c, int CharacterID, int Respons)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PARTY_INVITE))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(CharacterID);
                plew.WriteInt(Respons); // 【0 : %s 取消了加入隊伍的邀請"】【1 : %s 加入了隊伍】
                c.Send(plew);
            }
        }

        public static void PartyUpdate(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PARTY_UPDATE))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                for (int i = 0; i < 6; i++)
                {
                    // 個人 + 其他 5 名隊員
                    plew.WriteInt(chr.CharacterID);
                    plew.WriteShort(chr.Level);
                    plew.WriteString(chr.Name, 20);
                    plew.WriteShort(chr.MaxHp);
                    plew.WriteShort(chr.Hp);
                    plew.WriteShort(chr.MaxMp);
                    plew.WriteShort(chr.Mp); // 尚未確認
                    plew.WriteHexString("1F 40");
                    plew.WriteByte(chr.IP.GetAddressBytes()[0]);
                    plew.WriteByte(chr.IP.GetAddressBytes()[1]);
                    plew.WriteByte(chr.IP.GetAddressBytes()[2]);
                    plew.WriteByte(chr.IP.GetAddressBytes()[3]);
                    plew.WriteByte(192);
                    plew.WriteByte(168);
                    plew.WriteByte(1);
                    plew.WriteByte(101);
                }
                c.Send(plew);
            }
        }

        public static void PartyHpUpdate(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PARTY_HP_UPDATE))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(chr.CharacterID);
                plew.WriteShort(chr.MaxHp);
                plew.WriteShort(chr.Hp);
                plew.WriteShort(chr.MaxMp);
                plew.WriteShort(chr.Mp); // 尚未確認
                c.Send(plew);
            }
        }

        public static void PartyDismiss(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PARTY_DISMISS))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                c.Send(plew);
            }
        }
    }
}
