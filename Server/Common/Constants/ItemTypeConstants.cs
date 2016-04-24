namespace Server.Common.Constants
{
    public class ItemTypeConstants
    {
        public enum EquipType : byte
        {
            Weapon = 0xFF,  // 武器[Weapon]
            Mantle = 0xFE,  // 披風[Mantle]
            Hat = 0xFD,     // 帽子[Hat]
            Face2 = 0xFC,   // 臉下[Face2]
            Face = 0xFB,    // 臉上[Face]
            Outfit = 0xFA,  // [Outfit]
            Dress = 0xF9,   // [Dress]
            Ring = 0xF8,    // 戒指[Ring]
            Necklace = 0xF7,// 項鍊[Necklace]
            Seal = 0xF6     // 封印物[Seal]
        }

        public enum ItemType : byte
        {
            Equip1 = 1,     // [1]
            Equip2 = 2,     // [2]
            Use = 3,        // [3]
            Etc = 4,        // [4]
            Pet = 5         // [5]
        }
    }
}
