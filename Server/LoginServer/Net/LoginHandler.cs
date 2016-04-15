using Server.Common.IO.Packet;
using Server.Common;
using Server.Accounts;
using Server.Interoperability;
using System.Collections.Generic;
using System;

namespace Server.Net
{
    public static class LoginHandler
    {
        public static void Login_Req(InPacket lea, Client c)
        {
            string username = lea.ReadString();
            string password = lea.ReadString();
            short key = lea.ReadShort();

            if (username.IsAlphaNumeric() == false)
            {
                LoginPacket.Login_Ack(c, ServerState.LoginState.NO_USERNAME);
                return;
            }

            c.SetAccount(new Account(c));

            try
            {
                c.Account.Load(username);
                //var pe = new PasswordEncrypt(key);
                //string encryptPassword = pe.encrypt(c.Account.Password);
                if (password != c.Account.Password)
                {
                    LoginPacket.Login_Ack(c, ServerState.LoginState.PASSWORD_ERROR);
                }
                else 
                if (c.Account.Banned > 0)
                {
                    LoginPacket.Login_Ack(c, ServerState.LoginState.USER_LOCK);
                }
                else
                {
                    if (c.Account.Master > 0)
                    {
                        LoginPacket.Login_Ack(c, ServerState.LoginState.OK, key, true);
                    }
                    else
                    {
                        LoginPacket.Login_Ack(c, ServerState.LoginState.OK, key, false);
                    }
                    c.Account.LoggedIn = 1;
                }
            }
            catch (NoAccountException)
            {
                if (false)
                {
                    // TODO: Auto registration.
                }
                else
                {
                    LoginPacket.Login_Ack(c, ServerState.LoginState.NO_USERNAME);
                }
            }
        }

        public static void ServerList_Req(InPacket lea, Client c)
        {
            LoginPacket.ServerList_Ack(c);
        }

        public static void Game_Req(InPacket lea, Client c)
        {
            LoginPacket.Game_Ack(c, ServerState.ChannelState.OK);
        }
    }
}
