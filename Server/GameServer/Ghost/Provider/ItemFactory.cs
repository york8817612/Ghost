using Server.Common;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Server.Ghost.Provider
{
    public static class ItemFactory
    {
        private static string openPath = Application.LaunchPath + @"\table\item.itm";

        //武器資料
        //物品編號(int), 物品名稱(string), 職業(byte), 功力(byte), 類型(short), 攻擊距離(short), 攻擊速度(byte), 購買價格(int)
        public static Dictionary<int, ItemData> weaponData = new Dictionary<int, ItemData>();
        //衣服資料
        //物品編號(int), 物品名稱(string), 職業(byte), 功力(byte), 購買價格(int)
        public static Dictionary<int, ItemData> topData = new Dictionary<int, ItemData>();
        //服裝資料
        //物品編號(int), 物品名稱(string), 職業(byte), 功力(byte), 購買價格(int)
        public static Dictionary<int, ItemData> clothingData = new Dictionary<int, ItemData>();
        //戒指資料
        //物品編號(int), 物品名稱(string), 職業(byte), 功力(byte), 購買價格(int)
        public static Dictionary<int, ItemData> ringData = new Dictionary<int, ItemData>();
        //項鍊資料
        //物品編號(int), 物品名稱(string), 職業(byte), 功力(byte), 購買價格(int)
        public static Dictionary<int, ItemData> necklaceData = new Dictionary<int, ItemData>();
        //披風資料
        //物品編號(int), 物品名稱(string), 職業(byte), 功力(byte), 購買價格(int)
        public static Dictionary<int, ItemData> capeData = new Dictionary<int, ItemData>();
        //消耗品資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, ItemData> useData = new Dictionary<int, ItemData>();
        //封印箱資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, ItemData> soulData = new Dictionary<int, ItemData>();
        //帽子資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, ItemData> hatData = new Dictionary<int, ItemData>();
        //髮型資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, ItemData> hairData = new Dictionary<int, ItemData>();
        //眼睛資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, ItemData> eyesData = new Dictionary<int, ItemData>();
        //面具資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, ItemData> maskData = new Dictionary<int, ItemData>();
        //鬍子資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, ItemData> beardData = new Dictionary<int, ItemData>();
        //其他資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, ItemData> etcData = new Dictionary<int, ItemData>();
        //寵物資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, ItemData> petData = new Dictionary<int, ItemData>();
        //領巾資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, ItemData> scarfData = new Dictionary<int, ItemData>();
        //未知資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, ItemData> unknownData = new Dictionary<int, ItemData>();
        //拼圖資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, ItemData> jigsawData = new Dictionary<int, ItemData>();
        //耳環資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, ItemData> earringData = new Dictionary<int, ItemData>();

        public static List<Dictionary<int, ItemData>> all = new List<Dictionary<int, ItemData>>();

        public static void Initialize()
        {
            FileStream itemFile = File.Open(openPath, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader item = new BinaryReader(itemFile, Encoding.GetEncoding("UTF-16LE"));
            //==============================================================================
            item.ReadBytes(120); // 未知
            //==============================================================================
            // 武器類型開始
            int weaponCount = item.ReadInt32(); // 武器數量
            for (int i = 0; i < weaponCount; i++)
            {
                int itemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                item.ReadByte();
                byte job = item.ReadByte(); // 職業
                byte level = item.ReadByte(); // 功力
                short attack = item.ReadInt16(); // 類型
                short MagicAttack = item.ReadInt16();
                short attackRange = item.ReadInt16(); // 攻擊距離
                item.ReadInt16();
                byte Speed = item.ReadByte(); // 攻擊速度
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                int price = item.ReadInt32(); // 購買價格
                byte Fusion = item.ReadByte();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadBytes(16);
                item.ReadBytes(20);

                weaponData.Add(itemId, new ItemData(itemId, itemNameString, job, level, attack, MagicAttack, attackRange, Speed, price, Fusion));
            }
            all.Add(weaponData);
            //==============================================================================
            // 衣服類型開始
            int topCount = item.ReadInt32(); // 衣服數量
            for (int i = 0; i < topCount; i++)
            {
                int itemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                item.ReadByte();
                byte job = item.ReadByte();
                byte level = item.ReadByte();
                short defense = item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                int price = item.ReadInt32(); // 購買價格
                byte fusion = item.ReadByte();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadBytes(16);
                item.ReadBytes(20);

                topData.Add(itemId, new ItemData(itemId, itemNameString, job, level, defense, price, fusion));
            }
            all.Add(topData);
            //==============================================================================
            // 服裝類型開始
            int clothingCount = item.ReadInt32(); // 服裝數量
            for (int i = 0; i < clothingCount; i++)
            {
                int itemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                byte Gender = item.ReadByte();
                byte job = item.ReadByte();
                byte level = item.ReadByte();
                short defense = item.ReadInt16();
                short Str = item.ReadInt16();
                short Dex = item.ReadInt16();
                short Vit = item.ReadInt16();
                short Int = item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                int price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                byte Fusion = item.ReadByte();
                item.ReadBytes(3);
                item.ReadBytes(12);
                clothingData.Add(itemId, new ItemData(itemId, itemNameString, job, level, defense, Str, Dex, Vit, Int, price, Fusion));
            }
            all.Add(clothingData);
            //==============================================================================
            // 戒指類型開始
            int ringCount = item.ReadInt32(); // 戒指數量
            for (int i = 0; i < ringCount; i++)
            {
                int ItemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                byte Job = item.ReadByte();
                byte Level = item.ReadByte();
                short Str = item.ReadInt16();
                short Dex = item.ReadInt16();
                short Vit = item.ReadInt16();
                short Int = item.ReadInt16();
                short Magic = item.ReadInt16();
                short Avoid = item.ReadInt16();
                short Attack = item.ReadInt16();
                short Defense = item.ReadInt16();
                short Hp = item.ReadInt16();
                short Mp = item.ReadInt16();
                int Price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                byte Refining = item.ReadByte();
                item.ReadBytes(10);
                item.ReadBytes(5);
                byte[] itemDescriptionByteArray = item.ReadBytes(256); // 物品敘述 (Byte[])
                string itemDescriptionString = Encoding.GetEncoding("UTF-16LE").GetString(itemDescriptionByteArray); // 物品敘述 (Byte[] => String)

                ringData.Add(ItemId, new ItemData(ItemId, itemNameString, Job, Level, Str, Dex, Vit, Int, Magic, Avoid, Attack, Defense, Hp, Mp, Refining, Price));
            }
            all.Add(ringData);
            //==============================================================================
            // 項鍊類型開始
            int necklaceCount = item.ReadInt32(); // 項鍊數量
            for (int i = 0; i < necklaceCount; i++)
            {
                int ItemId = item.ReadInt32(); // 物品編號
                byte[] ItemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string ItemNameString = Encoding.GetEncoding("UTF-16LE").GetString(ItemNameByteArray); // 物品名稱 (Byte[] => String)
                byte Job = item.ReadByte();
                byte Level = item.ReadByte();
                short Defense = item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                short Hp = item.ReadInt16();
                short Mp = item.ReadInt16();
                int Price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadByte();
                item.ReadBytes(10);
                item.ReadBytes(5);
                byte[] itemDescriptionByteArray = item.ReadBytes(256); // 物品敘述 (Byte[])
                string itemDescriptionString = Encoding.GetEncoding("UTF-16LE").GetString(itemDescriptionByteArray); // 物品敘述 (Byte[] => String)

                necklaceData.Add(ItemId, new ItemData(ItemId, ItemNameString, Job, Level, Defense, Hp, Mp, Price));
            }
            all.Add(necklaceData);
            //==============================================================================
            // 披風類型開始
            int capeCount = item.ReadInt32(); // 披風數量
            for (int i = 0; i < capeCount; i++)
            {
                int itemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                byte job = item.ReadByte();
                byte level = item.ReadByte();
                short Str = item.ReadInt16();
                short Dex = item.ReadInt16();
                short Vit = item.ReadInt16();
                short Int = item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                int price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadByte();
                item.ReadBytes(3);
                item.ReadBytes(12);

                capeData.Add(itemId, new ItemData(itemId, itemNameString, job, level, Str, Dex, Vit, Int, price));
            }
            all.Add(capeData);
            //==============================================================================
            // 消耗類型開始
            int useCount = item.ReadInt32(); // 消耗道具數量
            for (int i = 0; i < useCount; i++)
            {
                int itemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                item.ReadByte();
                // Type 0 : 恢復鬼力
                // Type 1 : 恢復體力(%)
                // Type 2 : 恢復體力
                // Type 3 : 恢復體力(%)
                // Type 4 : 解除異常
                int Type = item.ReadInt32();
                int Recover = item.ReadInt32();
                item.ReadInt32();
                int price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadBytes(16);
                item.ReadByte();
                byte[] itemDescriptionByteArray = item.ReadBytes(256); // 物品敘述 (Byte[])
                string itemDescriptionString = Encoding.GetEncoding("UTF-16LE").GetString(itemDescriptionByteArray); // 物品敘述 (Byte[] => String)

                useData.Add(itemId, new ItemData(itemId, itemNameString, Type, Recover, price));
            }
            all.Add(useData);
            //==============================================================================
            // 封印箱類型開始
            int soulCount = item.ReadInt32(); // 封印箱數量
            for (int i = 0; i < soulCount; i++)
            {
                int itemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                item.ReadByte();
                int Spirit = item.ReadInt32();
                item.ReadInt32();
                int price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadBytes(16);

                soulData.Add(itemId, new ItemData(itemId, itemNameString, Spirit, price));
            }
            all.Add(soulData);
            //==============================================================================
            // 帽子類型開始
            int hatCount = item.ReadInt32(); // 帽子數量
            for (int i = 0; i < hatCount; i++)
            {
                int itemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                item.ReadByte();
                short Str = item.ReadInt16();
                short Dex = item.ReadInt16();
                short Vit = item.ReadInt16();
                short Int = item.ReadInt16();
                item.ReadInt16();
                short Hp = item.ReadInt16();
                short Mp = item.ReadInt16();
                int price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadByte();
                item.ReadBytes(3);
                item.ReadBytes(12);
                hatData.Add(itemId, new ItemData(itemId, itemNameString, Str, Dex, Vit, Int, Hp, Mp, price));
            }
            all.Add(hatData);
            //==============================================================================
            // 髮型類型開始
            int hairCount = item.ReadInt32(); // 髮型數量
            for (int i = 0; i < hairCount; i++)
            {
                int ItemId = item.ReadInt32(); // 物品編號
                byte[] ItemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string ItemNameString = Encoding.GetEncoding("UTF-16LE").GetString(ItemNameByteArray); // 物品名稱 (Byte[] => String)
                byte Gender = item.ReadByte();
                int Price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadBytes(16);

                hairData.Add(ItemId, new ItemData(ItemId, ItemNameString, Price));
            }
            all.Add(hairData);
            //==============================================================================
            // 眼睛類型開始
            int eyesCount = item.ReadInt32(); // 眼睛數量
            for (int i = 0; i < eyesCount; i++)
            {
                int ItemId = item.ReadInt32(); // 物品編號
                byte[] ItemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string ItemNameString = Encoding.GetEncoding("UTF-16LE").GetString(ItemNameByteArray); // 物品名稱 (Byte[] => String)
                byte Gender = item.ReadByte();
                int Price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadBytes(16);

                eyesData.Add(ItemId, new ItemData(ItemId, ItemNameString, Price));
            }
            all.Add(eyesData);
            //==============================================================================
            // 面具類型開始
            int maskCount = item.ReadInt32(); // 面具數量
            for (int i = 0; i < maskCount; i++)
            {
                int itemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                item.ReadByte();
                int price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadBytes(16);

                maskData.Add(itemId, new ItemData(itemId, itemNameString, price));
            }
            all.Add(maskData);
            //==============================================================================
            // 鬍子類型開始
            int beardCount = item.ReadInt32(); // 鬍子數量
            for (int i = 0; i < beardCount; i++)
            {
                int itemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                item.ReadByte();
                int price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadBytes(16);

                beardData.Add(itemId, new ItemData(itemId, itemNameString, price));
            }
            all.Add(beardData);
            //==============================================================================
            // 其他類型開始
            int etcCount = item.ReadInt32(); // 其他數量
            for (int i = 0; i < etcCount; i++)
            {
                int itemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                item.ReadByte();
                int price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadBytes(16);
                byte[] itemDescriptionByteArray = item.ReadBytes(256); // 物品敘述 (Byte[])
                string itemDescriptionString = Encoding.GetEncoding("UTF-16LE").GetString(itemDescriptionByteArray); // 物品敘述 (Byte[] => String)

                etcData.Add(itemId, new ItemData(itemId, itemNameString, price));
            }
            all.Add(etcData);
            //==============================================================================
            // 寵物類型開始
            int petCount = item.ReadInt32(); // 寵物類型數量
            for (int i = 0; i < petCount; i++)
            {
                int itemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                item.ReadByte();
                item.ReadInt32();
                item.ReadInt32();
                item.ReadInt32();
                int price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadBytes(16);
                item.ReadByte();
                byte[] itemDescriptionByteArray = item.ReadBytes(256); // 物品敘述 (Byte[])
                string itemDescriptionString = Encoding.GetEncoding("UTF-16LE").GetString(itemDescriptionByteArray); // 物品敘述 (Byte[] => String)

                petData.Add(itemId, new ItemData(itemId, itemNameString, price));
            }
            all.Add(petData);
            //==============================================================================
            // 領巾類型開始
            int scarfCount = item.ReadInt32(); // 領巾類型數量
            for (int i = 0; i < scarfCount; i++)
            {
                int itemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                item.ReadByte();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                int price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadBytes(16);
                byte[] itemDescriptionByteArray = item.ReadBytes(256); // 物品敘述 (Byte[])
                string itemDescriptionString = Encoding.GetEncoding("UTF-16LE").GetString(itemDescriptionByteArray); // 物品敘述 (Byte[] => String)

                scarfData.Add(itemId, new ItemData(itemId, itemNameString, price));
            }
            all.Add(scarfData);
            //==============================================================================
            // 未知類型開始
            int unknownCount = item.ReadInt32(); // 未知數量
            for (int i = 0; i < unknownCount; i++)
            {
                int itemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                item.ReadByte();
                item.ReadByte();
                item.ReadByte();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadByte();
                int price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadBytes(16);
                item.ReadBytes(6);

                unknownData.Add(itemId, new ItemData(itemId, itemNameString, price));
            }
            all.Add(unknownData);
            //==============================================================================
            // 拼圖類型開始
            int jigsawCount = item.ReadInt32(); // 拼圖數量
            for (int i = 0; i < jigsawCount; i++)
            {
                int itemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                int price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadByte();

                jigsawData.Add(itemId, new ItemData(itemId, itemNameString, price));
            }
            all.Add(jigsawData);
            //==============================================================================
            // 耳環類型開始
            int earringCount = item.ReadInt32(); // 耳環數量
            for (int i = 0; i < earringCount; i++)
            {
                int itemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                item.ReadByte();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadByte();
                int price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadByte();
                byte[] itemDescriptionByteArray = item.ReadBytes(256); // 物品敘述 (Byte[])
                string itemDescriptionString = Encoding.GetEncoding("UTF-16LE").GetString(itemDescriptionByteArray); // 物品敘述 (Byte[] => String)

                earringData.Add(itemId, new ItemData(itemId, itemNameString, price));
            }
            all.Add(earringData);
            itemFile.Close();
            item.Close();
        }

        public static ItemData GetItemData(int itemID)
        {
            foreach (Dictionary<int, ItemData> idata in all)
            {
                if (idata.ContainsKey(itemID))
                {
                    return idata[itemID];
                }
            }
            return null;
        }
    }
}
