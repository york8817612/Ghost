using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Ghost;
using Server.Ghost.Characters;
using Server.Net;
using System.Collections.Generic;

namespace Server.Packet
{
    public static class InventoryPacket
    {
        public static void clearDropItem(Client c, int cid, int oid, int iid)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.CLEAR_DROP_ITEM))
            {
                // 4D 00 4E 00 //  + 0
                plew.WriteInt(0); // length + CRC // + 4
                plew.WriteInt(0); // + 8
                plew.WriteInt(cid); // 角色 id // + 12
                plew.WriteInt(oid); // 掉落 id  // + 16
                plew.WriteInt(iid); // 物品 id // + 20
                plew.WriteHexString("00 01 FF FF"); // + 24

                c.Send(plew);
            }
        }

        public static void charDropItem(Client c, int oid, int iid, short posX, short posY, int quantity)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.CHAR_DROP_ITEM))
            {
                // 4D 00 4E 00 //  + 0
                plew.WriteInt(0); // length + CRC // + 4
                plew.WriteInt(0); // + 8
                plew.WriteInt(oid); // 掉落 id // + 12
                plew.WriteInt(iid); // 物品 id // + 16
                plew.WriteShort(posX); // pos x // + 20
                plew.WriteShort(posY); // pos y // + 22
                plew.WriteInt(0); // + 24
                plew.WriteInt(quantity); // 數量 + 28

                c.Send(plew);
            }
        }

        public static void getAvatar(Client c, Character chr)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.CHAR_SET_AVATAR))
            {
                Dictionary<InventoryType.EquipType, int> equip = getEquip(chr);
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(chr.CharacterID);
                plew.WriteInt(chr.Hair);
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Face) ? equip[InventoryType.EquipType.Face] : 0);  // 臉上
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Face2) ? equip[InventoryType.EquipType.Face2] : 0);// 臉下
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Hat) ? equip[InventoryType.EquipType.Hat] : 0);  // 帽子
                plew.WriteInt(chr.Eyes);                                                                              // 眼睛
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Outfit) ? equip[InventoryType.EquipType.Outfit] : 0);  // 衣服
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Dress) ? equip[InventoryType.EquipType.Dress] : 0);// 服裝
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Weapon) ? equip[InventoryType.EquipType.Weapon] : 0);  // 武器
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Mantle) ? equip[InventoryType.EquipType.Mantle] : 0);  // 披風
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Pet) ? equip[InventoryType.EquipType.Pet] : 0);// 靈物
                //plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.HairAcc) ? equip[InventoryType.EquipType.HairAcc] : 0);// HairAcc
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Toy) ? equip[InventoryType.EquipType.Toy] : 0);// 玩物

                // 寵物
                plew.WriteString(chr.Pets.Name((byte)InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Pet), 20); // PetName
                plew.WriteInt(chr.Pets.Level((byte)InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Pet)); // PetLevel
                plew.WriteInt(chr.Pets.Hp((byte)InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Pet)); // PetHP
                plew.WriteInt(chr.Pets.Mp((byte)InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Pet)); // PetMaxMP
                plew.WriteInt(chr.Pets.Exp((byte)InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Pet)); // PetExp
                plew.WriteInt(chr.Pets.DecorateID((byte)InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Pet)); // PetDeco
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Pet) ? chr.Pets.OriginalSlot((byte)InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Pet) : -1); // PetSlot
                // 玩物
                plew.WriteString("", 20); // ToyName
                plew.WriteInt(0); // ToyLevel
                plew.WriteInt(0); // ToyHP
                plew.WriteInt(0); // ToyMaxMP
                plew.WriteInt(0); // ToyExp

                //
                plew.WriteShort(0);
                plew.WriteShort(0);
                plew.WriteShort(0);
                plew.WriteByte(0);
                plew.WriteByte(0);

                c.Send(plew);
            }
        }

        public static void getCharacterEquip(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_ALL))
            {
                var chr = c.Character;
                Dictionary<InventoryType.EquipType, int> equip = getEquip(chr);
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Weapon) ? equip[InventoryType.EquipType.Weapon] : 0);    // 武器[Weapon] 8010101
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Outfit) ? equip[InventoryType.EquipType.Outfit] : 0);    // 衣服[Outfit] 8160351
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Ring) ? equip[InventoryType.EquipType.Ring] : 0);        // 戒指[Ring]
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Necklace) ? equip[InventoryType.EquipType.Necklace] : 0);// 項鍊[Necklace]
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Mantle) ? equip[InventoryType.EquipType.Mantle] : 0);    // 披風[Mantle]
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Seal) ? equip[InventoryType.EquipType.Seal] : 0);        // 封印物[Seal]
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Hat) ? equip[InventoryType.EquipType.Hat] : 0);          // 頭部[Hat]
                plew.WriteInt(chr.Hair);                                                                                         // 頭髮[Hair]
                plew.WriteInt(chr.Eyes);                                                                                         // 眼睛[Eyes]
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Face) ? equip[InventoryType.EquipType.Face] : 0);        // 臉上[Face]
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Pet) ? equip[InventoryType.EquipType.Pet] : 0);          // 靈物[Pet]
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Dress) ? equip[InventoryType.EquipType.Dress] : 0);      // 服裝[Dress]
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Face2) ? equip[InventoryType.EquipType.Face2] : 0);      // 臉下[Face2]
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Earing) ? equip[InventoryType.EquipType.Earing] : 0);    // 耳環[Earing]
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.HairAcc) ? equip[InventoryType.EquipType.HairAcc] : 0);  // [HairAcc] 
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Toy) ? equip[InventoryType.EquipType.Toy] : 0);          // 玩物[Toy]
                plew.WriteHexString("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");
                plew.WriteInt(chr.Money);
                plew.WriteInt(0);
                plew.WriteByte(0);

                c.Send(plew);
            }
        }

        public static void getInvenEquip(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_EQUIP))
            {
                var chr = c.Character;
                Dictionary<InventoryType.EquipType, int> equip = getEquip(chr);
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Weapon) ? equip[InventoryType.EquipType.Weapon] : 0);    // 武器[Weapon] 8010101
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Outfit) ? equip[InventoryType.EquipType.Outfit] : 0);    // 衣服[Outfit] 8160351
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Ring) ? equip[InventoryType.EquipType.Ring] : 0);        // 戒指[Ring]
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Necklace) ? equip[InventoryType.EquipType.Necklace] : 0);// 項鍊[Necklace]
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Mantle) ? equip[InventoryType.EquipType.Mantle] : 0);    // 披風[Mantle]
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Seal) ? equip[InventoryType.EquipType.Seal] : 0);        // 封印物[Seal]
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Hat) ? equip[InventoryType.EquipType.Hat] : 0);          // 頭部[Hat]
                plew.WriteInt(chr.Hair);                                                                                         // 頭髮[Hair]
                plew.WriteInt(chr.Eyes);                                                                                         // 眼睛[Eyes]
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Face) ? equip[InventoryType.EquipType.Face] : 0);        // 臉上[Face]
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Pet) ? equip[InventoryType.EquipType.Pet] : 0);          // 靈物[Pet]
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Dress) ? equip[InventoryType.EquipType.Dress] : 0);      // 服裝[Dress]
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Face2) ? equip[InventoryType.EquipType.Face2] : 0);      // 臉下[Face2]
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Earing) ? equip[InventoryType.EquipType.Earing] : 0);    // 耳環[Earing]
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.HairAcc) ? equip[InventoryType.EquipType.HairAcc] : 0);  // [HairAcc] 
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Toy) ? equip[InventoryType.EquipType.Toy] : 0);          // 玩物[Toy]
                plew.WriteInt(0); // 16
                plew.WriteInt(0); // 17
                plew.WriteInt(0); // 18
                plew.WriteInt(0); // 19
                plew.WriteInt(0); // 20
                plew.WriteInt(0); // 21

                for (int i = 0; i < 17; i++)
                {
                    plew.WriteByte(0);
                    plew.WriteByte(0);
                    plew.WriteByte(0);
                    plew.WriteByte(0);
                    plew.WriteByte(0);
                    plew.WriteByte(0);
                    plew.WriteByte(0);
                    plew.WriteByte(0);
                    plew.WriteByte(0);
                    plew.WriteByte(0);
                }

                for (int i = 0; i < 17; i++)
                {   // 封印量
                    plew.WriteShort(0);
                }

                for (int i = 0; i < 17; i++)
                {
                    plew.WriteInt(0);
                }

                for (int i = 0; i < 17; i++)
                {
                    plew.WriteHexString("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");
                }

                for (int i = 0; i < 17; i++)
                {
                    plew.WriteShort(0);
                }

                //寵物
                plew.WriteString(chr.Pets.Name((byte)InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Pet), 20); // PetName
                plew.WriteByte(chr.Pets.Level((byte)InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Pet)); // PetLevel
                plew.WriteByte(0);
                plew.WriteInt(chr.Pets.Hp((byte)InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Pet)); // PetHP
                plew.WriteInt(chr.Pets.Mp((byte)InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Pet));
                plew.WriteInt(chr.Pets.Exp((byte)InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Pet));
                plew.WriteInt(equip.ContainsKey(InventoryType.EquipType.Pet) ? chr.Pets.OriginalSlot((byte)InventoryType.ItemType.Equip, (byte)InventoryType.EquipType.Pet) : -1);
                plew.WriteInt(-1);
                plew.WriteInt(-1); // 寵物截止日期
                plew.WriteByte(0);

                // 玩物
                plew.WriteString("", 20); // ToyName
                plew.WriteByte(0);
                plew.WriteShort(0);
                plew.WriteInt(0);
                plew.WriteInt(0); // ToyHP
                plew.WriteInt(0);

                plew.WriteInt(-1); // 武器[Weapon]截止日期
                plew.WriteInt(-1); // 未知[]截止日期

                c.Send(plew);
            }
        }

        public static void getInvenEquip1(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_EQUIP1))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                for (byte i = 0; i < 24; i++)
                { // 物品編號
                    plew.WriteInt(chr.Items.GetItemID(InventoryType.ItemType.Equip1, i));
                }
                for (int i = 0; i < 24; i++)
                { // 
                    plew.WriteByte(0);
                }
                for (int i = 0; i < 24; i++)
                { // 
                    plew.WriteHexString("00 00 00 00 00 00 00 00 00 00");
                }
                for (int i = 0; i < 24; i++)
                { // 
                    plew.WriteShort(0);
                }
                for (byte i = 0; i < 24; i++)
                { // 物品Lock
                    plew.WriteByte(chr.Items.GetIsLocked(InventoryType.ItemType.Equip1, i));
                }
                for (byte i = 0; i < 24; i++)
                { // 截止日期
                    plew.WriteInt(chr.Items.GetTerm(InventoryType.ItemType.Equip1, i) == -1 ? 0 : chr.Items.GetTerm(InventoryType.ItemType.Equip1, i));
                }
                for (byte i = 0; i < 24; i++)
                { // 物品標誌
                    plew.WriteShort(chr.Items.GetIcon(InventoryType.ItemType.Equip1, i));
                }
                for (int i = 0; i < 24; i++)
                { // 480 Bytes
                    plew.WriteHexString("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");
                }
                c.Send(plew);
            }
        }

        public static void getInvenEquip2(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_EQUIP2))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                for (byte i = 0; i < 24; i++)
                { // 物品編號
                    plew.WriteInt(chr.Items.GetItemID(InventoryType.ItemType.Equip2, i));
                }
                for (int i = 0; i < 24; i++)
                { // 
                    plew.WriteByte(0);
                }
                for (int i = 0; i < 24; i++)
                { // 
                    plew.WriteHexString("00 00 00 00 00 00 00 00 00 00");
                }
                for (int i = 0; i < 24; i++)
                { // 封印量
                    plew.WriteShort(0);
                }
                for (byte i = 0; i < 24; i++)
                { // 物品Lock
                    plew.WriteByte(chr.Items.GetIsLocked(InventoryType.ItemType.Equip2, i));
                }
                for (byte i = 0; i < 24; i++)
                { // 截止日期
                    plew.WriteInt(chr.Items.GetTerm(InventoryType.ItemType.Equip2, i) == -1 ? 0 : chr.Items.GetTerm(InventoryType.ItemType.Equip2, i));
                }
                for (byte i = 0; i < 24; i++)
                { // 物品標誌
                    plew.WriteShort(chr.Items.GetIcon(InventoryType.ItemType.Equip2, i));
                }
                for (int i = 0; i < 24; i++)
                { // 480 Bytes
                    plew.WriteHexString("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");
                }
                c.Send(plew);
            }
        }

        public static void getInvenSpend3(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_SPEND3))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                for (byte i = 0; i < 24; i++)
                { // 物品編號
                    plew.WriteInt(chr.Items.GetItemID(InventoryType.ItemType.Spend3, i));
                }
                for (byte i = 0; i < 24; i++)
                { // 物品數量
                    plew.WriteShort(chr.Items.GetQuantity(InventoryType.ItemType.Spend3, i));
                }
                for (byte i = 0; i < 24; i++)
                { // 物品Lock
                    plew.WriteByte(chr.Items.GetIsLocked(InventoryType.ItemType.Spend3, i));
                }
                for (byte i = 0; i < 24; i++)
                { // 截止日期
                    plew.WriteInt(chr.Items.GetTerm(InventoryType.ItemType.Spend3, i) == -1 ? 0 : chr.Items.GetTerm(InventoryType.ItemType.Spend3, i));
                }
                plew.WriteByte(chr.UseSlot.Slot(InventoryType.ItemType.Spend3)); // 飛鏢使用欄位
                plew.WriteByte(0xFF);
                for (int i = 0; i < 24; i++)
                {
                    plew.WriteShort(0);
                }
                plew.WriteByte(0xFF);
                plew.WriteByte(0xFF);
                c.Send(plew);
            }
        }

        public static void getInvenOther4(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_OTHER4))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                for (byte i = 0; i < 24; i++)
                { // 物品編號
                    plew.WriteInt(chr.Items.GetItemID(InventoryType.ItemType.Other4, i));
                }
                for (byte i = 0; i < 24; i++)
                { // 物品數量
                    plew.WriteShort(chr.Items.GetQuantity(InventoryType.ItemType.Other4, i));
                }
                for (byte i = 0; i < 24; i++)
                { // 物品Lock
                    plew.WriteByte(chr.Items.GetIsLocked(InventoryType.ItemType.Other4, i));
                }
                for (byte i = 0; i < 24; i++)
                { // 截止日期
                    plew.WriteInt(chr.Items.GetTerm(InventoryType.ItemType.Other4, i));
                }
                for (byte i = 0; i < 24; i++)
                { // 物品Icon
                    plew.WriteShort(chr.Items.GetIcon(InventoryType.ItemType.Other4, i));
                }
                c.Send(plew);
            }
        }

        public static void getInvenPet5(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_PET5))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                for (byte i = 0; i < 24; i++)
                { // 寵物編號
                    plew.WriteInt(chr.Pets.ItemID((byte)InventoryType.ItemType.Pet5, i));
                }
                for (byte i = 0; i < 24; i++)
                { // 寵物名稱
                    plew.WriteString(chr.Pets.Name((byte)InventoryType.ItemType.Pet5, i), 20);
                }
                for (byte i = 0; i < 24; i++)
                { // 寵物等級
                    plew.WriteByte(chr.Pets.Level((byte)InventoryType.ItemType.Pet5, i));
                }
                for (byte i = 0; i < 24; i++)
                { // 寵物血量
                    plew.WriteInt(chr.Pets.Hp((byte)InventoryType.ItemType.Pet5, i));
                }
                for (byte i = 0; i < 24; i++)
                { // 寵物經驗值
                    plew.WriteInt(chr.Pets.Exp((byte)InventoryType.ItemType.Pet5, i));
                }
                for (int i = 0; i < 24; i++)
                { // 
                    plew.WriteInt(chr.Pets.Mp((byte)InventoryType.ItemType.Pet5, i));
                }
                for (int i = 0; i < 24; i++)
                { // 截止日期
                    plew.WriteInt(-1);
                }
                for (byte i = 0; i < 24; i++)
                { // 
                    plew.WriteShort(chr.Pets.ItemID((byte)InventoryType.ItemType.Pet5, i) == 0 ? 0 : 1);
                }
                for (int i = 0; i < 24; i++)
                { // 
                    plew.WriteInt(0);
                }
                for (int i = 0; i < 24; i++)
                { // 物品Lock
                    plew.WriteByte(0);
                }
                for (int i = 0; i < 24; i++)
                { // 
                    plew.WriteInt(0);
                }
                for (int i = 0; i < 24; i++)
                { // 物品Icon
                    plew.WriteShort(0);
                }

                c.Send(plew);
            }
        }

        public static void getInvenMoney(Client c, int money, int pickup)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_MONEY))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteLong(money);
                plew.WriteLong(pickup);

                c.Send(plew);
            }
        }

        public static void SelectSlot(Client c, int Slot)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_SELECTSLOT_ACK))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(Slot);
                c.Send(plew);
            }
        }

        public static void UseSpendStart(Client c, Character chr, short PositionX, short PositionY, int ItemID, int Type, int Slot)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_USESPEND_START))
            {
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                plew.WriteInt(chr.CharacterID);
                plew.WriteShort(PositionX);
                plew.WriteShort(PositionY);
                plew.WriteInt(ItemID);
                plew.WriteByte(Type);
                plew.WriteByte(Slot);
                plew.WriteShort(0);
                c.Send(plew);
            }
        }

        public static void getInvenCash(Client c)
        {
            using (OutPacket plew = new OutPacket(ServerOpcode.INVEN_CASH))
            {
                var chr = c.Character;
                plew.WriteInt(0); // length + CRC
                plew.WriteInt(0);
                for (byte i = 0; i < 20; i++)
                {
                    plew.WriteInt(chr.Items.GetItemID(InventoryType.ItemType.Cash, i)); // 物品ID
                }
                for (int i = 0; i < 20; i++)
                { // 剩餘合成回數
                    plew.WriteByte(0);
                }
                for (int i = 0; i < 20; i++)
                { // 
                    plew.WriteHexString("00 00 00 00 00 00 00 00 00 00");
                }
                for (int i = 0; i < 20; i++)
                { // 靈丹剩餘體力
                    plew.WriteInt(0);
                }
                for (byte i = 0; i < 20; i++)
                { // 數量
                    plew.WriteShort(chr.Items.GetQuantity(InventoryType.ItemType.Cash, i));
                }
                for (byte i = 0; i < 20; i++)
                { // 物品Lock
                    plew.WriteByte(chr.Items.GetIsLocked(InventoryType.ItemType.Cash, i));
                }
                for (byte i = 0; i < 20; i++)
                { // 截止日期
                    plew.WriteInt(chr.Items.GetTerm(InventoryType.ItemType.Cash, i) == -1 ? 0 : chr.Items.GetTerm(InventoryType.ItemType.Cash, i));
                }
                for (int i = 0; i < 20; i++)
                { // 400 Bytes
                    plew.WriteHexString("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");
                }
                c.Send(plew);
            }
        }

        public static Dictionary<InventoryType.EquipType, int> getEquip(Character chr)
        {
            Dictionary<InventoryType.EquipType, int> equip = new Dictionary<InventoryType.EquipType, int>();
            if (chr != null)
            {
                foreach (Item im in chr.Items)
                {
                    if (im.Type != (byte)InventoryType.ItemType.Equip)
                        continue;
                    switch (im.Slot)
                    {
                        case (byte)InventoryType.EquipType.Weapon:
                            equip.Add(InventoryType.EquipType.Weapon, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Outfit:
                            equip.Add(InventoryType.EquipType.Outfit, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Ring:
                            equip.Add(InventoryType.EquipType.Ring, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Necklace:
                            equip.Add(InventoryType.EquipType.Necklace, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Mantle:
                            equip.Add(InventoryType.EquipType.Mantle, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Seal:
                            equip.Add(InventoryType.EquipType.Seal, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Hat:
                            equip.Add(InventoryType.EquipType.Hat, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Hair:
                            equip.Add(InventoryType.EquipType.Hair, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Eyes:
                            equip.Add(InventoryType.EquipType.Eyes, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Face:
                            equip.Add(InventoryType.EquipType.Face, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Dress:
                            equip.Add(InventoryType.EquipType.Dress, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Face2:
                            equip.Add(InventoryType.EquipType.Face2, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Earing:
                            equip.Add(InventoryType.EquipType.Earing, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.HairAcc:
                            equip.Add(InventoryType.EquipType.HairAcc, im.ItemID);
                            break;
                        case (byte)InventoryType.EquipType.Toy:
                            equip.Add(InventoryType.EquipType.Toy, im.ItemID);
                            break;
                    }
                }
                foreach (Pet Pet in chr.Pets)
                {
                    if (Pet.Type != (byte)InventoryType.ItemType.Equip)
                        continue;
                    switch (Pet.Slot)
                    {
                        case (byte)InventoryType.EquipType.Pet:
                            equip.Add(InventoryType.EquipType.Pet, Pet.ItemID);
                            break;
                    }
                }
                return equip;
            }
            return new Dictionary<InventoryType.EquipType, int>();
        }
    }
}
