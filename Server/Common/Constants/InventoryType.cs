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

        public static byte getItemType(int itemid)
        {
            byte type = 0;

            switch (itemid / 100000)
            {
                case 75: // 耳環
                case 79: // 武器
                case 80: // 武器
                case 81: // 衣服
                case 84: // 披風
                case 86: // 帽子
                case 87: // 面具
                case 93: // 武器
                case 94: // 鬍子
                case 95: // 服裝
                    type = 1;
                    break;
                case 82: // 戒指
                case 83: // 項鍊
                case 85: // 封印箱
                    type = 2;
                    break;
                case 11: // 拼圖
                case 88: // 消耗
                    type = 3;
                    break;
                case 89: // 其他
                    type = 4;
                    break;
            }

            return type;
        }

        public static int getMoneyStyle(int money)
        {
            if (money > 0 && money <= 51)
            {
                return 9800001; // 銅錢
            }
            else if (money > 51 && money <= 500)
            {
                return 9800002; // 銀錢
            }
            else if (money > 500 && money <= 1000)
            {
                return 9800003; // 金錢
            }
            else if (money > 1000 && money <= 5000)
            {
                return 9800004; // 銀元寶
            }
            return 9800005; // 金元寶
        }
    }
}
