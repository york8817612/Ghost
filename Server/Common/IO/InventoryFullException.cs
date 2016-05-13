using System;

namespace Server.Ghost.Characters
{
    public class InventoryFullException : Exception
    {
        public override string Message
        {
            get
            {
                return "Inventory full";
            }
        }
    }
}
