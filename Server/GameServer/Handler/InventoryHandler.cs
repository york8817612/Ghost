using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Ghost;
using System.Collections.Generic;

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
            int itemId = 0;
            List<Item> item = gc.Character.Items.getItems();
            foreach (Item im in item)
            {
                itemId = (im.type == originalType && im.slot == originalSlot) ? im.ItemID : 0;
                if (itemId != 0)
                {
                    im.type = moveToType;
                    im.slot = moveToSlot;
                    break;
                }
            }
            switch (originalType)
            {
                case 0:
                    InventoryPacket.getCharacterEquip(gc);
                    break;
                case 1:
                    InventoryPacket.getInvenEquip1(gc, gc.Character.Items.getItems());
                    break;
                case 2:
                    InventoryPacket.getInvenEquip2(gc, gc.Character.Items.getItems());
                    break;
                case 3:
                    InventoryPacket.getInvenSpend3(gc, gc.Character.Items.getItems());
                    break;
                case 4:
                    InventoryPacket.getInvenOther4(gc, gc.Character.Items.getItems());
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
                    InventoryPacket.getInvenEquip1(gc, gc.Character.Items.getItems());
                    break;
                case 2:
                    InventoryPacket.getInvenEquip2(gc, gc.Character.Items.getItems());
                    break;
                case 3:
                    InventoryPacket.getInvenSpend3(gc, gc.Character.Items.getItems());
                    break;
                case 4:
                    InventoryPacket.getInvenOther4(gc, gc.Character.Items.getItems());
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
                gc.Character.Items.DeleteItem(gc.Character.Items.getItems(), (byte)ItemTypeConstants.ItemType.Use, slot);
                MapPacket.InvenUseSpendShout(gc, message);
                InventoryPacket.getInvenSpend3(gc, gc.Character.Items.getItems());
            }
        }
    }
}
