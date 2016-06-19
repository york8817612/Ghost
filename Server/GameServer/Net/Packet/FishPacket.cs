using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Net;

namespace Server.Packet
{
    public static class FishPacket
    {
        public static void Fish(Client c, int ChararcterID, int State, bool IsFishing)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.FISH_ACK))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(ChararcterID);
                plew.WriteInt(State); // -1: 釣竿損壞 -2: 沒有魚餌 -3: 行囊已滿
                plew.WriteInt(IsFishing == false ? 0 : 1);
                c.Send(plew);
            }
        }
    }
}
