using Server.Common.IO.Packet;
using Server.Common.Utilities;
using Server.Ghost;
using Server.Ghost.Provider;
using Server.Net;

namespace Server.Handler
{
    public class SpiritHandler
    {
        public static void SpiritMove(InPacket lea, Client c)
        {
            byte SourceType = lea.ReadByte();
            byte SourceSlot = lea.ReadByte();
            byte TargetType = lea.ReadByte();
            byte TargetSlot = lea.ReadByte();
            var chr = c.Character;
            Item Source = chr.Items.getItem(SourceType, SourceSlot);
            Item Target = chr.Items.getItem(TargetType, TargetSlot);

            if (Source == null || Target == null)
                return;

            ItemData Data = ItemFactory.GetItemData(Source.ItemID);

            if (Data == null)
                return;

            if (Source.Spirit > Data.Spirit)
                Source.Spirit = Data.Spirit;

            Target.Spirit += Source.Spirit;
            chr.Items.Remove(SourceType, SourceSlot);
            InventoryHandler.UpdateInventory(c, SourceType);
        }

        public static void EquipmentCompound(InPacket lea, Client c)
        {
            byte SourceType = lea.ReadByte();
            byte SourceSlot = lea.ReadByte();
            byte UseType = lea.ReadByte();
            byte UseSlot = lea.ReadByte();
            byte TargetType = lea.ReadByte();
            byte TargetSlot = lea.ReadByte();
            var chr = c.Character;
            Item Source = chr.Items.getItem(SourceType, SourceSlot);
            Item Use    = chr.Items.getItem(UseType,    UseSlot);
            Item Target = chr.Items.getItem(TargetType, TargetSlot);
            ItemData Data = ItemFactory.GetItemData(Source.ItemID);

            if (Source == null || Use == null || Target == null || Data == null)
                return;

            int rnd = Randomizer.Next(1, Data.Spirit);

            if (rnd < Source.Spirit || (Use.ItemID == 8844011 && (rnd < Source.Spirit * 2)) || (Use.ItemID == 8844012 && (rnd < Source.Spirit * 2)))
            {
                switch (Source.ItemID)
                {
                    case 8510011:
                        Target.Level10++;
                        break;
                    case 8510021:
                        Target.Level9++;
                        break;
                    case 8510031:
                        Target.Level8++;
                        break;
                    case 8510041:
                        Target.Level7++;
                        break;
                    case 8510051:
                        Target.Level6++;
                        break;
                    case 8510061:
                        Target.Level5++;
                        break;
                    case 8510071:
                        Target.Level4++;
                        break;
                    case 8510081:
                        Target.Level3++;
                        break;
                    case 8510091:
                        Target.Level2++;
                        break;
                    case 8510101:
                        Target.Level1++;
                        break; ;
                }
            }
            Target.Fusion++;
            chr.Items.Remove(SourceType, SourceSlot);
            chr.Items.Remove(UseType, UseSlot, 1);
            InventoryHandler.UpdateInventory(c, SourceType);
            InventoryHandler.UpdateInventory(c, TargetType);
            InventoryHandler.UpdateInventory(c, UseType);
        }
    }
}
