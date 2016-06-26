using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Net;

namespace Server.Packet
{
    public class PetPacket
    {
        public static void PetName(Client c, string Name)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.PET_NAME_ACK))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                // Packet 未知
                c.Send(plew);
            }
        }
    }
}
