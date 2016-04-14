using System;

namespace Server.Common.Utilities
{
    public static class Randomizer
    {
        private static Random m_random;

        static Randomizer()
        {
            m_random = new Random();
        }

        public static int Next()
        {
            return m_random.Next();
        }

        public static int Next(int max)
        {
            return m_random.Next(max);
        }

        public static int Next(int low, int high)
        {
            return m_random.Next(low, high);
        }

        public static double NextDouble()
        {
            return m_random.NextDouble();
        }

        public static long NextLong()
        {
            byte[] buf = new byte[8];
            m_random.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return longRand;
        }
    }
}
