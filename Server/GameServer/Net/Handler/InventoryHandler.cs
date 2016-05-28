using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Ghost.Characters;
using Server.Net;
using Server.Packet;

namespace Server.Handler
{
    class InventoryHandler
    {
        public static void MoveItem_Req(InPacket lea, Client gc)
        {
            byte SourceType = lea.ReadByte();
            byte SorceSlot = lea.ReadByte();
            byte TargetType = lea.ReadByte();
            byte TargetSlot = lea.ReadByte();
            int Quantit = lea.ReadInt();
            Item Source = gc.Character.Items.GetItem(SourceType, SorceSlot);
            Item Target = gc.Character.Items.GetItem(TargetType, TargetSlot);
            var chr = gc.Character;

            if (TargetType == 0x63 && TargetSlot == 0x63)
            {
                if (SourceType == 0xFF && SorceSlot == 0xFF)
                    return;
                Map map = Maps.GetMap(chr.MapX, chr.MapY);
                InventoryPacket.charDropItem(gc, map.DropOriginalID, Source.ItemID, gc.Character.PlayerX, (short)(gc.Character.PlayerY - 50), Quantit);
                map.DropItem.Add(map.DropOriginalID, Source);
                map.DropOriginalID++;
                gc.Character.Items.RemoveItem(SourceType, SorceSlot);
            }
            else
            {
                if (gc.Character.Items.GetItem(TargetType, TargetSlot) == null)
                {
                    Source.type = TargetType;
                    Source.slot = TargetSlot;
                }
                else
                {   // 交換位置(swap)
                    gc.Character.Items.RemoveItem(SourceType, SorceSlot);
                    gc.Character.Items.RemoveItem(TargetType, TargetSlot);
                    byte swapSlot = Source.slot;
                    Source.slot = Target.slot;
                    Target.slot = swapSlot;
                    gc.Character.Items.Add(Source);
                    gc.Character.Items.Add(Target);
                }
            }
            UpdateEquip(gc, SourceType, TargetType);
        }

        public static void UseSpend_Req(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            byte Type = lea.ReadByte();
            byte Slot = lea.ReadByte();
            int ItemID = chr.Items.GetItemID((InventoryType.ItemType)Type, Slot);
            Map map = Maps.GetMap(chr.MapX, chr.MapY);
            switch (ItemID)
            {
                case 8843030: // 豬大長召喚符
                    Monster[] monster = new Monster[50];
                    map.Monster.Add(new Monster(0, 1003001, 30, 29200, 0, 3, 0xFF, 1, 0, chr.PlayerX, chr.PlayerY));
                    for (int i = 1; i < 50; i++)
                        map.Monster.Add(null);
                    MonsterPacket.createAllMonster(gc, map, map.Monster);
                    System.Timers.Timer tmr = new System.Timers.Timer(1000);
                    tmr.Elapsed += delegate
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            try
                            {
                                if (map.Monster[i].State == 7 || map.Monster[i].State == 9)
                                {
                                    map.Monster[i].State = 1;
                                    //map.Monster[i].Direction = map.Monster[i].Direction * -1;
                                    //Monster m = FindPath(map.Monster[i], 40, map);
                                    //monster[i].Direction = m.Direction;
                                    //map.Monster[i].PositionX = m.PositionX;
                                    //map.Monster[i].PositionY = m.PositionY;
                                    MonsterPacket.spawnMonster(gc, map.Monster[i], 0, 0, 0, 0);
                                    continue;
                                }
                                Monster mon = MapHandler.FindPath(map.Monster[i], 40, map);
                                map.Monster[i].State = 1;
                                map.Monster[i].PositionX = mon.PositionX;
                                map.Monster[i].PositionY = mon.PositionY;
                                MonsterPacket.spawnMonster(gc, map.Monster[i], 0, 0, 0, 0);
                            }
                            catch
                            {

                            }
                        }
                    };
                    tmr.Start();
                    break;
            }
        }

        public static void InvenUseSpendShout_Req(InPacket lea, Client gc)
        {
            byte Slot = lea.ReadByte();
            string Message = lea.ReadString(60);
            lea.ReadInt();
            lea.ReadByte();
            lea.ReadByte();
            if (Slot >= 0 && Slot < 24 && Message.Length <= 60)
            {
                gc.Character.Items.RemoveItem(InventoryType.ItemType.Spend3, Slot);
                foreach (Character all in Maps.AllCharacters)
                {
                    MapPacket.InvenUseSpendShout(all.Client, Message);
                }
                InventoryPacket.getInvenSpend3(gc);
            }
        }

        public static void PickupItem(InPacket lea, Client gc)
        {
            int OriginalID = lea.ReadInt();
            int ItemID = lea.ReadInt();
            lea.ReadInt();
            byte Type = InventoryType.getItemType(ItemID);
            byte Slot = gc.Character.Items.GetNextFreeSlot((InventoryType.ItemType)Type);
            var chr = gc.Character;

            Item oItem = new Item(ItemID, Slot, (byte)Type, 1);
            Map map = Maps.GetMap(chr.MapX, chr.MapY);
            if (!map.DropItem.ContainsKey(OriginalID))
                return;
            chr.Items.Add(oItem);
            InventoryPacket.clearDropItem(gc, chr.CharacterID, OriginalID, ItemID, 1);
            map.DropItem.Remove(OriginalID);
            UpdateEquip(gc, Type);
        }

        public static void UpdateEquip(Client gc, byte SourceType, byte TargetType = 0xFF)
        {
            switch (SourceType)
            {
                case 0:
                    UpdateAvatar(gc);
                    switch (TargetType)
                    {
                        case 1:
                            InventoryPacket.getInvenEquip1(gc);
                            break;
                        case 2:
                            InventoryPacket.getInvenEquip2(gc);
                            break;
                    }
                    break;
                case 1:
                    if (TargetType == 0)
                        UpdateAvatar(gc);
                    InventoryPacket.getInvenEquip1(gc);
                    break;
                case 2:
                    if (TargetType == 0)
                        UpdateAvatar(gc);
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

        public static void UpdateAvatar(Client gc)
        {
            InventoryPacket.getInvenEquip(gc);
            StatusPacket.getStatusInfo(gc);
            InventoryPacket.getAvatar(gc);
        }
    }
}
