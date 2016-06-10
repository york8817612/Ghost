using System.Collections.Generic;

namespace Server.Ghost.Characters
{
    public class CharacterShop : List<ShopData>
    {
        public string Name { get; set; }

        public CharacterShop(string Name)
        {
            this.Name = Name;
        }

        public int getType(int i)
        {
            return this[i].Type;
        }

        public int getSlot(int i)
        {
            return this[i].Slot;
        }

        public int getQuantity(int i)
        {
            return this[i].Quantity;
        }

        public int getPrice(int i)
        {
            return this[i].Price;
        }
    }

    public class ShopData
    {
        public int Type { get; set; }
        public int Slot { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public ShopData(int Type, int Slot, int Quantity, int Price)
        {
            this.Type = Type;
            this.Slot = Slot;
            this.Quantity = Quantity;
            this.Price = Price;
        }
    }
}