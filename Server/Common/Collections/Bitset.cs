using System;

namespace Server.Common.Collections
{
    public class Bitset<TEnum> where TEnum : struct, IConvertible
    {
        public int Limit { get; private set; }
        protected int[] Mask { get; private set; }

        public Bitset(int limit)
        {
            this.Limit = limit;
            this.Mask = new int[this.Limit / 8];
        }

        public void Set(TEnum value)
        {
            int bit = value.ToInt32(null);

            if (bit > this.Limit)
            {
                throw new ArgumentException("Bit is too high.");
            }

            this.Mask[bit / 32] |= 1 << (bit % 32);
        }

        public void Unset(TEnum value)
        {
            int bit = value.ToInt32(null);

            if (bit > this.Limit)
            {
                throw new ArgumentException("Bit is too high.");
            }

            this.Mask[bit / 32] &= ~(1 << (bit % 32));
        }

        public bool IsSet(TEnum value)
        {
            int bit = value.ToInt32(null);

            if (bit > this.Limit)
            {
                throw new ArgumentException("Bit is too high.");
            }

            return ((this.Mask[bit / 32] >> (bit % 32)) & 1) == 1;
        }
    }
}
