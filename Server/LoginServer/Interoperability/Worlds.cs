using System.Collections.ObjectModel;
using Server.Common.Constants;

namespace Server.Interoperability
{
    public sealed class Worlds : KeyedCollection<byte, World>
    {
        public Worlds() : base() { }

        public World Next(ServerUtilities.ServerType serverType)
        {
            foreach (World world in this)
            {
                if (serverType == ServerUtilities.ServerType.Char && world.IsFull)
                {
                    continue;
                }
                else if (serverType == ServerUtilities.ServerType.Game && world.IsFull)
                {
                    continue;
                }
                else if (serverType == ServerUtilities.ServerType.Message && world.IsFull)
                {
                    continue;
                }
                else if (serverType == ServerUtilities.ServerType.Shop && world.ShopServer != null)
                {
                    continue;
                }

                return world;
            }

            return null;
        }

        protected override byte GetKeyForItem(World item)
        {
            return item.ID;
        }
    }
}
