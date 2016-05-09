namespace Server.Common.Constants
{
    public static class InventoryType
    {
        public enum EquipType : byte
        {
            Weapon = 0,  // 武器[Weapon]
            Outfit = 1,  // 衣服[Outfit]
            Ring = 2,    // 戒指[Ring]
            Necklace = 3,// 項鍊[Necklace]
            Mantle = 4,  // 披風[Mantle]
            Seal = 5,    // 封印物[Seal]
            Hat = 6,     // 頭部[Hat]
            Hair = 7,    // 頭髮[Hair]
            Eyes = 8,    // 眼睛[Eyes]
            Face = 9,    // 臉上[Face]
            Pet = 10,    // 靈物[Pet]
            Dress = 11,  // 服裝[Dress]
            Face2 = 12,  // 臉下[Face2]
            Earing = 13, // 耳環[Earing]
            HairAcc = 14,// [HairAcc]
            Toy = 15,    // 玩物[Toy]
        }

        public enum ItemType : byte
        {
            Undefined = 0xFF,
            Equip = 0,
            Equip1 = 1,     // [1]
            Equip2 = 2,     // [2]
            Spend3 = 3,     // [3]
            Other4 = 4,     // [4]
            Pet5 = 5        // [5]
        }
    }
}
