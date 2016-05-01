using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Common.Security;
using Server.Common.Utilities;
using Server.Ghost.Accounts;
using Server.Ghost.Characters;
using Server.Handler;
using System;
using System.Net.Sockets;
using static Server.Common.Constants.ServerUtilities;

namespace Server.Ghost
{
    public sealed class Client : Session
    {
        public Account Account { get; private set; }
        public Character Character { get; private set; }
        public int CharacterID { get; private set; }
        public long SessionID { get; private set; }

        public Client(Socket socket) : base(socket) { }

        protected override void Register()
        {
            GameServer.Clients.Add(this);
            this.CharacterID = GameServer.Clients.Count;
            this.SessionID = Randomizer.NextLong();
            GamePacket.Game_Log_Ack(this, CharacterID);
            Log.Inform("Accepted connection from {0}.", this.Title);
        }

        protected override void Unregister()
        {
            try
            {
                if (this.Character != null)
                {
                    this.Character.Save();
                }

                GameServer.Clients.Remove(this);

                Log.Inform("Lost connection from {0}.", this.Title);
            }
            catch (Exception e)
            {
                Log.Error("Unregister exception from {0}: \n{1}", this.Title, e.ToString());
            }
        }

        protected override void Dispatch(InPacket inPacket)
        {
            try
            {
                //Log.Hex("Received packet from {0}: ", inPacket.Array, this.Title);
                PacketCrypt pd = new PacketCrypt(SessionID);

                byte[] ii;
                if (inPacket.Array[0] == 0x4D && inPacket.Array[1] == 0x0)
                {
                    ii = inPacket.Array;
                }
                else {
                    ii = pd.Decrypt(inPacket.Array);
                }
                InPacket ip = new InPacket(ii);

                if (ip.OperationCode == (ushort)ClientOpcode.SERVER)
                {
                    var Header = ip.ReadShort(); // 讀取包頭
                    ip.ReadInt(); // 原始長度 + CRC
                    ip.ReadInt();

                    Log.Hex("Received {0}({1}) packet from {2}: ", ii, ((ClientOpcode)Header).ToString(), Header, this.Title);

                    switch ((ClientOpcode)Header)
                    {
                        // Game
                        case ClientOpcode.COMMAND_REQ:
                            GameHandler.Command_Req(ip, this);
                            break;
                        case ClientOpcode.GAMELOG_REQ:
                            GameHandler.Game_Log_Req(ip, this);
                            break;
                        // Inventory
                        case ClientOpcode.MOVE_ITEM_REQ:
                            InventoryHandler.MoveItem_Req(ip, this);
                            break;
                        case ClientOpcode.INVEN_USESPEND_SHOUT_REQ:
                        case ClientOpcode.INVEN_USESPEND_SHOUT_ALL_REQ:
                            InventoryHandler.InvenUseSpendShout_Req(ip, this);
                            break;
                        // Skill
                        case ClientOpcode.SKILL_LEVELUP_REQ:
                            SkillHandler.SkillLevelUp_Req(ip, this);
                            break;
                        // Map
                        case ClientOpcode.ENTER_WARP_ACK_REQ:
                            MapHandler.WarpToMap_Req(ip, this);
                            break;
                        case ClientOpcode.CAN_WARP_ACK_REQ:
                            MapHandler.WarpToMapAuth_Req(ip, this);
                            break;
                        // Monster
                        case ClientOpcode.ATTACK_MONSTER_REQ:
                            MonsterHandler.AttackMonster_Req(ip, this);
                            break;
                    }
                }
            }
            catch (HackException e)
            {
                if (this.Character != null)
                {
                    // TODO: Register offense points in the database (?).

                    //Log.Warn("Taking Hack Action of {0} against {1}: \n{2}", e.Action, this.Character.Name, e.Message);

                    switch (e.Action)
                    {
                        case HackAction.Disconnection:
                            {
                                this.Dispose();
                            }
                            break;

                        case HackAction.ThirthyDays:
                            {

                            }
                            break;

                        case HackAction.NinetyDays:
                            {

                            }
                            break;

                        case HackAction.Permanent:
                            {

                            }
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error("Unhandled Packet Exception from {0}: \n{1}", this.Title, e.ToString());
            }
        }

        public void SetAccount(Account Account)
        {
            this.Account = Account;
        }

        public void SetCharacter(Character Character)
        {
            this.Character = Character;
        }
    }
}
