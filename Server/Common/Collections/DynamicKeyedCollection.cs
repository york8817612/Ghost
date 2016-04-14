using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Server.Common.Collections
{
    public abstract class DynamicKeyedCollection<TKey, TItem> : Collection<TItem>
    {
        public TItem this[TKey key]
        {
            get
            {
                foreach (TItem item in this)
                {
                    if (EqualityComparer<TKey>.Default.Equals(key, this.GetKeyForItem(item)))
                    {
                        return item;
                    }
                }

                return default(TItem);
            }
        }

        public bool Contains(TKey key)
        {
            return base.Contains(this[key]);
        }

        public void Remove(TKey key)
        {
            base.Remove(this[key]);
        }

        protected abstract TKey GetKeyForItem(TItem item);
    }
}
