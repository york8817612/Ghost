using Server.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Server.Ghost.Provider
{
    public class ItemFactory
    {
        private static string openPath = Application.LaunchPath + @"\table\item.itm";

        //武器資料
        //物品編號(int), 物品名稱(string), 職業(byte), 功力(byte), 類型(short), 攻擊距離(short), 購買價格(int)
        public static Dictionary<int, Tuple<string, byte, byte, short, short, int>> weaponData = new Dictionary<int, Tuple<string, byte, byte, short, short, int>>();
        //衣服資料
        //物品編號(int), 物品名稱(string), 職業(byte), 功力(byte), 購買價格(int)
        public static Dictionary<int, Tuple<string, byte, byte, int>> topData = new Dictionary<int, Tuple<string, byte, byte, int>>();
        //服裝資料
        //物品編號(int), 物品名稱(string), 職業(byte), 功力(byte), 購買價格(int)
        public static Dictionary<int, Tuple<string, byte, byte, int>> clothingData = new Dictionary<int, Tuple<string, byte, byte, int>>();
        //戒指資料
        //物品編號(int), 物品名稱(string), 職業(byte), 功力(byte), 購買價格(int)
        public static Dictionary<int, Tuple<string, byte, byte, int>> ringData = new Dictionary<int, Tuple<string, byte, byte, int>>();
        //項鍊資料
        //物品編號(int), 物品名稱(string), 職業(byte), 功力(byte), 購買價格(int)
        public static Dictionary<int, Tuple<string, byte, byte, int>> necklaceData = new Dictionary<int, Tuple<string, byte, byte, int>>();
        //披風資料
        //物品編號(int), 物品名稱(string), 職業(byte), 功力(byte), 購買價格(int)
        public static Dictionary<int, Tuple<string, byte, byte, int>> capeData = new Dictionary<int, Tuple<string, byte, byte, int>>();
        //消耗品資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, Tuple<string, int>> useData = new Dictionary<int, Tuple<string, int>>();
        //封印箱資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, Tuple<string, int>> soulData = new Dictionary<int, Tuple<string, int>>();
        //帽子資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, Tuple<string, int>> hatData = new Dictionary<int, Tuple<string, int>>();
        //髮型資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, Tuple<string, int>> hairData = new Dictionary<int, Tuple<string, int>>();
        //眼睛資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, Tuple<string, int>> eyesData = new Dictionary<int, Tuple<string, int>>();
        //面具資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, Tuple<string, int>> maskData = new Dictionary<int, Tuple<string, int>>();
        //鬍子資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, Tuple<string, int>> beardData = new Dictionary<int, Tuple<string, int>>();
        //其他資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, Tuple<string, int>> etcData = new Dictionary<int, Tuple<string, int>>();
        //寵物資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, Tuple<string, int>> petData = new Dictionary<int, Tuple<string, int>>();
        //領巾資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, Tuple<string, int>> scarfData = new Dictionary<int, Tuple<string, int>>();
        //未知資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, Tuple<string, int>> unknownData = new Dictionary<int, Tuple<string, int>>();
        //拼圖資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, Tuple<string, int>> jigsawData = new Dictionary<int, Tuple<string, int>>();
        //耳環資料
        //物品編號(int), 物品名稱(string), 購買價格(int)
        public static Dictionary<int, Tuple<string, int>> earringData = new Dictionary<int, Tuple<string, int>>();


        public static void initItem()
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
                byte job = item.ReadByte(); // 職業?
                byte level = item.ReadByte(); // 功力
                short attack = item.ReadInt16(); // 類型
                item.ReadInt16();
                short attackRange = item.ReadInt16(); // 攻擊距離
                item.ReadInt16();
                item.ReadByte(); // 攻擊速度?
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                int price = item.ReadInt32(); // 購買價格
                item.ReadByte();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadBytes(16);
                item.ReadBytes(20);

                weaponData.Add(itemId, new Tuple<string, byte, byte, short, short, int>(itemNameString, job, level, attack, attackRange, price));
            }
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
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadInt16();
                int price = item.ReadInt32(); // 購買價格
                item.ReadByte();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadBytes(16);
                item.ReadBytes(20);

                topData.Add(itemId, new Tuple<string, byte, byte, int>(itemNameString, job, level, price));
            }
            //==============================================================================
            //服裝類型開始
            int clothingCount = item.ReadInt32(); // 服裝數量
            for (int i = 0; i < clothingCount; i++)
            {
                int itemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                item.ReadByte();
                byte job = item.ReadByte();
                byte level = item.ReadByte();
                item.ReadInt16();
                item.ReadInt16();
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

                clothingData.Add(itemId, new Tuple<string, byte, byte, int>(itemNameString, job, level, price));
            }
            //==============================================================================
            // 戒指類型開始
            int ringCount = item.ReadInt32(); // 戒指數量
            for (int i = 0; i < ringCount; i++)
            {
                int itemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                byte job = item.ReadByte();
                byte level = item.ReadByte();
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
                int price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadByte();
                item.ReadBytes(10);
                item.ReadBytes(5);
                byte[] itemDescriptionByteArray = item.ReadBytes(256); // 物品敘述 (Byte[])
                string itemDescriptionString = Encoding.GetEncoding("UTF-16LE").GetString(itemDescriptionByteArray); // 物品敘述 (Byte[] => String)

                ringData.Add(itemId, new Tuple<string, byte, byte, int>(itemNameString, job, level, price));
            }
            //==============================================================================
            // 項鍊類型開始
            int necklaceCount = item.ReadInt32(); // 項鍊數量
            for (int i = 0; i < necklaceCount; i++)
            {
                int itemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                byte job = item.ReadByte();
                byte level = item.ReadByte();
                item.ReadInt16();
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
                item.ReadBytes(10);
                item.ReadBytes(5);
                byte[] itemDescriptionByteArray = item.ReadBytes(256); // 物品敘述 (Byte[])
                string itemDescriptionString = Encoding.GetEncoding("UTF-16LE").GetString(itemDescriptionByteArray); // 物品敘述 (Byte[] => String)

                necklaceData.Add(itemId, new Tuple<string, byte, byte, int>(itemNameString, job, level, price));
            }
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
                int price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadByte();
                item.ReadBytes(3);
                item.ReadBytes(12);

                capeData.Add(itemId, new Tuple<string, byte, byte, int>(itemNameString, job, level, price));
        }
            //==============================================================================
            // 消耗類型開始
            int useCount = item.ReadInt32(); // 消耗道具數量
            for (int i = 0; i < useCount; i++)
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

                useData.Add(itemId, new Tuple<string, int>(itemNameString, price));
            }
            //==============================================================================
            // 封印箱類型開始
            int soulCount = item.ReadInt32(); // 封印箱數量
            for (int i = 0; i < soulCount; i++)
            {
                int itemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                item.ReadByte();
                item.ReadInt32();
                item.ReadInt32();
                int price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadBytes(16);

                soulData.Add(itemId, new Tuple<string, int>(itemNameString, price));
            }
            //==============================================================================
            // 帽子類型開始
            int hatCount = item.ReadInt32(); // 帽子數量
            for (int i = 0; i < hatCount; i++)
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
                int price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadByte();
                item.ReadBytes(3);
                item.ReadBytes(12);

                hatData.Add(itemId, new Tuple<string, int>(itemNameString, price));
            }
            //==============================================================================
            // 髮型類型開始
            int hairCount = item.ReadInt32(); // 髮型數量
            for (int i = 0; i < hairCount; i++)
            {
                int itemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                item.ReadByte();
                int price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadBytes(16);

                hairData.Add(itemId, new Tuple<string, int>(itemNameString, price));
            }
            //==============================================================================
            // 眼睛類型開始
            int eyesCount = item.ReadInt32(); // 眼睛數量
            for (int i = 0; i < eyesCount; i++)
            {
                int itemId = item.ReadInt32(); // 物品編號
                byte[] itemNameByteArray = item.ReadBytes(62); // 物品名稱 (Byte[])
                string itemNameString = Encoding.GetEncoding("UTF-16LE").GetString(itemNameByteArray); // 物品名稱 (Byte[] => String)
                item.ReadByte();
                int price = item.ReadInt32();
                item.ReadInt16();
                item.ReadInt16();
                item.ReadBytes(16);

                eyesData.Add(itemId, new Tuple<string, int>(itemNameString, price));
            }
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

                maskData.Add(itemId, new Tuple<string, int>(itemNameString, price));
            }
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

                beardData.Add(itemId, new Tuple<string, int>(itemNameString, price));
            }
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

                etcData.Add(itemId, new Tuple<string, int>(itemNameString, price));
            }
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

                petData.Add(itemId, new Tuple<string, int>(itemNameString, price));
            }
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

                scarfData.Add(itemId, new Tuple<string, int>(itemNameString, price));
            }
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

                unknownData.Add(itemId, new Tuple<string, int>(itemNameString, price));
            }
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

                jigsawData.Add(itemId, new Tuple<string, int>(itemNameString, price));
            }
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

                earringData.Add(itemId, new Tuple<string, int>(itemNameString, price));
            }
            itemFile.Close();
            item.Close();
        }
    }
}
