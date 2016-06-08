using Server.Ghost.Characters;
using System;
using System.Collections.Generic;

namespace Server.Ghost
{
    public class Map
    {
        public short MapX { get; set; }
        public short MapY { get; set; }
        public int MapHeight { get; set; }
        public int MapWidth { get; set; }
        public sbyte[][] MapPexels;
        public int DropOriginalID { get; set; }

        public List<Character> Characters { get; private set; }
        public List<Monster> Monster { get; set; }
        public Dictionary<int, Item> CharacterItem { get; set; }
        public List<Item> MonsterDrop { get; set; }

        public Map(short MapX, short MapY)
        {
            this.MapX = MapX;
            this.MapY = MapY;
            Characters = new List<Character>();
            Monster = new List<Monster>();
            CharacterItem = new Dictionary<int, Item>();
            MonsterDrop = new List<Item>();
        }

        public void SetMapHeightWidth(int Height, int Width)
        {
            this.MapHeight = Height * 32;
            this.MapWidth = Width * 32;
            Array.Resize(ref MapPexels, Height);
            for (int i = 0; i < Height; ++i)
                Array.Resize(ref MapPexels[i], Width * 33);
        }

        public void SetMapPexel(int X, int Y, sbyte Value)
        {
            this.MapPexels[Y][X] = Value;
        }

        public sbyte GetMapPexel(int X, int Y)
        {
            Y = Y / 32;
            X = X + (X / 32) + 1;
            return this.MapPexels[Y][X];
        }

        public int GetMapWidth()
        {
            return this.MapWidth;
        }

        public sbyte GetPexInfo(int X, int Y)
        {
            Y = Y / 32;
            X = 32 * (X / 32) + (X / 32);
            return this.MapPexels[Y][X];
        }

        public int GetMapCharactersTotal()
        {
            return Characters.Count;
        }

        public Monster getMonsterByOriginalID(int OriginalID)
        {
            foreach (Monster Monster in Monster)
            {
                if (Monster.OriginalID == OriginalID)
                    return Monster;
            }
            return null;
        }

        public Item getDropByOriginalID(int OriginalID)
        {
            return this.CharacterItem[OriginalID];
        }
    }
}
