using Server.Common.Constants;
using Server.Common.Data;
using System.Collections.Generic;

namespace Server.Ghost.Characters
{
    public class Inventory
    {
        public Character Parent { get; private set; }

        private Dictionary<byte, Item> inventory;
        private byte slotLimit = 0;
        private InventoryType.ItemType type;

        public Inventory(InventoryType.ItemType type, Character parent)
        {
            this.inventory = new Dictionary<byte, Item>();
            this.type = type;
            this.Parent = parent;
        }

        public void Load(InventoryType.ItemType type)
        {
            foreach (dynamic datum in new Datums("Items").Populate("cid = '{0}'", this.Parent.ID))
            {
                if (datum.type != (byte)type)
                    continue;
                this.Add(new Item(datum), (byte)datum.slot);
            }
        }

        public void Add(Item item, byte slot)
        {
            if (item.Quantity > 0)
            {
                this.inventory.Add(slot, item);
            }
        }

        public void addSlot(byte slot)
        {
            this.slotLimit += slot;

            if (slotLimit > 24)
            {
                slotLimit = 24;
            }
        }

        public byte getSlotLimit()
        {
            return slotLimit;
        }

        public void setSlotLimit(byte slot)
        {
            if (slot > 24)
            {
                slot = 24;
            }
            slotLimit = slot;
        }

        public Item findById(int itemId, int slot)
        {
            foreach (Item item in this.inventory.Values)
            {
                if (item.ItemID == itemId && item.slot == slot)
                {
                    return item;
                }
            }
            return null;
        }

        public Item findById(int itemId)
        {
            foreach (Item item in this.inventory.Values)
            {
                if (item.ItemID == itemId)
                {
                    return item;
                }
            }
            return null;
        }

        public byte AddItem(Item item)
        {
            byte slot = getNextFreeSlot();
            if (slot < 0)
            {
                return 0xFF;
            }
            this.inventory.Add(slot, item);
            item.slot = slot;
            return slot;
        }

        public void AddItem(byte slot, Item item)
        {
            this.inventory.Add(slot, item);
            item.slot = slot;
        }

        public void Move(byte sSlot, byte dSlot, short slotMax)
        {
            Item source = (Item)inventory[sSlot];
            Item target = null;
            try
            {
                target = (Item)inventory[dSlot];
            } catch
            {
                target = null;
            }
            if (target == null)
            {
                source.slot = dSlot;
                inventory.Add(dSlot, source);
                inventory.Remove(sSlot);
            }
            else if (target.ItemID == source.ItemID)
            {
                if (type == InventoryType.ItemType.Equip1 || type == InventoryType.ItemType.Equip2 || type == InventoryType.ItemType.Pet5)
                {
                    swap(target, source);
                }
                else if (source.Quantity + target.Quantity > slotMax)
                {
                    source.Quantity = (byte)((source.Quantity + target.Quantity) - slotMax);
                    target.Quantity = slotMax;
                }
                else {
                    target.Quantity = (byte)(source.Quantity + target.Quantity);
                    inventory.Remove(sSlot);
                }
            }
            else {
                swap(target, source);
            }
        }

        private void swap(Item source, Item target)
        {
            this.inventory.Remove(source.slot);
            this.inventory.Remove(target.slot);
            byte swapSlot = source.slot;
            source.slot = target.slot;
            target.slot = swapSlot;
            this.inventory.Add(source.slot, source);
            this.inventory.Add(target.slot, target);
        }

        public Item getItem(byte slot)
        {
            try
            {
                return this.inventory[slot];
            }
            catch
            {
                return null;
            }
        }

        public void removeItem(byte slot)
        {
            removeItem(slot, (short)1, false);
        }

        public void removeItem(byte slot, short quantity, bool allowZero)
        {
            Item item = (Item)this.inventory[slot];
            if (item == null)
            {
                return;
            }
            item.Quantity = (short)(item.Quantity - quantity);
            if (item.Quantity < 0)
            {
                item.Quantity = 0;
            }
            if ((item.Quantity == 0) && (!allowZero))
            {
                removeSlot(slot);
            }
        }

        public void removeSlot(byte slot)
        {
            this.inventory.Remove(slot);
        }

        public bool isFull()
        {
            return this.inventory.Count >= this.slotLimit;
        }

        public byte getNextFreeSlot()
        {
            if (isFull())
            {
                return 0xFF;
            }
            for (byte i = 1; i <= this.slotLimit; i = (byte)(i + 1))
            {
                if (!this.inventory.ContainsKey(i))
                {
                    return i;
                }
            }
            return 0xFF;
        }

        public InventoryType.ItemType getType()
        {
            return this.type;
        }
    }
}
