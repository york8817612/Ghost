using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Net;

namespace Server.Packet
{
    public static class PartyPacket
    {
        public static void PartyInvite(Client c, int CharacterID)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PARTY_INVITE))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(CharacterID); // %s 邀你加入隊伍"
                c.Send(plew);
            }
        }

        public static void PartyInviteResponses(Client c, int Respons)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PARTY_INVITE_RESPONSES))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
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
                    plew.WriteInt(i < chr.Party.getMembers().Count ? chr.Party.getMembers()[i].Character.CharacterID : -1);
                    plew.WriteShort(i < chr.Party.getMembers().Count ? chr.Party.getMembers()[i].Character.Level : 0);
                    plew.WriteString((i < chr.Party.getMembers().Count ? chr.Party.getMembers()[i].Character.Name : ""), 20);
                    plew.WriteShort(i < chr.Party.getMembers().Count ? chr.Party.getMembers()[i].Character.MaxHp : 0);
                    plew.WriteShort(i < chr.Party.getMembers().Count ? chr.Party.getMembers()[i].Character.Hp : 0);
                    plew.WriteShort(i < chr.Party.getMembers().Count ? chr.Party.getMembers()[i].Character.MaxMp : 0);
                    plew.WriteShort(i < chr.Party.getMembers().Count ? chr.Party.getMembers()[i].Character.Mp : 0); // 尚未確認
                    plew.WriteHexString("1F 40");
                    plew.WriteByte(i < chr.Party.getMembers().Count ? chr.Party.getMembers()[i].Character.IP.GetAddressBytes()[0] : 0);
                    plew.WriteByte(i < chr.Party.getMembers().Count ? chr.Party.getMembers()[i].Character.IP.GetAddressBytes()[1] : 0);
                    plew.WriteByte(i < chr.Party.getMembers().Count ? chr.Party.getMembers()[i].Character.IP.GetAddressBytes()[2] : 0);
                    plew.WriteByte(i < chr.Party.getMembers().Count ? chr.Party.getMembers()[i].Character.IP.GetAddressBytes()[3] : 0);
                    plew.WriteByte(i < chr.Party.getMembers().Count ? chr.Party.getMembers()[i].Character.IP.GetAddressBytes()[0] : 0);
                    plew.WriteByte(i < chr.Party.getMembers().Count ? chr.Party.getMembers()[i].Character.IP.GetAddressBytes()[1] : 0);
                    plew.WriteByte(i < chr.Party.getMembers().Count ? chr.Party.getMembers()[i].Character.IP.GetAddressBytes()[2] : 0);
                    plew.WriteByte(i < chr.Party.getMembers().Count ? chr.Party.getMembers()[i].Character.IP.GetAddressBytes()[3] : 0);
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
