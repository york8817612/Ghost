namespace Server.Ghost
{
    public class Commodity
    {
        public int ID { get; private set; }
        public int ItemID { get; set; }
        public int Price { get; set; }
        public int BargainPrice { get; set; }
        public int Term { get; set; }
        public int Flag { get; set; }

        public Commodity(dynamic datum)
        {
            this.ItemID = datum.itemID;
            this.Price = datum.price;
            this.BargainPrice = datum.bargainPrice;
            this.Term = datum.term;
            this.Flag = datum.flag;
        }
    }
}
