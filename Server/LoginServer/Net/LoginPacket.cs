using Server.Common.Constants;
using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Interoperability;

namespace Server.Ghost
{
    public static class LoginPacket
    {
        /* NetCafe
         * 會員於特約網咖連線
         */
        public static void Login_Ack(Client c, ServerState.LoginState state, short encryptKey = 0, bool netCafe = false)
        {
            using (var plew = new OutPacket(LoginServerOpcode.LOGIN_ACK))
            {
                plew.WriteByte((byte)state);
                plew.WriteBool(netCafe);
                plew.WriteShort(encryptKey);

                c.Send(plew);
            }
        }

        public static void ServerList_Ack(Client c)
        {
            using (var plew = new OutPacket(LoginServerOpcode.SERVERLIST_ACK))
            {
                for (int i = 0; i < 13; i++)
                {
                    plew.WriteByte(0xFF);
                }
                plew.WriteInt(LoginServer.Worlds.Count); // 伺服器數量
                foreach (World world in LoginServer.Worlds)
                {
                    plew.WriteShort(world.ID); // 伺服器順序
                    plew.WriteInt(world.Channel); // 頻道數量

                    for (int i = 0; i < 18; i++)
                    {
                        plew.WriteShort(i + 1);
                        plew.WriteShort(i + 1);
                        plew.WriteString(ServerConstants.SERVER_IP);
                        plew.WriteInt(14101 + i);
                        plew.WriteInt(i < world.Count ? world[i].LoadProportion : 0); // 玩家數量
                        plew.WriteInt(ServerConstants.CHANNEL_LOAD); // 頻道人數上限
                        plew.WriteInt(12); // 標章類型
                        plew.WriteInt(0);
                        plew.WriteByte(i < world.Count ? 1 : 2);
                        plew.WriteInt(14199);
                    }
                }

                c.Send(plew);
            }
        }

        public static void Game_Ack(Client c, ServerState.ChannelState state)
        {
            using (var plew = new OutPacket(LoginServerOpcode.GAME_ACK))
            {
                plew.WriteByte((byte)state);
                plew.WriteString(ServerConstants.SERVER_IP);
                plew.WriteInt(14101 + c.World.ID);
                plew.WriteInt(14199);

                c.Send(plew);
            }
        }
    }
}
