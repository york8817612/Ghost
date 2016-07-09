using Server.Common;
using Server.Ghost.Characters;
using Server.Handler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Server.Ghost.Provider
{
    public static class MapFactory
    {
        private static List<Map> Maps { get; set; }
        public static List<Character> AllCharacters = new List<Character>();

        public static void Initialize()
        {
            Maps = new List<Map>();
            Maps.Add(new Map(0, 0));
            Maps.Add(new Map(0, 1));
            Maps.Add(new Map(0, 2));
            Maps.Add(new Map(100, 1));
            Maps.Add(new Map(100, 10));
            Maps.Add(new Map(100, 100));
            Maps.Add(new Map(100, 101));
            //maps.Add(new Map(100, 11));
            //maps.Add(new Map(100, 12));
            //maps.Add(new Map(100, 13));
            //maps.Add(new Map(100, 14));
            //maps.Add(new Map(100, 15));
            //maps.Add(new Map(100, 16));
            //maps.Add(new Map(100, 17));
            //maps.Add(new Map(100, 18));
            //maps.Add(new Map(100, 19));
            Maps.Add(new Map(100, 2));
            //maps.Add(new Map(100, 20));
            //maps.Add(new Map(100, 21));
            //maps.Add(new Map(100, 22));
            //maps.Add(new Map(100, 23));
            //maps.Add(new Map(100, 24));
            //maps.Add(new Map(100, 25));
            //maps.Add(new Map(100, 26));
            //maps.Add(new Map(100, 27));
            //maps.Add(new Map(100, 28));
            //maps.Add(new Map(100, 29));
            Maps.Add(new Map(100, 3));
            Maps.Add(new Map(100, 4));
            Maps.Add(new Map(100, 40));
            Maps.Add(new Map(100, 41));
            //maps.Add(new Map(100, 5));
            Maps.Add(new Map(1011, 1));
            Maps.Add(new Map(1011, 2));
            //maps.Add(new Map(1012, 1));
            //maps.Add(new Map(1012, 2));
            //maps.Add(new Map(1013, 1));
            //maps.Add(new Map(1013, 2));
            //maps.Add(new Map(1014, 1));
            //maps.Add(new Map(1014, 2));
            //maps.Add(new Map(1015, 1));
            //maps.Add(new Map(1015, 2));
            Maps.Add(new Map(1041, 1));
            Maps.Add(new Map(1041, 2));
            //maps.Add(new Map(1042, 1));
            //maps.Add(new Map(1042, 2));
            //maps.Add(new Map(1043, 1));
            //maps.Add(new Map(1043, 2));
            //maps.Add(new Map(1044, 1));
            //maps.Add(new Map(1044, 2));
            //maps.Add(new Map(1045, 1));
            //maps.Add(new Map(1045, 2));
            Maps.Add(new Map(10, 1));
            Maps.Add(new Map(10, 2));
            Maps.Add(new Map(10, 21));
            Maps.Add(new Map(10, 22));
            Maps.Add(new Map(10, 23));
            Maps.Add(new Map(10, 3));
            Maps.Add(new Map(10, 31));
            Maps.Add(new Map(10, 32));
            Maps.Add(new Map(10, 33));
            Maps.Add(new Map(10, 34));
            Maps.Add(new Map(10, 35));
            Maps.Add(new Map(10, 36));
            Maps.Add(new Map(10, 37));
            Maps.Add(new Map(10, 38));
            Maps.Add(new Map(10, 4));
            Maps.Add(new Map(10, 5));
            Maps.Add(new Map(10, 60));
            Maps.Add(new Map(10, 61));
            //Maps.Add(new Map(10, 62));
            Maps.Add(new Map(10, 63));
            //Maps.Add(new Map(10, 64));
            Maps.Add(new Map(11, 1));
            Maps.Add(new Map(11, 2));
            Maps.Add(new Map(11, 21));
            Maps.Add(new Map(11, 3));
            //maps.Add(new Map(11, 31));
            //maps.Add(new Map(11, 32));
            //maps.Add(new Map(11, 33));
            //maps.Add(new Map(11, 34));
            //maps.Add(new Map(11, 35));
            //maps.Add(new Map(11, 36));
            //maps.Add(new Map(11, 37));
            //maps.Add(new Map(11, 38));
            //maps.Add(new Map(11, 39));
            Maps.Add(new Map(11, 4));
            //maps.Add(new Map(11, 41));
            //maps.Add(new Map(11, 42));
            //maps.Add(new Map(11, 43));
            //maps.Add(new Map(11, 44));
            //maps.Add(new Map(11, 45));
            //maps.Add(new Map(11, 46));
            //maps.Add(new Map(11, 47));
            //maps.Add(new Map(11, 48));
            //maps.Add(new Map(11, 49));
            Maps.Add(new Map(11, 5));
            Maps.Add(new Map(11, 6));
            Maps.Add(new Map(11, 7));
            Maps.Add(new Map(12, 1));
            Maps.Add(new Map(12, 2));
            Maps.Add(new Map(13, 1));
            Maps.Add(new Map(13, 2));
            Maps.Add(new Map(13, 21));
            Maps.Add(new Map(13, 22));
            Maps.Add(new Map(13, 29));
            Maps.Add(new Map(13, 3));
            Maps.Add(new Map(13, 4));
            Maps.Add(new Map(13, 5));
            Maps.Add(new Map(13, 6));
            Maps.Add(new Map(13, 7));
            Maps.Add(new Map(14, 0));
            Maps.Add(new Map(14, 1));
            Maps.Add(new Map(14, 2));
            Maps.Add(new Map(14, 21));
            Maps.Add(new Map(14, 22));
            Maps.Add(new Map(14, 3));
            Maps.Add(new Map(14, 4));
            Maps.Add(new Map(14, 5));
            Maps.Add(new Map(14, 6));
            Maps.Add(new Map(14, 7));
            Maps.Add(new Map(14, 8));
            Maps.Add(new Map(15, 1));
            Maps.Add(new Map(15, 2));
            Maps.Add(new Map(15, 21));
            Maps.Add(new Map(15, 22));
            Maps.Add(new Map(15, 23));
            Maps.Add(new Map(15, 3));
            Maps.Add(new Map(15, 4));
            Maps.Add(new Map(15, 5));
            Maps.Add(new Map(15, 6));
            Maps.Add(new Map(16, 1));
            Maps.Add(new Map(16, 40));
            Maps.Add(new Map(17, 1));
            Maps.Add(new Map(17, 2));
            Maps.Add(new Map(17, 21));
            Maps.Add(new Map(17, 22));
            Maps.Add(new Map(17, 3));
            Maps.Add(new Map(17, 4));
            Maps.Add(new Map(17, 5));
            Maps.Add(new Map(17, 6));
            Maps.Add(new Map(17, 7));
            Maps.Add(new Map(18, 1));
            Maps.Add(new Map(18, 10));
            Maps.Add(new Map(18, 11));
            Maps.Add(new Map(18, 12));
            Maps.Add(new Map(18, 13));
            Maps.Add(new Map(18, 2));
            Maps.Add(new Map(18, 21));
            Maps.Add(new Map(18, 22));
            Maps.Add(new Map(18, 23));
            Maps.Add(new Map(18, 3));
            Maps.Add(new Map(18, 4));
            Maps.Add(new Map(18, 5));
            Maps.Add(new Map(18, 6));
            Maps.Add(new Map(18, 7));
            Maps.Add(new Map(19, 1));
            Maps.Add(new Map(19, 2));
            Maps.Add(new Map(19, 21));
            Maps.Add(new Map(19, 22));
            Maps.Add(new Map(19, 23));
            Maps.Add(new Map(19, 24));
            Maps.Add(new Map(19, 3));
            Maps.Add(new Map(19, 4));
            Maps.Add(new Map(19, 5));
            Maps.Add(new Map(19, 6));
            Maps.Add(new Map(19, 7));
            Maps.Add(new Map(1, 1));
            Maps.Add(new Map(1, 12));
            Maps.Add(new Map(1, 2));
            Maps.Add(new Map(1, 3));
            Maps.Add(new Map(1, 4));
            Maps.Add(new Map(1, 41));
            Maps.Add(new Map(1, 42));
            Maps.Add(new Map(1, 43));
            Maps.Add(new Map(1, 50));
            Maps.Add(new Map(1, 51));
            Maps.Add(new Map(1, 52));
            //Maps.Add(new Map(1, 53));
            //Maps.Add(new Map(1, 54));
            //Maps.Add(new Map(1, 55));
            Maps.Add(new Map(1, 60));
            Maps.Add(new Map(1, 61));
            Maps.Add(new Map(1, 62));
            Maps.Add(new Map(1, 63));
            Maps.Add(new Map(1, 90));
            Maps.Add(new Map(20, 0));
            Maps.Add(new Map(20, 1));
            Maps.Add(new Map(20, 10));
            Maps.Add(new Map(20, 11));
            Maps.Add(new Map(20, 12));
            Maps.Add(new Map(20, 13));
            Maps.Add(new Map(20, 14));
            Maps.Add(new Map(20, 15));
            Maps.Add(new Map(20, 16));
            Maps.Add(new Map(20, 17));
            Maps.Add(new Map(20, 2));
            Maps.Add(new Map(20, 21));
            Maps.Add(new Map(20, 22));
            Maps.Add(new Map(20, 3));
            Maps.Add(new Map(20, 4));
            Maps.Add(new Map(20, 5));
            Maps.Add(new Map(20, 6));
            Maps.Add(new Map(20, 7));
            Maps.Add(new Map(20, 70));
            Maps.Add(new Map(20, 71));
            Maps.Add(new Map(20, 72));
            Maps.Add(new Map(20, 8));
            Maps.Add(new Map(20, 9));
            //maps.Add(new Map(21, 0));
            Maps.Add(new Map(21, 1));
            Maps.Add(new Map(21, 10));
            Maps.Add(new Map(21, 11));
            Maps.Add(new Map(21, 12));
            Maps.Add(new Map(21, 13));
            Maps.Add(new Map(21, 14));
            Maps.Add(new Map(21, 15));
            Maps.Add(new Map(21, 16));
            Maps.Add(new Map(21, 17));
            Maps.Add(new Map(21, 18));
            Maps.Add(new Map(21, 2));
            Maps.Add(new Map(21, 21));
            Maps.Add(new Map(21, 22));
            Maps.Add(new Map(21, 3));
            Maps.Add(new Map(21, 4));
            Maps.Add(new Map(21, 5));
            Maps.Add(new Map(21, 6));
            Maps.Add(new Map(21, 7));
            Maps.Add(new Map(21, 71));
            Maps.Add(new Map(21, 72));
            Maps.Add(new Map(21, 8));
            Maps.Add(new Map(21, 9));
            Maps.Add(new Map(22, 1));
            Maps.Add(new Map(22, 10));
            Maps.Add(new Map(22, 11));
            Maps.Add(new Map(22, 12));
            Maps.Add(new Map(22, 13));
            Maps.Add(new Map(22, 14));
            Maps.Add(new Map(22, 15));
            Maps.Add(new Map(22, 16));
            Maps.Add(new Map(22, 17));
            Maps.Add(new Map(22, 18));
            Maps.Add(new Map(22, 19));
            Maps.Add(new Map(22, 2));
            Maps.Add(new Map(22, 20));
            Maps.Add(new Map(22, 21));
            Maps.Add(new Map(22, 3));
            Maps.Add(new Map(22, 4));
            Maps.Add(new Map(22, 5));
            Maps.Add(new Map(22, 6));
            Maps.Add(new Map(22, 7));
            Maps.Add(new Map(22, 8));
            Maps.Add(new Map(22, 9));
            Maps.Add(new Map(23, 1));
            Maps.Add(new Map(23, 10));
            Maps.Add(new Map(23, 11));
            Maps.Add(new Map(23, 12));
            Maps.Add(new Map(23, 13));
            Maps.Add(new Map(23, 14));
            Maps.Add(new Map(23, 15));
            Maps.Add(new Map(23, 16));
            Maps.Add(new Map(23, 17));
            Maps.Add(new Map(23, 18));
            Maps.Add(new Map(23, 2));
            Maps.Add(new Map(23, 3));
            Maps.Add(new Map(23, 4));
            Maps.Add(new Map(23, 5));
            Maps.Add(new Map(23, 6));
            Maps.Add(new Map(23, 7));
            Maps.Add(new Map(23, 8));
            Maps.Add(new Map(23, 9));
            Maps.Add(new Map(24, 1));
            Maps.Add(new Map(24, 2));
            Maps.Add(new Map(24, 21));
            Maps.Add(new Map(24, 22));
            Maps.Add(new Map(24, 23));
            Maps.Add(new Map(24, 24));
            Maps.Add(new Map(24, 25));
            Maps.Add(new Map(24, 26));
            Maps.Add(new Map(24, 3));
            Maps.Add(new Map(24, 4));
            Maps.Add(new Map(25, 1));
            Maps.Add(new Map(25, 2));
            Maps.Add(new Map(26, 0));
            Maps.Add(new Map(26, 1));
            Maps.Add(new Map(26, 10));
            Maps.Add(new Map(26, 11));
            Maps.Add(new Map(26, 12));
            Maps.Add(new Map(26, 13));
            Maps.Add(new Map(26, 14));
            Maps.Add(new Map(26, 2));
            Maps.Add(new Map(26, 21));
            Maps.Add(new Map(26, 22));
            Maps.Add(new Map(26, 23));
            Maps.Add(new Map(26, 3));
            Maps.Add(new Map(26, 4));
            Maps.Add(new Map(26, 5));
            Maps.Add(new Map(26, 6));
            Maps.Add(new Map(26, 7));
            Maps.Add(new Map(26, 8));
            Maps.Add(new Map(26, 9));
            Maps.Add(new Map(27, 0));
            Maps.Add(new Map(27, 1));
            Maps.Add(new Map(27, 2));
            Maps.Add(new Map(28, 1));
            Maps.Add(new Map(28, 10));
            Maps.Add(new Map(28, 11));
            Maps.Add(new Map(28, 12));
            Maps.Add(new Map(28, 13));
            Maps.Add(new Map(28, 14));
            Maps.Add(new Map(28, 15));
            Maps.Add(new Map(28, 16));
            Maps.Add(new Map(28, 17));
            Maps.Add(new Map(28, 18));
            Maps.Add(new Map(28, 19));
            Maps.Add(new Map(28, 2));
            Maps.Add(new Map(28, 20));
            Maps.Add(new Map(28, 3));
            Maps.Add(new Map(28, 4));
            Maps.Add(new Map(28, 5));
            Maps.Add(new Map(28, 6));
            Maps.Add(new Map(28, 7));
            Maps.Add(new Map(28, 8));
            Maps.Add(new Map(28, 9));
            Maps.Add(new Map(2, 1));
            Maps.Add(new Map(2, 2));
            Maps.Add(new Map(2, 21));
            Maps.Add(new Map(2, 22));
            Maps.Add(new Map(2, 3));
            Maps.Add(new Map(2, 4));
            Maps.Add(new Map(2, 5));
            Maps.Add(new Map(2, 6));
            Maps.Add(new Map(2, 7));
            Maps.Add(new Map(2, 8));
            Maps.Add(new Map(2, 9));
            Maps.Add(new Map(31, 1));
            Maps.Add(new Map(31, 10));
            Maps.Add(new Map(31, 2));
            Maps.Add(new Map(31, 3));
            Maps.Add(new Map(31, 4));
            Maps.Add(new Map(31, 5));
            Maps.Add(new Map(31, 6));
            Maps.Add(new Map(31, 7));
            Maps.Add(new Map(31, 8));
            Maps.Add(new Map(31, 9));
            Maps.Add(new Map(32, 1));
            Maps.Add(new Map(32, 2));
            Maps.Add(new Map(32, 3));
            Maps.Add(new Map(32, 4));
            Maps.Add(new Map(33, 1));
            Maps.Add(new Map(33, 2));
            Maps.Add(new Map(33, 21));
            Maps.Add(new Map(33, 22));
            Maps.Add(new Map(33, 23));
            Maps.Add(new Map(33, 24));
            Maps.Add(new Map(33, 3));
            Maps.Add(new Map(33, 4));
            Maps.Add(new Map(33, 5));
            Maps.Add(new Map(33, 6));
            Maps.Add(new Map(33, 7));
            Maps.Add(new Map(35, 1));
            Maps.Add(new Map(35, 2));
            Maps.Add(new Map(35, 3));
            Maps.Add(new Map(35, 4));
            Maps.Add(new Map(3, 1));
            Maps.Add(new Map(3, 2));
            Maps.Add(new Map(3, 3));
            Maps.Add(new Map(3, 4));
            Maps.Add(new Map(3, 5));
            Maps.Add(new Map(3, 6));
            Maps.Add(new Map(3, 7));
            Maps.Add(new Map(3, 70));
            Maps.Add(new Map(3, 71));
            Maps.Add(new Map(3, 72));
            Maps.Add(new Map(3, 73));
            Maps.Add(new Map(3, 74));
            Maps.Add(new Map(3, 8));
            Maps.Add(new Map(3, 9));
            Maps.Add(new Map(3, 91));
            Maps.Add(new Map(42, 1));
            Maps.Add(new Map(42, 2));
            Maps.Add(new Map(42, 22));
            Maps.Add(new Map(42, 3));
            Maps.Add(new Map(42, 4));
            Maps.Add(new Map(42, 41));
            Maps.Add(new Map(42, 50));
            Maps.Add(new Map(42, 51));
            Maps.Add(new Map(42, 52));
            Maps.Add(new Map(42, 53));
            Maps.Add(new Map(42, 54));
            Maps.Add(new Map(43, 0));
            Maps.Add(new Map(43, 1));
            Maps.Add(new Map(43, 10));
            Maps.Add(new Map(43, 11));
            Maps.Add(new Map(43, 12));
            Maps.Add(new Map(43, 2));
            Maps.Add(new Map(43, 21));
            Maps.Add(new Map(43, 22));
            Maps.Add(new Map(43, 23));
            Maps.Add(new Map(43, 3));
            Maps.Add(new Map(43, 4));
            Maps.Add(new Map(43, 5));
            Maps.Add(new Map(43, 6));
            Maps.Add(new Map(43, 7));
            Maps.Add(new Map(43, 8));
            Maps.Add(new Map(43, 9));
            Maps.Add(new Map(44, 1));
            Maps.Add(new Map(44, 10));
            Maps.Add(new Map(44, 11));
            Maps.Add(new Map(44, 12));
            Maps.Add(new Map(44, 2));
            Maps.Add(new Map(44, 21));
            Maps.Add(new Map(44, 22));
            Maps.Add(new Map(44, 23));
            Maps.Add(new Map(44, 3));
            Maps.Add(new Map(44, 4));
            Maps.Add(new Map(44, 5));
            Maps.Add(new Map(44, 6));
            Maps.Add(new Map(44, 7));
            Maps.Add(new Map(44, 8));
            Maps.Add(new Map(44, 9));
            Maps.Add(new Map(45, 0));
            Maps.Add(new Map(45, 1));
            Maps.Add(new Map(45, 10));
            Maps.Add(new Map(45, 11));
            Maps.Add(new Map(45, 2));
            Maps.Add(new Map(45, 3));
            Maps.Add(new Map(45, 4));
            Maps.Add(new Map(45, 5));
            Maps.Add(new Map(45, 6));
            Maps.Add(new Map(45, 7));
            Maps.Add(new Map(45, 8));
            Maps.Add(new Map(45, 9));
            Maps.Add(new Map(46, 1));
            Maps.Add(new Map(46, 2));
            Maps.Add(new Map(47, 0));
            Maps.Add(new Map(47, 1));
            Maps.Add(new Map(47, 10));
            Maps.Add(new Map(47, 11));
            Maps.Add(new Map(47, 12));
            Maps.Add(new Map(47, 2));
            Maps.Add(new Map(47, 21));
            Maps.Add(new Map(47, 22));
            Maps.Add(new Map(47, 3));
            Maps.Add(new Map(47, 4));
            Maps.Add(new Map(47, 5));
            Maps.Add(new Map(47, 6));
            Maps.Add(new Map(47, 7));
            Maps.Add(new Map(47, 8));
            Maps.Add(new Map(47, 9));
            Maps.Add(new Map(4, 1));
            Maps.Add(new Map(4, 2));
            Maps.Add(new Map(4, 21));
            Maps.Add(new Map(4, 22));
            Maps.Add(new Map(4, 23));
            Maps.Add(new Map(4, 3));
            Maps.Add(new Map(4, 4));
            Maps.Add(new Map(4, 5));
            Maps.Add(new Map(4, 6));
            Maps.Add(new Map(4, 7));
            Maps.Add(new Map(5, 1));
            Maps.Add(new Map(5, 2));
            Maps.Add(new Map(5, 21));
            Maps.Add(new Map(5, 22));
            Maps.Add(new Map(5, 3));
            Maps.Add(new Map(5, 4));
            Maps.Add(new Map(5, 5));
            Maps.Add(new Map(5, 6));
            Maps.Add(new Map(5, 7));
            Maps.Add(new Map(66, 6));
            Maps.Add(new Map(6, 1));
            Maps.Add(new Map(6, 2));
            Maps.Add(new Map(6, 21));
            Maps.Add(new Map(6, 22));
            Maps.Add(new Map(6, 23));
            Maps.Add(new Map(6, 3));
            Maps.Add(new Map(6, 4));
            Maps.Add(new Map(6, 5));
            Maps.Add(new Map(6, 6));
            Maps.Add(new Map(6, 7));
            Maps.Add(new Map(77, 1));
            Maps.Add(new Map(7, 1));
            Maps.Add(new Map(7, 2));
            Maps.Add(new Map(7, 29));
            Maps.Add(new Map(7, 3));
            Maps.Add(new Map(7, 4));
            Maps.Add(new Map(7, 5));
            Maps.Add(new Map(8, 1));
            Maps.Add(new Map(8, 2));
            Maps.Add(new Map(8, 21));
            Maps.Add(new Map(8, 22));
            Maps.Add(new Map(8, 23));
            Maps.Add(new Map(8, 3));
            Maps.Add(new Map(8, 4));
            Maps.Add(new Map(8, 5));
            Maps.Add(new Map(8, 6));
            Maps.Add(new Map(8, 7));
            Maps.Add(new Map(9, 1));
            Maps.Add(new Map(9, 10));
            Maps.Add(new Map(9, 11));
            Maps.Add(new Map(9, 2));
            Maps.Add(new Map(9, 3));
            Maps.Add(new Map(9, 4));
            Maps.Add(new Map(9, 5));
            Maps.Add(new Map(9, 6));
            Maps.Add(new Map(9, 7));
            Maps.Add(new Map(9, 8));
            Maps.Add(new Map(9, 9));
            foreach (Map Map in Maps)
            {
                //if ((Map.MapX == 1 && Map.MapY == 53) || (Map.MapX == 1 && Map.MapY == 54) || (Map.MapX == 1 && Map.MapY == 55))
                //    continue;
                LoadMapPexelsData(Map);
                ParsePrjFile(Map);
            }
            Maps.Add(new Map(1, 53));
            Maps.Add(new Map(1, 54));
            Maps.Add(new Map(1, 55));
            Maps.Add(new Map(10, 62));
            Maps.Add(new Map(10, 64));
            Map M1 = GetMap(1, 53);
            Map M2 = GetMap(1, 54);
            Map M3 = GetMap(1, 55);
            Map M4 = GetMap(10, 62);
            Map M5 = GetMap(10, 64);
            M1 = GetMap(1, 52);
            M1 = GetMap(1, 52);
            M1 = GetMap(1, 52);
            M4 = GetMap(10, 61);
            M5 = GetMap(10, 63);
        }

        public static Map GetMap(short mapX, short mapY)
        {
            Map map = Maps.Find(i => (i.MapX == mapX && i.MapY == mapY));
            return map;
        }

        public static void LoadMapPexelsData(Map map)
        {
            string openPath = Application.LaunchPath + @"\Data\Map\t" + map.MapX + "_s" + map.MapY + ".map";

            FileStream file = File.Open(openPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(file);

            sbyte Index = 0;
            sbyte Data;
            int Width = br.ReadInt32();
            int Height = br.ReadInt32();
            map.SetMapHeightWidth(Height, Width);
            for (int f = 0; f < Width; f++)
            {
                for (int i = 0; i < Height; i++)
                {
                    br.ReadByte();
                    br.ReadByte();
                    Index = br.ReadSByte();
                    map.SetMapPexel(f * 32 + f, i, Index);
                    for (int j = 0; j < 32; j++)
                    {
                        Data = br.ReadSByte();
                        map.SetMapPexel(f * 32 + f + 1 + j, i, Data);
                    }
                    br.ReadByte();
                }
            }

            ////////////////////////
            for (int f = 0; f < Width; f++)
            {
                for (int i = 0; i < Height; i++)
                {
                    br.ReadByte();
                    br.ReadByte();
                    Index = br.ReadSByte();
                    if (Index != -1)
                        map.SetMapPexel(f * 32 + f, i, Index);
                    for (int j = 0; j < 32; j++)
                    {
                        Data = br.ReadSByte();
                        if (Data != -1)
                            map.SetMapPexel(f * 32 + f + 1 + j, i, Data);
                    }
                    br.ReadByte();
                }
            }
            file.Close();
            br.Close();
        }

        public static void ParsePrjFile(Map Map)
        {
            string FileName = Application.LaunchPath + @"\Data\Project\t" + Map.MapX + "_s" + Map.MapY + ".prj";
            using (FileStream stream = new FileStream(FileName, FileMode.Open))
            {
                BinaryReader reader = new BinaryReader(stream);
                try
                {
                    Dictionary<int, string> prjStr = new Dictionary<int, string>();
                    ReadString str = new ReadString();
                    str.FiersRead = reader.ReadBytes(0xA0);
                    str.Decode();
                    string name = str.Name;
                    int val1 = reader.ReadInt32();
                    int val2 = reader.ReadInt32();
                    int val3 = reader.ReadInt32();

                    //=========================================sub_655150
                    int strCount = reader.ReadInt32();

                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x100);
                            str.Decode();

                        }
                    }
                    str.FiersRead = reader.ReadBytes(0x100);
                    str.Decode();

                    str.FiersRead = reader.ReadBytes(0x100);
                    str.Decode();


                    strCount = reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x100);
                            str.Decode();

                        }
                    }
                    strCount = reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x100);
                            str.Decode();

                        }
                    }

                    //=========================================sub_6531D0
                    int val5 = reader.ReadInt32();
                    int val6 = reader.ReadInt32();
                    int val7 = reader.ReadInt32();
                    str.FiersRead = reader.ReadBytes(0x100);
                    str.Decode();

                    str.FiersRead = reader.ReadBytes(0x100);
                    str.Decode();

                    strCount = reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x100);
                            str.Decode();

                        }
                    }
                    //=========================================(1)sub_652FA0
                    strCount = reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x100);
                            str.Decode();

                            reader.ReadBytes(0x10);
                            reader.ReadInt32();
                            reader.ReadInt32();
                            reader.ReadInt32();
                            reader.ReadInt32();
                        }
                    }
                    //=========================================(2)
                    strCount = reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            reader.ReadInt32();
                            reader.ReadInt32();
                            reader.ReadInt32();
                            reader.ReadInt32();
                        }
                    }
                    //=========================================(3)sub_653460
                    //地圖物件
                    strCount = reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x100);
                            str.Decode();

                            reader.ReadInt32();
                            reader.ReadInt32();
                            str.FiersRead = reader.ReadBytes(0x100);
                            str.Decode();

                            str.FiersRead = reader.ReadBytes(0x100);
                            str.Decode();

                            reader.ReadInt32();
                            reader.ReadInt32();
                            reader.ReadInt32();
                            reader.ReadByte();
                            reader.ReadBytes(0x14);
                        }
                    }
                    //=========================================(4)sub_653750
                    //怪物
                    strCount = reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x100);
                            str.Decode();

                            int mv1 = reader.ReadInt32();
                            int mv2 = reader.ReadInt32();
                            str.FiersRead = reader.ReadBytes(0x100);
                            str.Decode();

                            str.FiersRead = reader.ReadBytes(0x100);
                            str.Decode();

                            int mv3 = reader.ReadInt32();
                            int mv4 = reader.ReadInt32();
                            int mv5 = reader.ReadInt32();
                            int mv6 = reader.ReadInt32();
                            int mv7 = reader.ReadByte();
                            int mv8 = reader.ReadInt32();
                            int mv9 = reader.ReadInt32();
                            reader.ReadBytes(0x14);
                        }
                    }
                    //=========================================(5)sub_653A20
                    //讀取NPC資訊
                    strCount = reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x100);
                            str.Decode();

                            reader.ReadInt32();
                            reader.ReadInt32();
                            str.FiersRead = reader.ReadBytes(0x100);
                            str.Decode();

                            str.FiersRead = reader.ReadBytes(0x100);
                            str.Decode();
                            reader.ReadInt32();
                            reader.ReadByte();
                            reader.ReadInt16();
                            reader.ReadInt16();
                            reader.ReadInt32();
                            reader.ReadBytes(0xC);
                        }
                    }
                    //=========================================(6)sub_653CF0
                    strCount = reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x100);
                            str.Decode();
                            reader.ReadInt32();
                            reader.ReadInt32();
                            str.FiersRead = reader.ReadBytes(0x100);
                            str.Decode();
                            str.FiersRead = reader.ReadBytes(0x100);
                            str.Decode();
                            reader.ReadInt32();
                            reader.ReadInt32();
                            reader.ReadInt32();
                            reader.ReadInt32();
                            reader.ReadByte();
                            reader.ReadBytes(0x14);
                        }
                    }
                    //=========================================(7)sub_653E70
                    strCount = reader.ReadInt32();
                    reader.ReadInt32();
                    reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x28);
                            str.Decode();
                            reader.ReadInt32();
                            reader.ReadByte();
                            reader.ReadInt32();
                            reader.ReadInt32();
                            reader.ReadInt32();
                        }
                    }
                    //=========================================(8)sub_653E70
                    strCount = reader.ReadInt32();
                    reader.ReadInt32();
                    reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x28);
                            str.Decode();
                            reader.ReadInt32();
                            reader.ReadByte();
                            reader.ReadInt32();
                            reader.ReadInt32();
                            reader.ReadInt32();
                        }
                    }
                    //=========================================(9)sub_653E70
                    strCount = reader.ReadInt32();
                    reader.ReadInt32();
                    reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x28);
                            str.Decode();
                            reader.ReadInt32();
                            reader.ReadByte();
                            reader.ReadInt32();
                            reader.ReadInt32();
                            reader.ReadInt32();
                        }
                    }
                    //=========================================(10)sub_653E70
                    strCount = reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x28);
                            str.Decode();
                            reader.ReadInt32();
                            reader.ReadByte();
                            reader.ReadInt32();
                            reader.ReadInt32();
                            reader.ReadInt32();
                        }
                    }
                    //=========================================(11)sub_653E70
                    strCount = reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x28);
                            str.Decode();
                            reader.ReadInt32();
                            reader.ReadByte();
                            reader.ReadInt32();
                            reader.ReadInt32();
                            reader.ReadInt32();
                        }
                    }
                    //=========================================(12)sub_653E70
                    strCount = reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x28);
                            str.Decode();
                            reader.ReadInt32();
                            reader.ReadByte();
                            reader.ReadInt32();
                            reader.ReadInt32();
                            reader.ReadInt32();
                        }
                    }
                    //=========================================(13)sub_67B180
                    //怪物資訊
                    strCount = reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x28);
                            str.Decode();
                            var MonsterID = reader.ReadInt32();
                            var Direction = reader.ReadByte();
                            var Speed = BitConverter.ToSingle(reader.ReadBytes(4), 0);
                            var PosX = reader.ReadInt32();
                            var PosY = reader.ReadInt32();
                            int ss = reader.ReadInt32();
                            int ss2 = 0;
                            do
                            {
                                reader.ReadInt32();
                                reader.ReadInt32();
                                ++ss2;
                            } while (ss2 < ss);
                            //
                            char[] Value = MonsterID.ToString().ToCharArray();
                            char[] MonsterLevel = new char[4];
                            MonsterLevel[0] = Value[1];
                            MonsterLevel[1] = Value[2];
                            MonsterLevel[2] = Value[3];
                            MonsterLevel[3] = Value[4];
                            //
                            int Level = int.Parse(new string(MonsterLevel));
                            int MaxHP = MobFactory.MonsterMaxHP(Level);
                            int Exp = MobFactory.MonsterExp(Level);
                            byte MoveType = MobFactory.MoveType(MonsterID);
                            byte AttackType = MobFactory.AttackType(MonsterID);
                            int Attack1 = MobFactory.Attack1(MonsterID);
                            int Attack2 = MobFactory.Attack2(MonsterID);
                            int CrashAttack = MobFactory.CrashAttack(MonsterID);
                            int Defense = MobFactory.Defense(MonsterID);
                            byte AddEffect = MobFactory.AddEffect(MonsterID);
                            Monster Monster = new Monster(i, MonsterID, Level, MaxHP, MaxHP, 0, Exp, MoveType == 0 ? 0 : Speed, Direction, MoveType, AttackType, Attack1, Attack2, CrashAttack, Defense, MoveType == 0 ? (byte)0 : (byte)1, 0, AddEffect, PosX, PosY, true);
                            Map.Monster.Add(Monster);

                            // 修正怪物座標
                            sbyte NextPosition = Map.GetMapPexel(Monster.PositionX, Monster.PositionY);
                            while (NextPosition == -1)
                            {
                                Monster.PositionY = (Monster.PositionY / 32);
                                Monster.PositionY += 1;
                                Monster.PositionY *= 32;
                                sbyte Next = Map.GetMapPexel(Monster.PositionX, Monster.PositionY);
                                if (Next != -1)
                                    break;
                            }
                        }
                    }
                    for (int j = Map.Monster.Count; j < 50; j++)
                        Map.Monster.Add(null);
                    //=========================================(14)sub_653F60
                    strCount = reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x28);
                            str.Decode();
                            reader.ReadInt32();
                            reader.ReadByte();
                            reader.ReadInt32();
                            reader.ReadInt32();
                            reader.ReadInt32();
                        }
                    }
                    //=========================================(15)sub_654050
                    strCount = reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x28);
                            str.Decode();
                            reader.ReadInt32();
                            reader.ReadByte();
                            reader.ReadInt32();
                            reader.ReadInt32();
                            reader.ReadInt32();
                        }
                    }
                    //=========================================(16)sub_653E70
                    strCount = reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x28);
                            str.Decode();
                            reader.ReadInt32();
                            reader.ReadByte();
                            reader.ReadInt32();
                            reader.ReadInt32();
                            reader.ReadInt32();
                        }
                    }
                    //=========================================(17)sub_653E70
                    strCount = reader.ReadInt32();
                    reader.ReadInt32();
                    reader.ReadInt32();
                    if (strCount > 0)
                    {
                        for (int i = 0; i < strCount; i++)
                        {
                            str.FiersRead = reader.ReadBytes(0x28);
                            str.Decode();
                            reader.ReadInt32();
                            reader.ReadByte();
                            reader.ReadInt32();
                            reader.ReadInt32();
                            reader.ReadInt32();
                        }
                    }
                    //=========================================

                }
                catch (Exception)
                {
                }
            }
        }

        private class ReadString
        {
            public byte[] FiersRead = new byte[0x100];
            public byte[] SecondRead = new byte[0x100];
            public string Descrption;
            public string Name;

            public void Decode()
            {
                int index = 0;
                index = 0;
                while (index < 0x100)
                {
                    if (FiersRead[index + 2] == 0 && FiersRead[index] == 0 && FiersRead[index + 1] == 0)
                    {
                        index++;
                        break;
                    }
                    index++;
                }
                string str = Encoding.Unicode.GetString(FiersRead, 0, index);
                Name = str;
                str = "";
                index = 0;
                while (index < 0x100)
                {
                    if (SecondRead[index + 2] == 0 && SecondRead[index] == 0 && SecondRead[index + 1] == 0)
                    {
                        index++;
                        break;
                    }
                    index++;
                }
                str = Encoding.Unicode.GetString(SecondRead, 0, index);
                Descrption = str;
            }
        }
    }
}
