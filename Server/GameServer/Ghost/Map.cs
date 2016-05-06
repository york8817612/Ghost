using System.Collections.Generic;

namespace Server.Ghost
{
    public class Map
    {
        public List<Monster> Monster { get; set; }

        public Monster getMonsterByOriginalID(int OriginalID)
        {
            foreach (Monster Monster in Monster)
            {
                if (Monster.OriginalID == OriginalID)
                    return Monster;
            }
            return null;
        }
    }
}
