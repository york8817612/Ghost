using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Net;

namespace Server.Ghost
{
    public static class MessengerPacket
    {
        public static void GameLog(Client c, int CharacterID)
        {
            using (var plew = new OutPacket(MessengerServerOpcode.MSG_GAMELOG))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(CharacterID);
                plew.WriteLong(0);
                c.Send(plew);
            }
        }
    }
}
