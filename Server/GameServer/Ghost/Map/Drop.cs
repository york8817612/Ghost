using System.Collections.Generic;

namespace Server.Ghost
{
    public class Drop
    {
        public int ID { get; set; }
        public int OwnerID { get; set; }
        public int ItemID { get; set; }
        public short Quantity { get; set; }
        public short PositionX { get; set; }
        public short PositionY { get; set; }

        public List<Drop> Drops { get; set; }

        public Drop(int OwnerID, int ItemID, short Quantity, short PositionX, short PositionY)
        {
            this.OwnerID = OwnerID;
            this.ItemID = ItemID;
            this.Quantity = Quantity;
            this.PositionX = PositionX;
            this.PositionY = PositionY;
            this.Drops = new List<Drop>();
        }
    }
}
