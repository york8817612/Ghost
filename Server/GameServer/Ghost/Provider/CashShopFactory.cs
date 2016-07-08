using Server.Common.Data;
using Server.Common.IO;
using System.Collections.Generic;

namespace Server.Ghost.Provider
{
    public static class CashShopFactory
    {
        public static List<Commodity> HatList = new List<Commodity>();
        public static List<Commodity> BoyDressList = new List<Commodity>();
        public static List<Commodity> GirlDressList = new List<Commodity>();
        public static List<Commodity> MantleList = new List<Commodity>();
        public static List<Commodity> BoyHairList = new List<Commodity>();
        public static List<Commodity> GirlHairList = new List<Commodity>();
        public static List<Commodity> Face1List = new List<Commodity>();
        public static List<Commodity> Face2List = new List<Commodity>();
        public static List<Commodity> BoyEyesList = new List<Commodity>();
        public static List<Commodity> GirlEyesList = new List<Commodity>();
        public static List<Commodity> PetList = new List<Commodity>();
        public static List<Commodity> AmuletList = new List<Commodity>();
        public static List<Commodity> TalismanList = new List<Commodity>();
        public static List<Commodity> ProduceList = new List<Commodity>();

        public static Dictionary<int, Commodity> Hat = new Dictionary<int, Commodity>();
        public static Dictionary<int, Commodity> BoyDress = new Dictionary<int, Commodity>();
        public static Dictionary<int, Commodity> GirlDress = new Dictionary<int, Commodity>();
        public static Dictionary<int, Commodity> Mantle = new Dictionary<int, Commodity>();
        public static Dictionary<int, Commodity> BoyHair = new Dictionary<int, Commodity>();
        public static Dictionary<int, Commodity> GirlHair = new Dictionary<int, Commodity>();
        public static Dictionary<int, Commodity> Face1 = new Dictionary<int, Commodity>();
        public static Dictionary<int, Commodity> Face2 = new Dictionary<int, Commodity>();
        public static Dictionary<int, Commodity> BoyEyes = new Dictionary<int, Commodity>();
        public static Dictionary<int, Commodity> GirlEyes = new Dictionary<int, Commodity>();
        public static Dictionary<int, Commodity> Pet = new Dictionary<int, Commodity>();
        public static Dictionary<int, Commodity> Amulet = new Dictionary<int, Commodity>();
        public static Dictionary<int, Commodity> Talisman = new Dictionary<int, Commodity>();
        public static Dictionary<int, Commodity> Produce = new Dictionary<int, Commodity>();
        public static List<Dictionary<int, Commodity>> All = new List<Dictionary<int, Commodity>>();

        public static void InitializeHatCommodity()
        {
            using (Log.Load("Loading HatCommodity"))
            {
                foreach (dynamic datum in new Datums("HatCommodity").Populate())
                {
                    HatList.Add(new Commodity(datum));
                    Hat.Add(datum.itemID, new Commodity(datum));
                }
                All.Add(Hat);
            }
        }

        public static void InitializeBoyDressCommodity()
        {
            using (Log.Load("Loading BoyDressCommodity"))
            {
                foreach (dynamic datum in new Datums("BoyDressCommodity").Populate())
                {
                    BoyDressList.Add(new Commodity(datum));
                    BoyDress.Add(datum.itemID, new Commodity(datum));
                }
                All.Add(BoyDress);
            }
        }

        public static void InitializeGirlDressCommodity()
        {
            using (Log.Load("Loading GirlDressCommodity"))
            {
                foreach (dynamic datum in new Datums("GirlDressCommodity").Populate())
                {
                    GirlDressList.Add(new Commodity(datum));
                    GirlDress.Add(datum.itemID, new Commodity(datum));
                }
                All.Add(GirlDress);
            }
        }

        public static void InitializeMantleCommodity()
        {
            using (Log.Load("Loading MantleCommodity"))
            {
                foreach (dynamic datum in new Datums("MantleCommodity").Populate())
                {
                    MantleList.Add(new Commodity(datum));
                    Mantle.Add(datum.itemID, new Commodity(datum));
                }
                All.Add(Mantle);
            }
        }

        public static void InitializeBoyHairCommodity()
        {
            using (Log.Load("Loading BoyHairCommodity"))
            {
                foreach (dynamic datum in new Datums("BoyHairCommodity").Populate())
                {
                    BoyHairList.Add(new Commodity(datum));
                    BoyHair.Add(datum.itemID, new Commodity(datum));
                }
                All.Add(BoyHair);
            }
        }

        public static void InitializeGirlHairCommodity()
        {
            using (Log.Load("Loading GirlHairCommodity"))
            {
                foreach (dynamic datum in new Datums("GirlHairCommodity").Populate())
                {
                    GirlHairList.Add(new Commodity(datum));
                    GirlHair.Add(datum.itemID, new Commodity(datum));
                }
                All.Add(GirlHair);
            }
        }

        public static void InitializeFace1Commodity()
        {
            using (Log.Load("Loading Face1"))
            {
                foreach (dynamic datum in new Datums("Face1Commodity").Populate())
                {
                    Face1List.Add(new Commodity(datum));
                    Face1.Add(datum.itemID, new Commodity(datum));
                }
                All.Add(Face1);
            }
        }

        public static void InitializeFace2Commodity()
        {
            using (Log.Load("Loading Face2"))
            {
                foreach (dynamic datum in new Datums("Face2Commodity").Populate())
                {
                    Face2List.Add(new Commodity(datum));
                    Face2.Add(datum.itemID, new Commodity(datum));
                }
                All.Add(Face2);
            }
        }

        public static void InitializeBoyEyesCommodity()
        {
            using (Log.Load("Loading BoyEyesCommodity"))
            {
                foreach (dynamic datum in new Datums("BoyEyesCommodity").Populate())
                {
                    BoyEyesList.Add(new Commodity(datum));
                    BoyEyes.Add(datum.itemID, new Commodity(datum));
                }
                All.Add(BoyEyes);
            }
        }

        public static void InitializeGirlEyesCommodity()
        {
            using (Log.Load("Loading GirlEyesCommodity"))
            {
                foreach (dynamic datum in new Datums("GirlEyesCommodity").Populate())
                {
                    GirlEyesList.Add(new Commodity(datum));
                    GirlEyes.Add(datum.itemID, new Commodity(datum));
                }
                All.Add(GirlEyes);
            }
        }

        public static void InitializePetCommodity()
        {
            using (Log.Load("Loading PetCommodity"))
            {
                foreach (dynamic datum in new Datums("PetCommodity").Populate())
                {
                    PetList.Add(new Commodity(datum));
                    Pet.Add(datum.itemID, new Commodity(datum));
                }
                All.Add(Pet);
            }
        }

        public static void InitializeAmuletCommodity()
        {
            using (Log.Load("Loading AmuletCommodity"))
            {
                foreach (dynamic datum in new Datums("AmuletCommodity").Populate())
                {
                    AmuletList.Add(new Commodity(datum));
                    Amulet.Add(datum.itemID, new Commodity(datum));
                }
                All.Add(Amulet);
            }
        }

        public static void InitializeTalismanCommodity()
        {
            using (Log.Load("Loading TalismanCommodity"))
            {
                foreach (dynamic datum in new Datums("TalismanCommodity").Populate())
                {
                    TalismanList.Add(new Commodity(datum));
                    Talisman.Add(datum.itemID, new Commodity(datum));
                }
                All.Add(Talisman);
            }
        }

        public static void InitializeProduceCommodity()
        {
            using (Log.Load("Loading ProduceCommodity"))
            {
                foreach (dynamic datum in new Datums("ProduceCommodity").Populate())
                {
                    ProduceList.Add(new Commodity(datum));
                    Produce.Add(datum.itemID, new Commodity(datum));
                }
                All.Add(Produce);
            }
        }

        public static Commodity GetItemData(int ItemID)
        {
            foreach (Dictionary<int, Commodity> Data in All)
            {
                if (Data.ContainsKey(ItemID))
                    return Data[ItemID];
            }
            return null;
        }
    }
}
