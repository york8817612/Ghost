using Server.Common.IO.Packet;
using Server.Net;
using Server.Packet;

namespace Server.Handler
{
    public static class StorageHandler
    {
        public static void saveStorageMoney(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            int money = lea.ReadInt();
            int unk = lea.ReadInt();

            chr.Storages.getStorages()[0].Money += money;
            chr.Storages.getStorages()[0].Save();            
            chr.Money -= money;
            chr.Save();
            InventoryPacket.getInvenMoney(gc, chr.Money, -money);
            InventoryPacket.getStoreMoney(gc);
            
        }

        public static void giveStorageMoney(InPacket lea, Client gc)
        {
            var chr = gc.Character;
            int money = lea.ReadInt();
            int unk = lea.ReadInt();

            chr.Storages.getStorages()[0].Money -= money;
            chr.Storages.getStorages()[0].Save();            
            chr.Money += money;
            chr.Save();
            InventoryPacket.getInvenMoney(gc, chr.Money, money);
            InventoryPacket.getStoreMoney(gc);
            
        }
    }
}
