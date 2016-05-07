using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Ghost;

namespace Server.Handler
{
    class InventoryHandler
    {
        public static void MoveItem_Req(InPacket lea, Client gc)
        {
            byte originalType = lea.ReadByte();
            byte originalSlot = lea.ReadByte();
            byte moveToType = lea.ReadByte();
            byte moveToSlot = lea.ReadByte();
            Item originalItem = gc.Character.Items.SearchItem(gc.Character.Items.getItems(), originalType, originalSlot);
            gc.Character.Items.Add(new Item(originalItem.ItemID, moveToSlot, moveToType, originalItem.Quantity));
            gc.Character.Items.RemoveItem(gc.Character.Items.getItems(), originalType, originalSlot);
            gc.Character.Inventory[originalType].RemoveItem(originalSlot);
            gc.Character.Inventory[moveToType].AddItem(moveToSlot, originalItem);
            switch (originalType)
            {
                case 0:
                    InventoryPacket.getCharacterEquip(gc);
                    break;
                case 1:
                    InventoryPacket.getInvenEquip1(gc);
                    break;
                case 2:
                    InventoryPacket.getInvenEquip2(gc);
                    break;
                case 3:
                    InventoryPacket.getInvenSpend3(gc);
                    break;
                case 4:
                    InventoryPacket.getInvenOther4(gc);
                    break;
                case 5:
                    InventoryPacket.getInvenPet5(gc);
                    break;
            }
            if (originalType == moveToType)
                return;
            switch (moveToType)
            {
                case 0:
                    InventoryPacket.getCharacterEquip(gc);
                    break;
                case 1:
                    InventoryPacket.getInvenEquip1(gc);
                    break;
                case 2:
                    InventoryPacket.getInvenEquip2(gc);
                    break;
                case 3:
                    InventoryPacket.getInvenSpend3(gc);
                    break;
                case 4:
                    InventoryPacket.getInvenOther4(gc);
                    break;
                case 5:
                    InventoryPacket.getInvenPet5(gc);
                    break;
            }
        }

        public static void UseWater_Req(InPacket lea, Client gc)
        {
            int hp = lea.ReadInt();
            short mp = lea.ReadShort();
            short maxFury = lea.ReadShort();
            short fury = lea.ReadShort();
            StatusPacket.updateHpMp(gc, hp, mp, maxFury, fury);
        }

        public static void InvenUseSpendShout_Req(InPacket lea, Client gc)
        {
            byte slot = lea.ReadByte();
            string message = lea.ReadString(60);
            lea.ReadInt();
            lea.ReadByte();
            lea.ReadByte();
            if (slot >= 0 && slot < 24 && message.Length < 60)
            {
                gc.Character.Inventory[3].RemoveItem(slot);
                MapPacket.InvenUseSpendShout(gc, message);
                InventoryPacket.getInvenSpend3(gc);
            }
        }
    }
}
