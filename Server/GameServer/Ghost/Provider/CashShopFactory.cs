using Server.Common.Data;
using Server.Common.IO;
using System.Collections.Generic;

namespace Server.Ghost.Provider
{
    public static class CashShopFactory
    {
        public static List<Commodity> Hat = new List<Commodity>();
        public static List<Commodity> BoyDress = new List<Commodity>();
        public static List<Commodity> GirlDress = new List<Commodity>();
        public static List<Commodity> Mantle = new List<Commodity>();
        public static List<Commodity> BoyHair = new List<Commodity>();
        public static List<Commodity> GirlHair = new List<Commodity>();
        public static List<Commodity> Face1 = new List<Commodity>();
        public static List<Commodity> Face2 = new List<Commodity>();
        public static List<Commodity> BoyEyes = new List<Commodity>();
        public static List<Commodity> GirlEyes = new List<Commodity>();

        public static void InitializeHatCommodity()
        {
            using (Log.Load("Loading HatCommodity"))
            {
                foreach (dynamic datum in new Datums("HatCommodity").Populate())
                {
                    Hat.Add(new Commodity(datum));
                }
            }
        }

        public static void InitializeBoyDressCommodity()
        {
            using (Log.Load("Loading BoyDressCommodity"))
            {
                foreach (dynamic datum in new Datums("BoyDressCommodity").Populate())
                {
                    BoyDress.Add(new Commodity(datum));
                }
            }
        }

        public static void InitializeGirlDressCommodity()
        {
            using (Log.Load("Loading GirlDressCommodity"))
            {
                foreach (dynamic datum in new Datums("GirlDressCommodity").Populate())
                {
                    GirlDress.Add(new Commodity(datum));
                }
            }
        }

        public static void InitializeMantleCommodity()
        {
            using (Log.Load("Loading MantleCommodity"))
            {
                foreach (dynamic datum in new Datums("MantleCommodity").Populate())
                {
                    Mantle.Add(new Commodity(datum));
                }
            }
        }

        public static void InitializeBoyHairCommodity()
        {
            using (Log.Load("Loading BoyHairCommodity"))
            {
                foreach (dynamic datum in new Datums("BoyHairCommodity").Populate())
                {
                    BoyHair.Add(new Commodity(datum));
                }
            }
        }

        public static void InitializeGirlHairCommodity()
        {
            using (Log.Load("Loading GirlHairCommodity"))
            {
                foreach (dynamic datum in new Datums("GirlHairCommodity").Populate())
                {
                    GirlHair.Add(new Commodity(datum));
                }
            }
        }

        public static void InitializeFace1Commodity()
        {
            using (Log.Load("Loading Face1"))
            {
                foreach (dynamic datum in new Datums("Face1Commodity").Populate())
                {
                    Face1.Add(new Commodity(datum));
                }
            }
        }

        public static void InitializeFace2Commodity()
        {
            using (Log.Load("Loading Face2"))
            {
                foreach (dynamic datum in new Datums("Face2Commodity").Populate())
                {
                    Face2.Add(new Commodity(datum));
                }
            }
        }

        public static void InitializeBoyEyesCommodity()
        {
            using (Log.Load("Loading BoyEyesCommodity"))
            {
                foreach (dynamic datum in new Datums("BoyEyesCommodity").Populate())
                {
                    BoyEyes.Add(new Commodity(datum));
                }
            }
        }

        public static void InitializeGirlEyesCommodity()
        {
            using (Log.Load("Loading GirlEyesCommodity"))
            {
                foreach (dynamic datum in new Datums("GirlEyesCommodity").Populate())
                {
                    GirlEyes.Add(new Commodity(datum));
                }
            }
        }
    }
}
