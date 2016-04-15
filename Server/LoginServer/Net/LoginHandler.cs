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

            if (username.IsAlphaNumeric() == false)
            {
                LoginPacket.Login_Ack(c, ServerState.LoginState.NO_USERNAME, false);
                return;
            }

            c.SetAccount(new Account(c));

            try
            {
                c.Account.Load(username);

                byte[] pass = new byte[0x40];


                if (password != c.Account.Password)
                {
                    LoginPacket.Login_Ack(c, ServerState.LoginState.PASSWORD_ERROR, false);
                }
                else if (c.Account.Banned > 0)
                {
                    LoginPacket.Login_Ack(c, ServerState.LoginState.USER_LOCK, false);
                }
                else
                {
                    if (c.Account.Master > 0)
                    {
                        LoginPacket.Login_Ack(c, ServerState.LoginState.OK, true);
                    }
                    else
                    {
                        LoginPacket.Login_Ack(c, ServerState.LoginState.OK, false);
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
                    LoginPacket.Login_Ack(c, ServerState.LoginState.NO_USERNAME, false);
                }
            }
        }

        private static unsafe char* sub_422820(char[] a1, uint a2)
        {
            int v2; // esi@1
            int* v3; // eax@1
            int* v4; // edx@1
            char v5; // cl@2
            long v6; // ebx@3
            int* v7; // edi@4
            uint v8; // eax@5

            v2 = 0;
            char* unk_1BB9F60;
            v3 = a1;
            v4 = a1 + 1;
            do
                v5 = (char)*v3++;
            while (v5 == 0);
            v6 = v3 - v4;
            if (v3 - v4 > 0)
            {
                v7 = unk_1BB9F60;
                do
                {
                    var aa = (a2 + *(v2 + a1));
                    v8 = sub_4223F0((uint)aa, 1);
                    sub_422720(v8, v7);
                    v2 += 4;
                    v7 += 7;
                }
                while (v2 < v6);
            }
            return unk_1BB9F60;
        }

        private static unsafe uint sub_4223F0(uint a1, int a2)
        {
            uint v2; // esi@1
            int result; // eax@1
            int v4; // edi@2
            uint v5; // edx@3
            int v6; // ecx@5
            int v7; // [sp+Ch] [bp-100h]@1
            int v8; // [sp+10h] [bp-FCh]@1
            int v9; // [sp+14h] [bp-F8h]@1
            int v10; // [sp+18h] [bp-F4h]@1
            int v11; // [sp+1Ch] [bp-F0h]@1
            int v12; // [sp+20h] [bp-ECh]@1
            int v13; // [sp+24h] [bp-E8h]@1
            int v14; // [sp+28h] [bp-E4h]@1
            int v15; // [sp+2Ch] [bp-E0h]@1
            int v16; // [sp+30h] [bp-DCh]@1
            int v17; // [sp+34h] [bp-D8h]@1
            int v18; // [sp+38h] [bp-D4h]@1
            int v19; // [sp+3Ch] [bp-D0h]@1
            int v20; // [sp+40h] [bp-CCh]@1
            int v21; // [sp+44h] [bp-C8h]@1
            int v22; // [sp+48h] [bp-C4h]@1
            int v23; // [sp+4Ch] [bp-C0h]@1
            int v24; // [sp+50h] [bp-BCh]@1
            int v25; // [sp+54h] [bp-B8h]@1
            int v26; // [sp+58h] [bp-B4h]@1
            int v27; // [sp+5Ch] [bp-B0h]@1
            int v28; // [sp+60h] [bp-ACh]@1
            int v29; // [sp+64h] [bp-A8h]@1
            int v30; // [sp+68h] [bp-A4h]@1
            int v31; // [sp+6Ch] [bp-A0h]@1
            int v32; // [sp+70h] [bp-9Ch]@1
            int v33; // [sp+74h] [bp-98h]@1
            int v34; // [sp+78h] [bp-94h]@1
            int v35; // [sp+7Ch] [bp-90h]@1
            int v36; // [sp+80h] [bp-8Ch]@1
            int v37; // [sp+84h] [bp-88h]@1
            int v38; // [sp+88h] [bp-84h]@1
            int v39; // [sp+8Ch] [bp-80h]@1
            int v40; // [sp+90h] [bp-7Ch]@1
            int v41; // [sp+94h] [bp-78h]@1
            int v42; // [sp+98h] [bp-74h]@1
            int v43; // [sp+9Ch] [bp-70h]@1
            int v44; // [sp+A0h] [bp-6Ch]@1
            int v45; // [sp+A4h] [bp-68h]@1
            int v46; // [sp+A8h] [bp-64h]@1
            int v47; // [sp+ACh] [bp-60h]@1
            int v48; // [sp+B0h] [bp-5Ch]@1
            int v49; // [sp+B4h] [bp-58h]@1
            int v50; // [sp+B8h] [bp-54h]@1
            int v51; // [sp+BCh] [bp-50h]@1
            int v52; // [sp+C0h] [bp-4Ch]@1
            int v53; // [sp+C4h] [bp-48h]@1
            int v54; // [sp+C8h] [bp-44h]@1
            int v55; // [sp+CCh] [bp-40h]@1
            int v56; // [sp+D0h] [bp-3Ch]@1
            int v57; // [sp+D4h] [bp-38h]@1
            int v58; // [sp+D8h] [bp-34h]@1
            int v59; // [sp+DCh] [bp-30h]@1
            int v60; // [sp+E0h] [bp-2Ch]@1
            int v61; // [sp+E4h] [bp-28h]@1
            int v62; // [sp+E8h] [bp-24h]@1
            int v63; // [sp+ECh] [bp-20h]@1
            int v64; // [sp+F0h] [bp-1Ch]@1
            int v65; // [sp+F4h] [bp-18h]@1
            int v66; // [sp+F8h] [bp-14h]@1
            int v67; // [sp+FCh] [bp-10h]@1
            int v68; // [sp+100h] [bp-Ch]@1
            int v69; // [sp+104h] [bp-8h]@1
            int v70; // [sp+108h] [bp-4h]@1

            v35 = 22;
            v45 = 22;
            v2 = a1;
            v38 = 5;
            v55 = 5;
            result = 0;
            v7 = 26;
            v8 = 31;
            v9 = 17;
            v10 = 10;
            v11 = 30;
            v12 = 16;
            v13 = 24;
            v14 = 2;
            v15 = 29;
            v16 = 8;
            v17 = 20;
            v18 = 15;
            v19 = 28;
            v20 = 11;
            v21 = 13;
            v22 = 4;
            v23 = 19;
            v24 = 23;
            v25 = 0;
            v26 = 12;
            v27 = 14;
            v28 = 27;
            v29 = 6;
            v30 = 18;
            v31 = 21;
            v32 = 3;
            v33 = 9;
            v34 = 7;
            v36 = 1;
            v37 = 25;
            v39 = 18;
            v40 = 29;
            v41 = 7;
            v42 = 25;
            v43 = 15;
            v44 = 31;
            v46 = 27;
            v47 = 9;
            v48 = 26;
            v49 = 3;
            v50 = 13;
            v51 = 19;
            v52 = 14;
            v53 = 20;
            v54 = 11;
            v56 = 2;
            v57 = 23;
            v58 = 16;
            v59 = 10;
            v60 = 24;
            v61 = 28;
            v62 = 17;
            v63 = 6;
            v64 = 30;
            v65 = 0;
            v66 = 21;
            v67 = 12;
            v68 = 8;
            v69 = 4;
            v70 = 1;
            if (a1 > 0)
            {
                v4 = 0;
                do
                {
                    v5 = v2 - (v2 & 0xFFFFFFFE);
                    v2 >>= 1;
                    if (v5 > 0)
                    {
                        if (a2 > 0)
                            v6 = *(&v7 + v4);
                        else
                            v6 = *(&v39 + v4);
                        result += (int)v5 << v6;
                    }
                    v4 += 4;
                }
                while (v2 == 0);
            }
            return (uint)result;
        }

        private static unsafe void sub_422720(uint a1, int *a2)
        {
            uint v2;
            uint v3;
            uint v4;
            uint v5;
            char result;
            var v7 = new char[40];
            "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".CopyTo(0, v7, 0, 36);
            *a2 = v7[a1 % 0x24];
            v2 = a1 / 0x24 / 0x24;
            *(a2 + 1) = v7[a1 / 0x24 % 0x24];
            v3 = v2;
            v2 /= 0x24;
            *(a2 + 2) = v7[v3 - 36 * v2];
            v4 = v2;
            v2 /= 0x24;
            *(a2 + 3) = v7[v4 - 36 * v2];
            v5 = v2;
            v2 /= 0x24;
            *(a2 + 4) = v7[v5 - 36 * v2];
            *(a2 + 5) = v7[v2 % 0x24];
            result = v7[v2 / 0x24 % 0x24];
            *(a2 + 6) = result;
            *(a2 + 7) = (char)0;
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
