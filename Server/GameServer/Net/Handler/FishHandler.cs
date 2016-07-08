using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using Server.Net;
using Server.Packet;
using System;

namespace Server.Handler
{
    public static class FishHandler
    {
        public static void Fish_Req(InPacket lea, Client c)
        {
            var chr = c.Character;
            int CharacterID = chr.CharacterID;
            Map map = MapFactory.GetMap(chr.MapX, chr.MapY);
            int State = 0;

            if (!chr.IsFishing)
                chr.IsFishing = true;
            else
                chr.IsFishing = false;

            State = CheckBait(c);

            foreach (Character All in map.Characters)
            {
                FishPacket.Fish(All.Client, CharacterID, State, chr.IsFishing);
            }

            int[] reward = { 8810012, 8820012, 8820022, 8810022, 8820032, 8810032, 8820042, 8810042, 8820052, 8810052, 8820062, 8810062, 8970001, 8970002, 8970003, 8970004, 8970005, 8970006, 8970007, 8970008, 8970009, 8970010, 8970011, 8970012 };

            System.Timers.Timer FishTimer = new System.Timers.Timer(50000);
            FishTimer.Elapsed += delegate
            {
                if (!chr.IsFishing)
                {
                    FishTimer.Stop();
                    return;
                }
                Random rnd = new Random();
                int r = rnd.Next(24);
                try
                {
                    byte Type = r < 12 ? (byte)InventoryType.ItemType.Spend3 : (byte)InventoryType.ItemType.Other4;
                    byte Slot = chr.Items.GetNextFreeSlot((InventoryType.ItemType)Type);
                    chr.Items.Add(new Item(reward[r], Type, Slot));
                    chr.Items.Remove((byte)InventoryType.ItemType.Spend3, (byte)chr.UseSlot.Slot(InventoryType.ItemType.Spend3), 1);
                    chr.Items[InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Weapon].Fusion++;
                    InventoryHandler.UpdateInventory(c, Type);
                    InventoryHandler.UpdateInventory(c, (byte)InventoryType.ItemType.Equip);
                    if (Type != 3)
                        InventoryHandler.UpdateInventory(c, (byte)InventoryType.ItemType.Spend3);
                    State = CheckBait(c);

                    if (chr.Items[InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Weapon].Fusion == 30)
                    {
                        chr.IsFishing = false;
                        State = -1;
                    }

                    if (State != 0)
                    {
                        foreach (Character All in map.Characters)
                        {
                            FishPacket.Fish(All.Client, CharacterID, State, chr.IsFishing);
                        }
                        FishTimer.Stop();
                    }
                }
                catch
                {
                    State = -3;
                    chr.IsFishing = false;
                    foreach (Character All in map.Characters)
                    {
                        FishPacket.Fish(All.Client, CharacterID, State, chr.IsFishing);
                    }
                    FishTimer.Stop();
                }
            };
            FishTimer.Start();
        }

        public static int CheckBait(Client c)
        {
            int State = 0;
            var chr = c.Character;
            Item Item = chr.Items.getItem((byte)InventoryType.ItemType.Spend3, (byte)chr.UseSlot.Slot(InventoryType.ItemType.Spend3));
            if (chr.UseSlot.Slot(InventoryType.ItemType.Spend3) == 0xFF || Item == null)
            {
                State = -2;
                chr.IsFishing = false;
            }
            return State;
        }
    }
}
