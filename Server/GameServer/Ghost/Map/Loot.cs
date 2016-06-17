namespace Server.Ghost
{
    public class Loot
    {
        public int ID { get; set; }
        public int MobID { get; set; }
        public int ItemID { get; set; }
        public int MinimumQuantity { get; private set; }
        public int MaximumQuantity { get; private set; }
        public int QuestID { get; private set; }
        public int Chance { get; private set; }

        public Loot(dynamic datum, bool fromMob = true)
        {
            this.MobID = datum.mobID;
            this.ItemID = datum.itemID;

            if (fromMob)
            {
                this.MinimumQuantity = datum.min_quantity;
                this.MaximumQuantity = datum.max_quantity;
            }

            this.QuestID = datum.questID;
            this.Chance = datum.chance;
        }
    }
}
