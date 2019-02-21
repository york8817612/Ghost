using Server.Common.IO;
using Server.Common.IO.Packet;
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
        public static void p_Warp_c(InPacket lea, Client c)
        {
            if (/*c == null || */lea.Available < 4)
                return;

            int CharacterID = lea.ReadInt();

            Character find = null;
            foreach (Character findCharacter in MapFactory.AllCharacters)
            {
                if (CharacterID == findCharacter.CharacterID)
                {
                    find = findCharacter;
                    break;
                }
            }

            if (find != null)
            {
                Map Map = MapFactory.GetMap(find.MapX, find.MapY);
                if (Map.Characters.Contains(find))
                {
                    Map.Characters.Remove(find);
                    foreach (Character All in Map.Characters)
                        MapPacket.removeUser(All.Client, CharacterID);
                    Log.Inform("(P_WARP_C) CharacterID = {0} , MapX = {1} , MapY = {2}", CharacterID, find.MapX, find.MapY);
                }
            }
        }

        public static void p_Move_c(InPacket lea, Client c)
        {
            if (c == null || lea.Available < 17)
                return;

            int CharacterID = lea.ReadInt();
            float PositionX = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            float PositionY = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            int Speed = lea.ReadInt(); // start = 00 00 40 40 , end = 00 00 00 00
            int Direction = lea.ReadByte(); // right = 01 , left = FF

            Character find = null;
            foreach (Character findCharacter in MapFactory.AllCharacters)
            {
                if (CharacterID == findCharacter.CharacterID)
                {
                    find = findCharacter;
                    break;
                }
            }

            if (find != null && Speed == 0)
            {
                find.PlayerX = ((short)PositionX);
                find.PlayerY = ((short)PositionY);
                //Console.WriteLine("Player New Pos X:{0}, Y:{1}", c.Character.PlayerX, c.Character.PlayerY);
            }

            //Console.WriteLine("Player {0} Move To {1} X:{2}, Y:{3}", Speed == 0 ? "End" : "Start", MoveDirection == 1 ? "Right" : "Left", PositionX, PositionY);
        }

        public static void p_Jump_c(InPacket lea, Client c)
        {
            if (c == null || lea.Available < 16)
                return;

            int CharacterID = lea.ReadInt();
            lea.ReadInt();
            float PositionX = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            float PositionY = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);

            Character find = null;
            foreach (Character findCharacter in MapFactory.AllCharacters)
            {
                if (CharacterID == findCharacter.CharacterID)
                {
                    find = findCharacter;
                    break;
                }
            }

            if (find != null)
            {
                find.PlayerX = ((short)PositionX);
                find.PlayerY = ((short)PositionY);
            }
            //Console.WriteLine("Player New Pos X:{0}, Y:{1}", c.Character.PlayerX, c.Character.PlayerY);
        }

        public static void p_Attack_c(InPacket lea, Client c)
        {
            if (c == null || lea.Available < 4)
                return;

            int CharacterID = lea.ReadInt();

            Character find = null;
            foreach (Character findCharacter in MapFactory.AllCharacters)
            {
                if (CharacterID == findCharacter.CharacterID)
                {
                    find = findCharacter;
                    break;
                }
            }

            if (find != null && find.IsHiding == true)
            {
                Map Map = MapFactory.GetMap(find.MapX, find.MapY);
                find.IsHiding = false;
                foreach (Character All in Map.Characters)
                    StatusPacket.Hide(All.Client, find, 0);
            }
        }

        public static void p_Speed_c(InPacket lea, Client c)
        {
            if (c == null || lea.Available < 20)
                return;

            int CharacterID = lea.ReadInt();
            lea.ReadInt();
            lea.ReadInt();
            float PositionX = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            float PositionY = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);

            Character find = null;
            foreach (Character findCharacter in MapFactory.AllCharacters)
            {
                if (CharacterID == findCharacter.CharacterID)
                {
                    find = findCharacter;
                    break;
                }
            }

            if (find != null)
            {
                find.PlayerX = ((short)PositionX);
                find.PlayerY = ((short)PositionY);
            }
            //Console.WriteLine("Player New Pos X:{0}, Y:{1}", c.Character.PlayerX, c.Character.PlayerY);
        }

        public static void p_Damage_c(InPacket lea, Client c)
        {
            int CharacterID = lea.ReadInt();
            short Damage = lea.ReadShort();
            short Unk = lea.ReadShort();
            float PositionX = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            float PositionY = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);

            var chr = c.Character;
            if (chr == null)
            {
                if (chr.CharacterID == CharacterID)
                {

                }
                else
                {
                    return;
                }
            }
            if (Damage > 0)
                chr.Hp -= Damage;

            if (PositionX != 0)
                chr.PlayerX = ((short)PositionX);
        }

        public static void p_Dead_c(InPacket lea, Client c)
        {
            //var chr = c.Character;
            //int CharacterID = lea.ReadInt();
            //MapPacket.userDead(c);
            //chr.IsAlive = false;
            //chr.Exp -= (int)(chr.Exp * 0.2);
        }

        public static void p_Move_c_2(InPacket lea, Client c)
        {
            if (c == null || lea.Available < 12)
                return;

            int CharacterID = lea.ReadInt();
            float PositionX = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);
            float PositionY = BitConverter.ToSingle(BitConverter.GetBytes(lea.ReadInt()), 0);

            Character find = null;
            foreach (Character findCharacter in MapFactory.AllCharacters)
            {
                if (CharacterID == findCharacter.CharacterID)
                {
                    find = findCharacter;
                    break;
                }
            }

            if (find != null)
            {
                find.PlayerX = ((short)PositionX);
                find.PlayerY = ((short)PositionY);
            }
            //Console.WriteLine("Player New Pos X:{0}, Y:{1}", c.Character.PlayerX, c.Character.PlayerY);
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
