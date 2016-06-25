using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Common.Utilities;
using Server.Ghost;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;
using System;

namespace Server.Handler
{
    public static class ActionHandler
    {
        public static void p_Move_c(InPacket lea, Client c)
        {
            int CharacterID = lea.ReadInt();
            float PositionX = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            float PositionY = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            int Speed = lea.ReadInt(); // start = 00 00 40 40 , end = 00 00 00 00
            int MoveDirection = lea.ReadByte(); // right = 01 , left = FF

            if (c != null && Speed == 0)
            {
                if (c.Character != null)
                {
                    c.Character.PlayerX = ((short)PositionX);
                    c.Character.PlayerY = ((short)PositionY);
                    Console.WriteLine("Player New Pos X:{0}, Y:{1}", c.Character.PlayerX, c.Character.PlayerY);
                }
            }

            Console.WriteLine("Player {0} Move To {1} X:{2}, Y:{3}", Speed == 0 ? "End" : "Start", MoveDirection == 1 ? "Right" : "Left", PositionX, PositionY);
        }

        public static void p_Jump_c(InPacket lea, Client c)
        {
            lea.ReadInt();
            lea.ReadInt();
            float PositionX = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            float PositionY = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);


            if (c != null)
            {
                if (c.Character != null)
                {
                    c.Character.PlayerX = ((short)PositionX);
                    c.Character.PlayerY = ((short)PositionY);
                    Console.WriteLine("Player New Pos X:{0}, Y:{1}", c.Character.PlayerX, c.Character.PlayerY);
                }
            }
        }

        public static void p_Speed_c(InPacket lea, Client c)
        {
            lea.ReadInt();
            lea.ReadInt();
            lea.ReadInt();
            float PositionX = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            float PositionY = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);


            if (c != null)
            {
                if (c.Character != null)
                {
                    c.Character.PlayerX = ((short)PositionX);
                    c.Character.PlayerY = ((short)PositionY);
                    Console.WriteLine("Player New Pos X:{0}, Y:{1}", c.Character.PlayerX, c.Character.PlayerY);
                }
            }
        }

        public static void p_Damage_c(InPacket lea, Client c)
        {
            //int CharacterID = lea.ReadInt();
            //short Damage = lea.ReadShort();
            //var chr = c.Character;
            //chr.Hp -= Damage;
        }

        public static void p_Dead_c(InPacket lea, Client c)
        {
            //var chr = c.Character;
            //int CharacterID = lea.ReadInt();
            //MapPacket.userDead(c);
            //chr.IsAlive = false;
            //chr.Exp -= (int)(chr.Exp * 0.2);
        }

        public static void p_Move(InPacket lea, Client c)
        {
            int CharacterID = lea.ReadInt();
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

        public static void Pet_Move_C(InPacket lea, Client c)
        {
            //int CharacterID = lea.ReadInt();
            //float posX = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            //float posY = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            //int Speed = lea.ReadInt();
        }

        public static void Pet_Attack_C(InPacket lea, Client c)
        {
            //int CharacterID = lea.ReadInt();
            //lea.ReadShort();
            //lea.ReadShort();
            //int OriginalID = lea.ReadShort();
            //lea.ReadInt();
            //int Damage = lea.ReadShort();
            //var chr = c.Character;
            //Map map = MapFactory.GetMap(chr.MapX, chr.MapY);
        }
    }
}
