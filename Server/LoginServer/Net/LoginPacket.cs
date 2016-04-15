using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Interoperability;

namespace Server.Net
{
    public static class LoginPacket
    {
        /* NetCafe
         * 會員於特約網咖連線
         */
        public static void Login_Ack(Client c, ServerState.LoginState state, bool NetCafe)
        {
            using (var plew = new OutPacket(ServerMessage.LOGIN_ACK))
            {
                plew.WriteByte((byte) state);
                plew.WriteBool(NetCafe);
                plew.WriteShort(0);

                c.Send(plew);
            }
        }

        public static void ServerList_Ack(Client c)
        {
            using (var plew = new OutPacket(ServerMessage.SERVERLIST_ACK))
            {
                foreach (World world in LoginServer.Worlds)
                {
                    for (int i = 0; i < 13; i++)
                    {
                        plew.WriteByte(0xFF);
                    }
                    plew.WriteInt(LoginServer.Worlds.Count); // 伺服器數量
                    plew.WriteShort(world.ID); // 伺服器順序
                    plew.WriteInt(world.Games); // 頻道數量

                    int id = 0;
                    foreach (InteroperabilityClient game in world)
                    {
                        if (id >= 18)
                            break;
                        plew.WriteShort((short)game.ExternalID);
                        plew.WriteShort((short)game.ExternalID);
                        plew.WriteString("127.0.0.1");
                        plew.WriteInt(14101 + game.ExternalID);
                        plew.WriteInt(game.LoadProportionPool.Count); // 玩家數量
                        plew.WriteInt(1200); // 頻道人數上限
                        plew.WriteInt((int) world.Flag); // 標章類型
                        plew.WriteInt(0);
                        plew.WriteByte((byte)(game.LoadProportionPool.Count != 0 ? 1 : 2));
                        plew.WriteInt(14199);
                        id++;
                        if (id < 18)
                        {
                            plew.WriteShort((short)(id + 1));
                            plew.WriteShort((short)(id + 1));
                            plew.WriteString("127.0.0.1");
                            plew.WriteInt(14101 + (id + 1));
                            plew.WriteInt(1); // 玩家數量
                            plew.WriteInt(1200); // 頻道人數上限
                            plew.WriteInt((int)world.Flag); // 標章類型
                            plew.WriteInt(0);
                            plew.WriteByte((byte) 2);
                            plew.WriteInt(14199);
                        }
                    }
                }

                c.Send(plew);
            }
        }

        public static void Game_Ack(Client c, ServerState.ChannelState state)
        {
            using (var plew = new OutPacket(ServerMessage.GAME_ACK))
            {
                plew.WriteByte((byte)state);
                plew.WriteString("127.0.0.1");
                plew.WriteInt(14101 + c.World.ID);
                plew.WriteInt(14199);

                c.Send(plew);
            }
        }
    }
}
