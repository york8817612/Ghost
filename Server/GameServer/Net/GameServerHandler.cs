using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Handler;

namespace Server.Net
{
    public static class GameServerHandler
    {
        public static void ServerHandlerReceive(InPacket ip, Client gc)
        {
            var Header = ip.ReadShort(); // 讀取包頭
            ip.ReadInt(); // 原始長度 + CRC
            ip.ReadInt();

            Log.Hex("Received {0}({1}) packet from {2}: ", ip.Array, ((ClientOpcode)Header).ToString(), Header, gc.Title);

            switch ((ClientOpcode)Header)
            {
                // Game
                case ClientOpcode.COMMAND_REQ:
                    GameHandler.Command_Req(ip, gc);
                    break;
                case ClientOpcode.GAMELOG_REQ:
                    GameHandler.Game_Log_Req(ip, gc);
                    break;
                case ClientOpcode.QUICK_SLOT_REQ:
                    GameHandler.Quick_Slot_Req(ip, gc);
                    break;
                // Shop
                case ClientOpcode.NPC_SHOP_BUY_REQ:
                    NpcShopHandler.Buy_Req(ip, gc);
                    break;
                case ClientOpcode.NPC_SHOP_SELL_REQ:
                    NpcShopHandler.Sell_Req(ip, gc);
                    break;
                // Status
                case ClientOpcode.CHAR_DAMAGE_REQ:
                    StatusHandler.Char_Damage_Req(ip, gc);
                    break;
                case ClientOpcode.CHAR_DEAD_REQ:
                    StatusHandler.Char_Dead_Req(ip, gc);
                    break;
                case ClientOpcode.CHAR_STATUP_REQ:
                    StatusHandler.Char_Statup_Req(ip, gc);
                    break;
                case ClientOpcode.CHAR_FURY:
                    StatusHandler.Char_Fury_Req(ip, gc);
                    break;
                // Inventory
                case ClientOpcode.MOVE_ITEM_REQ:
                    InventoryHandler.MoveItem_Req(ip, gc);
                    break;
                case ClientOpcode.INVEN_SELECTSLOT_REQ:
                    InventoryHandler.SelectSlot_Req(ip, gc);
                    break;
                case ClientOpcode.USE_SPEND_REQ:
                    InventoryHandler.UseSpend_Req(ip, gc);
                    break;
                case ClientOpcode.INVEN_USESPEND_REQ:
                    InventoryHandler.InvenUseSpendStart_Req(ip, gc);
                    break;
                case ClientOpcode.INVEN_USESPEND_SHOUT_REQ:
                case ClientOpcode.INVEN_USESPEND_SHOUT_ALL_REQ:
                    InventoryHandler.InvenUseSpendShout_Req(ip, gc);
                    break;
                case ClientOpcode.PICKUP_ITEM:
                    InventoryHandler.PickupItem(ip, gc);
                    break;
                // Skill
                case ClientOpcode.SKILL_LEVELUP_REQ:
                    SkillHandler.SkillLevelUp_Req(ip, gc);
                    break;
                case ClientOpcode.USE_SKILL_REQ:
                    SkillHandler.UseSkill_Req(ip, gc);
                    break;
                // Quest
                case ClientOpcode.QUEST_ALL_REQ:
                    QuestHandler.Quest_All_Req(ip, gc);
                    break;
                case ClientOpcode.QUEST_GIVEUP_REQ:
                    QuestHandler.Quest_GiveUp_Req(ip, gc);
                    break;
                case ClientOpcode.QUEST_DONE_REQ:
                    QuestHandler.Quest_Done_Req(ip, gc);
                    break;
                case ClientOpcode.QUEST_RETURN_REQ:
                    QuestHandler.Quest_Return_Req(ip, gc);
                    break;
                case ClientOpcode.QUEST_DONE2_REQ:
                    QuestHandler.Quest_Done2_Req(ip, gc);
                    break;
                case ClientOpcode.QUEST_UPDATE_REQ:
                    QuestHandler.Quest_Update_Req(ip, gc);
                    break;
                // Map
                case ClientOpcode.ENTER_WARP_ACK_REQ:
                    MapHandler.WarpToMap_Req(ip, gc);
                    break;
                case ClientOpcode.CAN_WARP_ACK_REQ:
                    MapHandler.WarpToMapAuth_Req(ip, gc);
                    break;
                // Monster
                case ClientOpcode.ATTACK_MONSTER_REQ:
                    MonsterHandler.AttackMonster_Req(ip, gc);
                    break;
                // Storage
                case ClientOpcode.MOVE_ITEM_STORAGE_REQ:
                    StorageHandler.MoveItemToStorage(ip, gc);
                    break;
                case ClientOpcode.MOVE_ITEM_TO_BAG_REQ:
                    StorageHandler.MoveItemToBag(ip, gc);
                    break;
                case ClientOpcode.SAVE_MONEY_REQ:
                    StorageHandler.SaveStorageMoney(ip, gc);
                    break;
                case ClientOpcode.GIVE_MONEY_REQ:
                    StorageHandler.GiveStorageMoney(ip, gc);
                    break;
                // Coupon
                case ClientOpcode.CASH_SN:
                    CouponHandler.Use_Coupon_Req(ip, gc);
                    break;
                // Action
                case ClientOpcode.P_WARP_C:
                    ActionHandler.p_Warp_c(ip, gc);
                    break;
                case ClientOpcode.P_MOVE_C:
                    ActionHandler.p_Move_c(ip, gc);
                    break;
                case ClientOpcode.P_JUMP_C:
                    ActionHandler.p_Jump_c(ip, gc);
                    break;
                case ClientOpcode.P_SPEED_C:
                    ActionHandler.p_Speed_c(ip, gc);
                    break;
                case ClientOpcode.P_ATTACK_C:
                    ActionHandler.p_Attack_c(ip, gc);
                    break;
                //case ClientOpcode.P_DAMAGE_C:
                //    ActionHandler.p_Damage_c(ip, gc);
                //    break;
                //case ClientOpcode.P_DEAD_C:
                //    ActionHandler.p_Dead_c(ip, gc);
                //    break;
                case ClientOpcode.P_MOVE_C_2:
                    ActionHandler.p_Move_c_2(ip, gc);
                    break;
                //case ClientOpcode.PET_MOVE_C:
                //    ActionHandler.Pet_Move_C(ip, gc);
                //    break;
                //case ClientOpcode.PET_ATTACK_C:
                //    ActionHandler.Pet_Attack_C(ip, gc);
                //    break;
                // Trade
                case ClientOpcode.TRADE_INVITE_REQ:
                    TradeHandler.TradeInvite(ip, gc);
                    break;
                case ClientOpcode.TRADE_INVITE_RESPONSE_REQ:
                    TradeHandler.TradeInviteResponses(ip, gc);
                    break;
                case ClientOpcode.TRADE_READY_REQ:
                    TradeHandler.TradeReady(ip, gc);
                    break;
                case ClientOpcode.TRADE_CONFIRM_REQ:
                    TradeHandler.TradeConfirm(ip, gc);
                    break;
                case ClientOpcode.TRADE_CANCEL_REQ:
                    TradeHandler.TradeCancel(ip, gc);
                    break;
                case ClientOpcode.TRADE_PUT_REQ:
                    TradeHandler.TradePutItem(ip, gc);
                    break;
                // Party
                case ClientOpcode.PARTY_INVITE_REQ:
                    PartyHandler.PartyInvite(ip, gc);
                    break;
                case ClientOpcode.PARTY_INVITE_RESPONSES_REQ:
                    PartyHandler.PartyInviteResponses(ip, gc);
                    break;
                case ClientOpcode.PARTY_LEAVE:
                    PartyHandler.PartyLeave(ip, gc);
                    break;
                // PvP
                case ClientOpcode.PVP_REQ:
                    PvPHandler.PvPInvite(ip, gc);
                    break;
                case ClientOpcode.PVP_ACK_REQ:
                    PvPHandler.PvPInviteResponses(ip, gc);
                    break;
                // PlayerShop
                case ClientOpcode.PSHOP_OPEN_REQ:
                    PlayerShopHandler.OpenShop_Req(ip, gc);
                    break;
                case ClientOpcode.PSHOP_SELLSTART_REQ:
                    PlayerShopHandler.SellStart_Req(ip, gc);
                    break;
                case ClientOpcode.PSHOP_SELLEND_REQ:
                    PlayerShopHandler.SellEnd_Req(ip, gc);
                    break;
                case ClientOpcode.PSHOP_INFO_REQ:
                    PlayerShopHandler.ShopInfo_Req(ip, gc);
                    break;
                case ClientOpcode.PSHOP_BUYACK_REQ:
                    PlayerShopHandler.Buy_Req(ip, gc);
                    break;
                // Fish
                case ClientOpcode.FISH_REQ:
                    FishHandler.Fish_Req(ip, gc);
                    break;
                // CashShop
                case ClientOpcode.CASHSHOP_LIST_REQ:
                    CashShopHandler.CashShopList_Req(ip, gc);
                    break;
                case ClientOpcode.CASH_MGAMECASH_REQ:
                    CashShopHandler.MgameCash_Req(ip, gc);
                    break;
                case ClientOpcode.CASH_BUY_REQ:
                    CashShopHandler.BuyCommodity_Req(ip, gc);
                    break;
                case ClientOpcode.CASH_GIFT_REQ:
                    CashShopHandler.Gifts_Req(ip, gc);
                    break;
                case ClientOpcode.CASH_TO_INVEN_REQ:
                    CashShopHandler.CommodityToInventory_Req(ip, gc);
                    break;
                case ClientOpcode.ABILITY_RECOVER_REQ:
                    CashShopHandler.AbilityRecover_Req(ip, gc);
                    break;
                case ClientOpcode.CASH_CHECKCHARNAME_REQ:
                    CashShopHandler.CheckName_Req(ip, gc);
                    break;
                case ClientOpcode.DISMANTLE_REQ:
                    CashShopHandler.Dismantle_Req(ip, gc);
                    break;
                // Pet
                case ClientOpcode.PET_NAME_REQ:
                    PetHandler.Pet_Name_Req(ip, gc);
                    break;
                case ClientOpcode.SPIRIT_MOVE_REQ:
                    SpiritHandler.SpiritMove(ip, gc);
                    break;
                case ClientOpcode.EQUIPMENT_COMPOUND_REQ:
                    SpiritHandler.EquipmentCompound(ip, gc);
                    break;
                case ClientOpcode.EVENTITEM_ACK:
                    TradeHandler.TradeEventItem(ip, gc);
                    break;
            }
        }
    }
}
