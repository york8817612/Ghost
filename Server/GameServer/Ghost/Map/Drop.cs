using System.Collections.Generic;

namespace Server.Ghost
{
    public class Drop
    {
        public int ID { get; set; }
        public int OwnerID { get; set; }
        public int ItemID { get; set; }
        public short Quantity { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public Drop(int ID, int ItemID, short Quantity)
        {
            this.ID = ID;
            this.ItemID = ItemID;
            this.Quantity = Quantity;
        }
    }
}
