using Server.Ghost.Characters;
using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Net;
using System;
using System.Net.Sockets;
using static Server.Common.Constants.ServerUtilities;
using Server.Ghost.Accounts;
using Server.Common.Security;
using Server.Common.Utilities;
using Server.Common.Data;
using System.Collections.Generic;
using System.Net;

namespace Server.Net
{
    public sealed class Client : Session
    {
        public Account Account { get; private set; }
        public Character Character { get; private set; }
        public long SessionID { get; private set; }

        public Client(Socket socket) : base(socket) { }

        protected override void Register()
        {
            GameServer.Clients.Add(this);
            this.SessionID = Randomizer.NextLong();
            GamePacket.Game_Log_Ack(this, GameServer.Clients.Count);
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
                PacketDecrypt pd = new PacketDecrypt(1);
                byte[] ii = pd.Decrypt(inPacket.Array);
                Log.Hex("Received packet from {0}: ", ii, this.Title);

                if (ii[0] == (ushort)ClientMessage.GAME_SERVER)
                {
                    var ip = new InPacket(ii);
                    GameHandler.Game_Log_Req(ip, this);
                }

                //if (ip.OperationCode == (ushort)ClientMessage.SERVER)
                //{
                //    var hand = ip.ReadShort(); // 讀取包頭
                //    ip.ReadUShort(); // 原始長度
                //    if (this.Character != null)
                //    {
                //        switch ((ClientMessage)hand)
                //        {

                //        }
                //    }
                //    else
                //    {
                //        switch ((ClientMessage)hand)
                //        {

                //        }
                //    }
                //}
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
