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
                // State
                case ClientOpcode.CHAR_STATUP_REQ:
                    StatusHandler.Char_Statup_Req(ip, gc);
                    break;
                // Inventory
                case ClientOpcode.MOVE_ITEM_REQ:
                    InventoryHandler.MoveItem_Req(ip, gc);
                    break;
                case ClientOpcode.USE_SPEND_REQ:
                    InventoryHandler.UseSpend_Req(ip, gc);
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
                case ClientOpcode.MOVE_ITEM_STORAGE:
                    break;
                case ClientOpcode.SAVE_MONEY:
                    StorageHandler.saveStorageMoney(ip, gc);
                    break;
                case ClientOpcode.GIVE_MONEY:
                    StorageHandler.giveStorageMoney(ip, gc);
                    break;
                // Coupon
                case ClientOpcode.CASH_SN:
                    CouponHandler.Use_Coupon_Req(ip, gc);
                    break;
                // Action
                case ClientOpcode.P_MOVE_C:
                    ActionHandler.p_Move_c(ip, gc);
                    break;
                case ClientOpcode.P_JUMP_C:
                    ActionHandler.p_Jump_c(ip, gc);
                    break;
                case ClientOpcode.P_SPEED_C:
                    ActionHandler.p_Speed_c(ip, gc);
                    break;
                case ClientOpcode.P_MOVE:
                    ActionHandler.p_Move(ip, gc);
                    break;
            }
        }
    }
}
