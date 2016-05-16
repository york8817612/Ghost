using Server.Common.IO.Packet;
using Server.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Handler
{
    public static class ActionHandler
    {
        public static void p_Move_c(InPacket lea, Client c)
        {
            lea.ReadInt();
            float posX = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            float posY = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            int moveState = lea.ReadInt(); // start = 00 00 40 40 , end = 00 00 00 00
            int moveDirection = lea.ReadByte(); // right = 01 , left = FF

            if (c != null && moveState  == 0)
            {
                if (c.Character != null)
                {
                    c.Character.PlayerX = ((short)posX);
                    c.Character.PlayerY = ((short)posY);
                    Console.WriteLine("Player New Pos X:{0}, Y:{1}", c.Character.PlayerX, c.Character.PlayerY);
                }
            }

            Console.WriteLine("Player {0} Move To {1} X:{2}, Y:{3}", moveState == 0 ? "End" : "Start", moveDirection == 1 ? "Right" : "Left", posX, posY);
        }

        public static void p_Jump_c(InPacket lea, Client c)
        {
            lea.ReadInt();
            lea.ReadInt();
            float posX = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            float posY = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            

            if (c != null)
            {
                if (c.Character != null)
                {
                    c.Character.PlayerX = ((short)posX);
                    c.Character.PlayerY = ((short)posY);
                    Console.WriteLine("Player New Pos X:{0}, Y:{1}", c.Character.PlayerX, c.Character.PlayerY);
                }
            }
        }

        public static void p_Speed_c(InPacket lea, Client c)
        {
            lea.ReadInt();
            lea.ReadInt();
            lea.ReadInt();
            float posX = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            float posY = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);


            if (c != null)
            {
                if (c.Character != null)
                {
                    c.Character.PlayerX = ((short)posX);
                    c.Character.PlayerY = ((short)posY);
                    Console.WriteLine("Player New Pos X:{0}, Y:{1}", c.Character.PlayerX, c.Character.PlayerY);
                }
            }
        }
    }
}
