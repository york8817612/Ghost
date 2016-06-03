using Server.Common;
using Server.Ghost.Characters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Server.Ghost.Provider
{
    public class MapFactory
    {
        private static List<Map> maps { get; set; }
        public static List<Character> AllCharacters = new List<Character>();

        public static void Initialize()
        {
            maps = new List<Map>();
            maps.Add(new Map(0, 0));
            maps.Add(new Map(0, 1));
            maps.Add(new Map(0, 2));
            maps.Add(new Map(100, 1));
            maps.Add(new Map(100, 10));
            maps.Add(new Map(100, 100));
            maps.Add(new Map(100, 101));
            //maps.Add(new Map(100, 11));
            //maps.Add(new Map(100, 12));
            //maps.Add(new Map(100, 13));
            //maps.Add(new Map(100, 14));
            //maps.Add(new Map(100, 15));
            //maps.Add(new Map(100, 16));
            //maps.Add(new Map(100, 17));
            //maps.Add(new Map(100, 18));
            //maps.Add(new Map(100, 19));
            maps.Add(new Map(100, 2));
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
            maps.Add(new Map(100, 3));
            maps.Add(new Map(100, 4));
            maps.Add(new Map(100, 40));
            maps.Add(new Map(100, 41));
            //maps.Add(new Map(100, 5));
            maps.Add(new Map(1011, 1));
            maps.Add(new Map(1011, 2));
            //maps.Add(new Map(1012, 1));
            //maps.Add(new Map(1012, 2));
            //maps.Add(new Map(1013, 1));
            //maps.Add(new Map(1013, 2));
            //maps.Add(new Map(1014, 1));
            //maps.Add(new Map(1014, 2));
            //maps.Add(new Map(1015, 1));
            //maps.Add(new Map(1015, 2));
            maps.Add(new Map(1041, 1));
            maps.Add(new Map(1041, 2));
            //maps.Add(new Map(1042, 1));
            //maps.Add(new Map(1042, 2));
            //maps.Add(new Map(1043, 1));
            //maps.Add(new Map(1043, 2));
            //maps.Add(new Map(1044, 1));
            //maps.Add(new Map(1044, 2));
            //maps.Add(new Map(1045, 1));
            //maps.Add(new Map(1045, 2));
            maps.Add(new Map(10, 1));
            maps.Add(new Map(10, 2));
            maps.Add(new Map(10, 21));
            maps.Add(new Map(10, 22));
            maps.Add(new Map(10, 23));
            maps.Add(new Map(10, 3));
            maps.Add(new Map(10, 31));
            maps.Add(new Map(10, 32));
            maps.Add(new Map(10, 33));
            maps.Add(new Map(10, 34));
            maps.Add(new Map(10, 35));
            maps.Add(new Map(10, 36));
            maps.Add(new Map(10, 37));
            maps.Add(new Map(10, 38));
            maps.Add(new Map(10, 4));
            maps.Add(new Map(10, 5));
            maps.Add(new Map(10, 60));
            //maps.Add(new Map(10, 61));
            //maps.Add(new Map(10, 62));
            //maps.Add(new Map(10, 63));
            //maps.Add(new Map(10, 64));
            maps.Add(new Map(11, 1));
            maps.Add(new Map(11, 2));
            maps.Add(new Map(11, 21));
            maps.Add(new Map(11, 3));
            //maps.Add(new Map(11, 31));
            //maps.Add(new Map(11, 32));
            //maps.Add(new Map(11, 33));
            //maps.Add(new Map(11, 34));
            //maps.Add(new Map(11, 35));
            //maps.Add(new Map(11, 36));
            //maps.Add(new Map(11, 37));
            //maps.Add(new Map(11, 38));
            //maps.Add(new Map(11, 39));
            maps.Add(new Map(11, 4));
            //maps.Add(new Map(11, 41));
            //maps.Add(new Map(11, 42));
            //maps.Add(new Map(11, 43));
            //maps.Add(new Map(11, 44));
            //maps.Add(new Map(11, 45));
            //maps.Add(new Map(11, 46));
            //maps.Add(new Map(11, 47));
            //maps.Add(new Map(11, 48));
            //maps.Add(new Map(11, 49));
            maps.Add(new Map(11, 5));
            maps.Add(new Map(11, 6));
            maps.Add(new Map(11, 7));
            maps.Add(new Map(12, 1));
            maps.Add(new Map(12, 2));
            maps.Add(new Map(13, 1));
            maps.Add(new Map(13, 2));
            maps.Add(new Map(13, 21));
            maps.Add(new Map(13, 22));
            maps.Add(new Map(13, 29));
            maps.Add(new Map(13, 3));
            maps.Add(new Map(13, 4));
            maps.Add(new Map(13, 5));
            maps.Add(new Map(13, 6));
            maps.Add(new Map(13, 7));
            maps.Add(new Map(14, 0));
            maps.Add(new Map(14, 1));
            maps.Add(new Map(14, 2));
            maps.Add(new Map(14, 21));
            maps.Add(new Map(14, 22));
            maps.Add(new Map(14, 3));
            maps.Add(new Map(14, 4));
            maps.Add(new Map(14, 5));
            maps.Add(new Map(14, 6));
            maps.Add(new Map(14, 7));
            maps.Add(new Map(14, 8));
            maps.Add(new Map(15, 1));
            maps.Add(new Map(15, 2));
            maps.Add(new Map(15, 21));
            maps.Add(new Map(15, 22));
            maps.Add(new Map(15, 23));
            maps.Add(new Map(15, 3));
            maps.Add(new Map(15, 4));
            maps.Add(new Map(15, 5));
            maps.Add(new Map(15, 6));
            maps.Add(new Map(16, 1));
            maps.Add(new Map(16, 40));
            maps.Add(new Map(17, 1));
            maps.Add(new Map(17, 2));
            maps.Add(new Map(17, 21));
            maps.Add(new Map(17, 22));
            maps.Add(new Map(17, 3));
            maps.Add(new Map(17, 4));
            maps.Add(new Map(17, 5));
            maps.Add(new Map(17, 6));
            maps.Add(new Map(17, 7));
            maps.Add(new Map(18, 1));
            maps.Add(new Map(18, 10));
            maps.Add(new Map(18, 11));
            maps.Add(new Map(18, 12));
            maps.Add(new Map(18, 13));
            maps.Add(new Map(18, 2));
            maps.Add(new Map(18, 21));
            maps.Add(new Map(18, 22));
            maps.Add(new Map(18, 23));
            maps.Add(new Map(18, 3));
            maps.Add(new Map(18, 4));
            maps.Add(new Map(18, 5));
            maps.Add(new Map(18, 6));
            maps.Add(new Map(18, 7));
            maps.Add(new Map(19, 1));
            maps.Add(new Map(19, 2));
            maps.Add(new Map(19, 21));
            maps.Add(new Map(19, 22));
            maps.Add(new Map(19, 23));
            maps.Add(new Map(19, 24));
            maps.Add(new Map(19, 3));
            maps.Add(new Map(19, 4));
            maps.Add(new Map(19, 5));
            maps.Add(new Map(19, 6));
            maps.Add(new Map(19, 7));
            maps.Add(new Map(1, 1));
            maps.Add(new Map(1, 12));
            maps.Add(new Map(1, 2));
            maps.Add(new Map(1, 3));
            maps.Add(new Map(1, 4));
            maps.Add(new Map(1, 41));
            maps.Add(new Map(1, 42));
            maps.Add(new Map(1, 43));
            maps.Add(new Map(1, 50));
            maps.Add(new Map(1, 51));
            maps.Add(new Map(1, 52));
            //maps.Add(new Map(1, 53));
            //maps.Add(new Map(1, 54));
            //maps.Add(new Map(1, 55));
            maps.Add(new Map(1, 60));
            maps.Add(new Map(1, 61));
            maps.Add(new Map(1, 62));
            maps.Add(new Map(1, 63));
            maps.Add(new Map(1, 90));
            maps.Add(new Map(20, 0));
            maps.Add(new Map(20, 1));
            maps.Add(new Map(20, 10));
            maps.Add(new Map(20, 11));
            maps.Add(new Map(20, 12));
            maps.Add(new Map(20, 13));
            maps.Add(new Map(20, 14));
            maps.Add(new Map(20, 15));
            maps.Add(new Map(20, 16));
            maps.Add(new Map(20, 17));
            maps.Add(new Map(20, 2));
            maps.Add(new Map(20, 21));
            maps.Add(new Map(20, 22));
            maps.Add(new Map(20, 3));
            maps.Add(new Map(20, 4));
            maps.Add(new Map(20, 5));
            maps.Add(new Map(20, 6));
            maps.Add(new Map(20, 7));
            maps.Add(new Map(20, 70));
            maps.Add(new Map(20, 71));
            maps.Add(new Map(20, 72));
            maps.Add(new Map(20, 8));
            maps.Add(new Map(20, 9));
            //maps.Add(new Map(21, 0));
            maps.Add(new Map(21, 1));
            maps.Add(new Map(21, 10));
            maps.Add(new Map(21, 11));
            maps.Add(new Map(21, 12));
            maps.Add(new Map(21, 13));
            maps.Add(new Map(21, 14));
            maps.Add(new Map(21, 15));
            maps.Add(new Map(21, 16));
            maps.Add(new Map(21, 17));
            maps.Add(new Map(21, 18));
            maps.Add(new Map(21, 2));
            maps.Add(new Map(21, 21));
            maps.Add(new Map(21, 22));
            maps.Add(new Map(21, 3));
            maps.Add(new Map(21, 4));
            maps.Add(new Map(21, 5));
            maps.Add(new Map(21, 6));
            maps.Add(new Map(21, 7));
            maps.Add(new Map(21, 71));
            maps.Add(new Map(21, 72));
            maps.Add(new Map(21, 8));
            maps.Add(new Map(21, 9));
            maps.Add(new Map(22, 1));
            maps.Add(new Map(22, 10));
            maps.Add(new Map(22, 11));
            maps.Add(new Map(22, 12));
            maps.Add(new Map(22, 13));
            maps.Add(new Map(22, 14));
            maps.Add(new Map(22, 15));
            maps.Add(new Map(22, 16));
            maps.Add(new Map(22, 17));
            maps.Add(new Map(22, 18));
            maps.Add(new Map(22, 19));
            maps.Add(new Map(22, 2));
            maps.Add(new Map(22, 20));
            maps.Add(new Map(22, 21));
            maps.Add(new Map(22, 3));
            maps.Add(new Map(22, 4));
            maps.Add(new Map(22, 5));
            maps.Add(new Map(22, 6));
            maps.Add(new Map(22, 7));
            maps.Add(new Map(22, 8));
            maps.Add(new Map(22, 9));
            maps.Add(new Map(23, 1));
            maps.Add(new Map(23, 10));
            maps.Add(new Map(23, 11));
            maps.Add(new Map(23, 12));
            maps.Add(new Map(23, 13));
            maps.Add(new Map(23, 14));
            maps.Add(new Map(23, 15));
            maps.Add(new Map(23, 16));
            maps.Add(new Map(23, 17));
            maps.Add(new Map(23, 18));
            maps.Add(new Map(23, 2));
            maps.Add(new Map(23, 3));
            maps.Add(new Map(23, 4));
            maps.Add(new Map(23, 5));
            maps.Add(new Map(23, 6));
            maps.Add(new Map(23, 7));
            maps.Add(new Map(23, 8));
            maps.Add(new Map(23, 9));
            maps.Add(new Map(24, 1));
            maps.Add(new Map(24, 2));
            maps.Add(new Map(24, 21));
            maps.Add(new Map(24, 22));
            maps.Add(new Map(24, 23));
            maps.Add(new Map(24, 24));
            maps.Add(new Map(24, 25));
            maps.Add(new Map(24, 26));
            maps.Add(new Map(24, 3));
            maps.Add(new Map(24, 4));
            maps.Add(new Map(25, 1));
            maps.Add(new Map(25, 2));
            maps.Add(new Map(26, 0));
            maps.Add(new Map(26, 1));
            maps.Add(new Map(26, 10));
            maps.Add(new Map(26, 11));
            maps.Add(new Map(26, 12));
            maps.Add(new Map(26, 13));
            maps.Add(new Map(26, 14));
            maps.Add(new Map(26, 2));
            maps.Add(new Map(26, 21));
            maps.Add(new Map(26, 22));
            maps.Add(new Map(26, 23));
            maps.Add(new Map(26, 3));
            maps.Add(new Map(26, 4));
            maps.Add(new Map(26, 5));
            maps.Add(new Map(26, 6));
            maps.Add(new Map(26, 7));
            maps.Add(new Map(26, 8));
            maps.Add(new Map(26, 9));
            maps.Add(new Map(27, 0));
            maps.Add(new Map(27, 1));
            maps.Add(new Map(27, 2));
            maps.Add(new Map(28, 1));
            maps.Add(new Map(28, 10));
            maps.Add(new Map(28, 11));
            maps.Add(new Map(28, 12));
            maps.Add(new Map(28, 13));
            maps.Add(new Map(28, 14));
            maps.Add(new Map(28, 15));
            maps.Add(new Map(28, 16));
            maps.Add(new Map(28, 17));
            maps.Add(new Map(28, 18));
            maps.Add(new Map(28, 19));
            maps.Add(new Map(28, 2));
            maps.Add(new Map(28, 20));
            maps.Add(new Map(28, 3));
            maps.Add(new Map(28, 4));
            maps.Add(new Map(28, 5));
            maps.Add(new Map(28, 6));
            maps.Add(new Map(28, 7));
            maps.Add(new Map(28, 8));
            maps.Add(new Map(28, 9));
            maps.Add(new Map(2, 1));
            maps.Add(new Map(2, 2));
            maps.Add(new Map(2, 21));
            maps.Add(new Map(2, 22));
            maps.Add(new Map(2, 3));
            maps.Add(new Map(2, 4));
            maps.Add(new Map(2, 5));
            maps.Add(new Map(2, 6));
            maps.Add(new Map(2, 7));
            maps.Add(new Map(2, 8));
            maps.Add(new Map(2, 9));
            maps.Add(new Map(31, 1));
            maps.Add(new Map(31, 10));
            maps.Add(new Map(31, 2));
            maps.Add(new Map(31, 3));
            maps.Add(new Map(31, 4));
            maps.Add(new Map(31, 5));
            maps.Add(new Map(31, 6));
            maps.Add(new Map(31, 7));
            maps.Add(new Map(31, 8));
            maps.Add(new Map(31, 9));
            maps.Add(new Map(32, 1));
            maps.Add(new Map(32, 2));
            maps.Add(new Map(32, 3));
            maps.Add(new Map(32, 4));
            maps.Add(new Map(33, 1));
            maps.Add(new Map(33, 2));
            maps.Add(new Map(33, 21));
            maps.Add(new Map(33, 22));
            maps.Add(new Map(33, 23));
            maps.Add(new Map(33, 24));
            maps.Add(new Map(33, 3));
            maps.Add(new Map(33, 4));
            maps.Add(new Map(33, 5));
            maps.Add(new Map(33, 6));
            maps.Add(new Map(33, 7));
            maps.Add(new Map(35, 1));
            maps.Add(new Map(35, 2));
            maps.Add(new Map(35, 3));
            maps.Add(new Map(35, 4));
            maps.Add(new Map(3, 1));
            maps.Add(new Map(3, 2));
            maps.Add(new Map(3, 3));
            maps.Add(new Map(3, 4));
            maps.Add(new Map(3, 5));
            maps.Add(new Map(3, 6));
            maps.Add(new Map(3, 7));
            maps.Add(new Map(3, 70));
            maps.Add(new Map(3, 71));
            maps.Add(new Map(3, 72));
            maps.Add(new Map(3, 73));
            maps.Add(new Map(3, 74));
            maps.Add(new Map(3, 8));
            maps.Add(new Map(3, 9));
            maps.Add(new Map(3, 91));
            maps.Add(new Map(42, 1));
            maps.Add(new Map(42, 2));
            maps.Add(new Map(42, 22));
            maps.Add(new Map(42, 3));
            maps.Add(new Map(42, 4));
            maps.Add(new Map(42, 41));
            maps.Add(new Map(42, 50));
            maps.Add(new Map(42, 51));
            maps.Add(new Map(42, 52));
            maps.Add(new Map(42, 53));
            maps.Add(new Map(42, 54));
            maps.Add(new Map(43, 0));
            maps.Add(new Map(43, 1));
            maps.Add(new Map(43, 10));
            maps.Add(new Map(43, 11));
            maps.Add(new Map(43, 12));
            maps.Add(new Map(43, 2));
            maps.Add(new Map(43, 21));
            maps.Add(new Map(43, 22));
            maps.Add(new Map(43, 23));
            maps.Add(new Map(43, 3));
            maps.Add(new Map(43, 4));
            maps.Add(new Map(43, 5));
            maps.Add(new Map(43, 6));
            maps.Add(new Map(43, 7));
            maps.Add(new Map(43, 8));
            maps.Add(new Map(43, 9));
            maps.Add(new Map(44, 1));
            maps.Add(new Map(44, 10));
            maps.Add(new Map(44, 11));
            maps.Add(new Map(44, 12));
            maps.Add(new Map(44, 2));
            maps.Add(new Map(44, 21));
            maps.Add(new Map(44, 22));
            maps.Add(new Map(44, 23));
            maps.Add(new Map(44, 3));
            maps.Add(new Map(44, 4));
            maps.Add(new Map(44, 5));
            maps.Add(new Map(44, 6));
            maps.Add(new Map(44, 7));
            maps.Add(new Map(44, 8));
            maps.Add(new Map(44, 9));
            maps.Add(new Map(45, 0));
            maps.Add(new Map(45, 1));
            maps.Add(new Map(45, 10));
            maps.Add(new Map(45, 11));
            maps.Add(new Map(45, 2));
            maps.Add(new Map(45, 3));
            maps.Add(new Map(45, 4));
            maps.Add(new Map(45, 5));
            maps.Add(new Map(45, 6));
            maps.Add(new Map(45, 7));
            maps.Add(new Map(45, 8));
            maps.Add(new Map(45, 9));
            maps.Add(new Map(46, 1));
            maps.Add(new Map(46, 2));
            maps.Add(new Map(47, 0));
            maps.Add(new Map(47, 1));
            maps.Add(new Map(47, 10));
            maps.Add(new Map(47, 11));
            maps.Add(new Map(47, 12));
            maps.Add(new Map(47, 2));
            maps.Add(new Map(47, 21));
            maps.Add(new Map(47, 22));
            maps.Add(new Map(47, 3));
            maps.Add(new Map(47, 4));
            maps.Add(new Map(47, 5));
            maps.Add(new Map(47, 6));
            maps.Add(new Map(47, 7));
            maps.Add(new Map(47, 8));
            maps.Add(new Map(47, 9));
            maps.Add(new Map(4, 1));
            maps.Add(new Map(4, 2));
            maps.Add(new Map(4, 21));
            maps.Add(new Map(4, 22));
            maps.Add(new Map(4, 23));
            maps.Add(new Map(4, 3));
            maps.Add(new Map(4, 4));
            maps.Add(new Map(4, 5));
            maps.Add(new Map(4, 6));
            maps.Add(new Map(4, 7));
            maps.Add(new Map(5, 1));
            maps.Add(new Map(5, 2));
            maps.Add(new Map(5, 21));
            maps.Add(new Map(5, 22));
            maps.Add(new Map(5, 3));
            maps.Add(new Map(5, 4));
            maps.Add(new Map(5, 5));
            maps.Add(new Map(5, 6));
            maps.Add(new Map(5, 7));
            maps.Add(new Map(66, 6));
            maps.Add(new Map(6, 1));
            maps.Add(new Map(6, 2));
            maps.Add(new Map(6, 21));
            maps.Add(new Map(6, 22));
            maps.Add(new Map(6, 23));
            maps.Add(new Map(6, 3));
            maps.Add(new Map(6, 4));
            maps.Add(new Map(6, 5));
            maps.Add(new Map(6, 6));
            maps.Add(new Map(6, 7));
            maps.Add(new Map(77, 1));
            maps.Add(new Map(7, 1));
            maps.Add(new Map(7, 2));
            maps.Add(new Map(7, 29));
            maps.Add(new Map(7, 3));
            maps.Add(new Map(7, 4));
            maps.Add(new Map(7, 5));
            maps.Add(new Map(8, 1));
            maps.Add(new Map(8, 2));
            maps.Add(new Map(8, 21));
            maps.Add(new Map(8, 22));
            maps.Add(new Map(8, 23));
            maps.Add(new Map(8, 3));
            maps.Add(new Map(8, 4));
            maps.Add(new Map(8, 5));
            maps.Add(new Map(8, 6));
            maps.Add(new Map(8, 7));
            maps.Add(new Map(9, 1));
            maps.Add(new Map(9, 10));
            maps.Add(new Map(9, 11));
            maps.Add(new Map(9, 2));
            maps.Add(new Map(9, 3));
            maps.Add(new Map(9, 4));
            maps.Add(new Map(9, 5));
            maps.Add(new Map(9, 6));
            maps.Add(new Map(9, 7));
            maps.Add(new Map(9, 8));
            maps.Add(new Map(9, 9));
            foreach (Map map in maps)
            {
                LoadMapPexelsData(map);
                ParsePrjFile(map);
            }
        }

        public static Map GetMap(short mapX, short mapY)
        {
            Map map = maps.Find(i => (i.MapX == mapX && i.MapY == mapY));
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

        public static void ParsePrjFile(Map map)
        {
            string FileName = Application.LaunchPath + @"\Data\Project\t" + map.MapX + "_s" + map.MapY + ".prj";
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

                            char[] Value = MonsterID.ToString().ToCharArray();
                            char[] Level = new char[4];
                            Level[0] = Value[1];
                            Level[1] = Value[2];
                            Level[2] = Value[3];
                            Level[3] = Value[4];
                            int MonsterLevel = int.Parse(new string(Level));
                            int MonsterHP = getMonsterHP(MonsterLevel);
                            int MonsterExp = getMonsterExp(MonsterLevel);
                            map.Monster.Add(new Monster(i, MonsterID, MonsterLevel, MonsterHP, 0, MonsterExp, Speed, Direction, 1, 0, PosX, PosY));
                        }
                    }
                    for (int j = map.Monster.Count; j < 50; j++)
                        map.Monster.Add(null);
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

        public static int getMonsterHP(int MonsterLevel)
        {
            int MonsterHP = int.MaxValue;
            switch (MonsterLevel)
            {
                case 1: // 賴打
                    MonsterHP = 50;
                    break;
                case 2: // 大目仔
                    MonsterHP = 60;
                    break;
                case 3: // 美人魚
                    MonsterHP = 100;
                    break;
                case 5: // 蘆花
                    MonsterHP = 160;
                    break;
                case 6:
                    MonsterHP = 190;
                    break;
                case 7:
                    MonsterHP = 220;
                    break;
                case 8:
                    MonsterHP = 250;
                    break;
                case 10: // 毛毛(Boss)
                    MonsterHP = 700;
                    break;
                case 12:
                    MonsterHP = 590;
                    break;
                case 14:
                    MonsterHP = 690;
                    break;
                case 16:
                    MonsterHP = 780;
                    break;
                case 18:
                    MonsterHP = 880;
                    break;
                case 20: // 銅鈴眼(Boss)
                    MonsterHP = 2900;
                    break;
                case 21:
                    MonsterHP = 2400;
                    break;
                case 22:
                    MonsterHP = 2600;
                    break;
                case 24:
                    MonsterHP = 2800;
                    break;
                case 26:
                    MonsterHP = 3300;
                    break;
                case 28:
                    MonsterHP = 3600;
                    break;
                case 30: // 豬大長(Boss)
                    MonsterHP = 29200;
                    break;
                case 32:
                    MonsterHP = 4700;
                    break;
                case 34:
                    MonsterHP = 5100;
                    break;
                case 35:
                    MonsterHP = 5300;
                    break;
                case 36:
                    MonsterHP = 5600;
                    break;
                case 37:
                    MonsterHP = 5800;
                    break;
                case 38:
                    MonsterHP = 6200;
                    break;
                case 39:
                    MonsterHP = 6400;
                    break;
                case 40: // 狗骨頭(Boss)
                    MonsterHP = 51000;
                    break;
                case 42:
                    MonsterHP = 10800;
                    break;
                case 43:
                    MonsterHP = 11250;
                    break;
                case 44:
                    MonsterHP = 11500;
                    break;
                case 45:
                    MonsterHP = 12450;
                    break;
                case 46:
                    MonsterHP = 12600;
                    break;
                case 48:
                    MonsterHP = 13500;
                    break;
                case 49:
                    MonsterHP = 13800;
                    break;
                case 50: // 雞冠嗆(Boss)
                    MonsterHP = 87100;
                    break;
                case 51:
                    MonsterHP = 15700;
                    break;
                case 52:
                    MonsterHP = 16500;
                    break;
                case 54:
                    MonsterHP = 18100;
                    break;
                case 55:
                    MonsterHP = 18900;
                    break;
                case 56:
                    MonsterHP = 19700;
                    break;
                case 57:
                    MonsterHP = 20500;
                    break;
                case 59:
                    MonsterHP = 22100;
                    break;
                case 60: // 猴塞雷(Boss)
                    MonsterHP = 127140;
                    break;
                case 70: // 羊桃之(Boss)
                    MonsterHP = 189000;
                    break;
            }
            return MonsterHP;
        }

        public static int getMonsterExp(int MonsterLevel)
        {
            int MonsterExp = 0;
            switch (MonsterLevel)
            {
                case 1: // 賴打
                    MonsterExp = 3;
                    break;
                case 2: // 大目仔
                    MonsterExp = 6;
                    break;
                case 3: // 美人魚
                    MonsterExp = 8;
                    break;
                case 5: // 蘆花
                    MonsterExp = 14;
                    break;
                case 6:
                    MonsterExp = 17;
                    break;
                case 7:
                    MonsterExp = 20;
                    break;
                case 8:
                    MonsterExp = 22;
                    break;
                case 10: // 毛毛(Boss)
                    MonsterExp = 42;
                    break;
                case 12:
                    MonsterExp = 36;
                    break;
                case 14:
                    MonsterExp = 42;
                    break;
                case 16:
                    MonsterExp = 48;
                    break;
                case 18:
                    MonsterExp = 54;
                    break;
                case 20: // 銅鈴眼(Boss)
                    MonsterExp = 90;
                    break;
                case 21:
                    MonsterExp = 145;
                    break;
                case 22:
                    MonsterExp = 153;
                    break;
                case 24:
                    MonsterExp = 169;
                    break;
                case 26:
                    MonsterExp = 185;
                    break;
                case 28:
                    MonsterExp = 201;
                    break;
                case 30: // 豬大長(Boss)
                    MonsterExp = 217;
                    break;
                case 32:
                    MonsterExp = 233;
                    break;
                case 34:
                    MonsterExp = 249;
                    break;
                case 35:
                    MonsterExp = 257;
                    break;
                case 36:
                    MonsterExp = 265;
                    break;
                case 37:
                    MonsterExp = 273;
                    break;
                case 38:
                    MonsterExp = 281;
                    break;
                case 39:
                    MonsterExp = 289;
                    break;
                case 40: // 狗骨頭(Boss)
                    MonsterExp = 297;
                    break;
                case 42:
                    MonsterExp = 321;
                    break;
                case 43:
                    MonsterExp = 321;
                    break;
                case 44:
                    MonsterExp = 329;
                    break;
                case 45:
                    MonsterExp = 325;
                    break;
                case 46:
                    MonsterExp = 330;
                    break;
                case 48:
                    MonsterExp = 342;
                    break;
                case 49:
                    MonsterExp = 350;
                    break;
                case 50: // 雞冠嗆(Boss)
                    MonsterExp = 5124;
                    break;
                case 51:
                    MonsterExp = 359;
                    break;
                case 52:
                    MonsterExp = 365;
                    break;
                case 54:
                    MonsterExp = 377;
                    break;
                case 55:
                    MonsterExp = 383;
                    break;
                case 56:
                    MonsterExp = 389;
                    break;
                case 57:
                    MonsterExp = 395;
                    break;
                case 59:
                    MonsterExp = 407;
                    break;
                case 60: // 猴塞雷(Boss)
                    break;
                case 70: // 羊桃之(Boss)
                    break;
            }
            return MonsterExp;
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
