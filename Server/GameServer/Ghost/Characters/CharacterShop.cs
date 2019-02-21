using Server.Ghost.Provider;
using System.Collections.Generic;

namespace Server.Ghost.Characters
{
    public class CharacterShop : List<ShopData>
    {
        public string Name { get; set; }
        public int Money { get; set; }

        public CharacterShop(string Name)
        {
            this.Name = Name;
        }

        public int ItemID(int i)
        {
            return this[i].ItemID;
        }

        public int Quantity(int i)
        {
            return this[i].Quantity;
        }

        public int SourceType(int i)
        {
            return this[i].SourceType;
        }

        public int SourceSlot(int i)
        {
            return this[i].SourceSlot;
        }

        public int Spirit(int i)
        {
            ItemData Data = ItemFactory.GetItemData(this[i].ItemID);

            if (Data == null)
                return 0;

            if (this[i].Spirit > Data.Spirit)
                return Data.Spirit;

            return this[i].Spirit;
        }

        public int Level1(int i)
        {
            return this[i].Level1;
        }

        public int Level2(int i)
        {
            return this[i].Level2;
        }

        public int Level3(int i)
        {
            return this[i].Level3;
        }

        public int Level4(int i)
        {
            return this[i].Level4;
        }

        public int Level5(int i)
        {
            return this[i].Level5;
        }

        public int Level6(int i)
        {
            return this[i].Level6;
        }

        public int Level7(int i)
        {
            return this[i].Level7;
        }

        public int Level8(int i)
        {
            return this[i].Level8;
        }

        public int Level9(int i)
        {
            return this[i].Level9;
        }

        public int Level10(int i)
        {
            return this[i].Level10;
        }

        public int Fusion(int i)
        {
            return this[i].Fusion;
        }

        public byte IsLocked(int i)
        {
            return this[i].IsLocked;
        }

        public int Icon(int i)
        {
            return this[i].Icon;
        }

        public int Term(int i)
        {
            return this[i].Term;
        }

        public int Price(int i)
        {
            return this[i].Price;
        }
    }

    public class ShopData
    {
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public int SourceType { get; set; }
        public int SourceSlot { get; set; }
        public byte TargetSlot { get; set; }
        public int Spirit { get; set; }
        // 強化系統
        public byte Level1 { get; set; }
        public byte Level2 { get; set; }
        public byte Level3 { get; set; }
        public byte Level4 { get; set; }
        public byte Level5 { get; set; }
        public byte Level6 { get; set; }
        public byte Level7 { get; set; }
        public byte Level8 { get; set; }
        public byte Level9 { get; set; }
        public byte Level10 { get; set; }
        public byte Fusion { get; set; }
        //
        public byte IsLocked { get; set; }
        public int Icon { get; set; }
        public int Term { get; set; }
        public int Price { get; set; }

        public ShopData(int ItemID, int Quantity, int SourceType, int SourceSlot, byte TargetSlot, int Spirit, byte Level1, byte Level2, byte Level3, byte Level4, byte Level5, byte Level6, byte Level7, byte Level8, byte Level9, byte Level10, byte Fusion, byte IsLocked, int Icon, int Term, int Price)
        {
            this.ItemID = ItemID;
            this.Quantity = Quantity;
            this.SourceType = SourceType;
            this.SourceSlot = SourceSlot;
            this.TargetSlot = TargetSlot;
            this.Spirit = Spirit;
            // 強化系統
            this.Level1 = Level1;
            this.Level2 = Level2;
            this.Level3 = Level3;
            this.Level4 = Level4;
            this.Level5 = Level5;
            this.Level6 = Level6;
            this.Level7 = Level7;
            this.Level8 = Level8;
            this.Level9 = Level9;
            this.Level10 = Level10;
            this.Fusion = Fusion;
            //
            this.IsLocked = IsLocked;
            this.Icon = Icon;
            this.Term = Term;
            this.Price = Price;
        }
    }
}