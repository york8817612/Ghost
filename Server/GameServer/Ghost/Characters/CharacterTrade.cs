using System.Collections.Generic;

namespace Server.Ghost.Characters
{
    public class CharacterTrade
    {
        public int Money = 0;
        public List<Item> Item = new List<Item>();
        public List<short> SourceQuantity = new List<short>();
        public List<short> TargetQuantity = new List<short>();
    }
}
