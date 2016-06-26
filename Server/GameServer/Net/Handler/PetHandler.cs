using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Ghost;
using Server.Net;
using Server.Packet;

namespace Server.Handler
{
    public class PetHandler
    {
        public static void Pet_Name_Req(InPacket lea, Client c)
        {
            string Name = lea.ReadString(20);
            int Slot = lea.ReadInt();
            var chr = c.Character;
            Pet Pet = chr.Pets.Pet((byte)InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Pet);
            Pet Item = chr.Pets.Pet((byte)InventoryType.ItemType.Pet5, (byte)Slot);
            Pet.Name = Name;
            Pet.Save();
            chr.Pets.Remove((byte)InventoryType.ItemType.Pet5, (byte)Slot);
            //PetPacket.PetName(c, Name);
            MapPacket.warpToMap(c, chr, chr.CharacterID, chr.MapX, chr.MapY, chr.PlayerX, chr.PlayerY); // 先以此代替
            InventoryHandler.UpdateInventory(c, (byte)InventoryType.ItemType.Pet5);
        }
    }
}
