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

        public int getItemID(int i)
        {
            return this[i].ItemID;
        }

        public int getQuantity(int i)
        {
            return this[i].Quantity;
        }

        public int getSourceType(int i)
        {
            return this[i].SourceType;
        }

        public int getSourceSlot(int i)
        {
            return this[i].SourceSlot;
        }

        public byte getIsLocked(int i)
        {
            return this[i].IsLocked;
        }

        public int getTerm(int i)
        {
            return this[i].Term;
        }

        public int getPrice(int i)
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
        public byte IsLocked { get; set; }
        public int Term { get; set; }
        public int Price { get; set; }

        public ShopData(int ItemID, int Quantity, int SourceType, int SourceSlot, byte TargetSlot, byte IsLocked, int Term, int Price)
        {
            this.ItemID = ItemID;
            this.Quantity = Quantity;
            this.SourceType = SourceType;
            this.SourceSlot = SourceSlot;
            this.TargetSlot = TargetSlot;
            this.IsLocked = IsLocked;
            this.Term = Term;
            this.Price = Price;
        }
    }
}