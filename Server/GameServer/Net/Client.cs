using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Common.Security;
using Server.Common.Utilities;
using Server.Ghost;
using Server.Ghost.Accounts;
using Server.Ghost.Characters;
using Server.Ghost.Provider;
using Server.Packet;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using static Server.Common.Constants.ServerUtilities;

namespace Server.Net
{
    public sealed class Client : Session
    {
        public Account Account { get; private set; }
        public Character Character { get; private set; }
        public int CharacterID = 1;
        public static List<int> CharacterID_List = new List<int>();
        public long SessionID { get; private set; }
        public int RetryLoginCount { get; set; }

        public Client(Socket socket, UdpClient udp) : base(socket, udp) { }

        protected override void Register()
        {
            this.RetryLoginCount = 0;
            GameServer.Clients.Add(this);
            for (int i = 1; i < 3000; i++)
            {
                if (!CharacterID_List.Contains(i))
                {
                    this.CharacterID = i;
                    CharacterID_List.Add(this.CharacterID);
                    break;
                }
            }
            this.SessionID = Randomizer.NextLong();
            GamePacket.Game_Log_Ack(this, this.CharacterID);
            Log.Inform("Accepted connection from {0}.", this.Title);
        }

        protected override void Unregister()
        {
            try
            {
                if (this.Character != null)
                {
                    if (this.Character.IsFuring)
                    {
                        this.Character.MaxAttack -= this.Character.FuryAttack;
                        this.Character.Attack -= this.Character.FuryAttack;
                        this.Character.MaxMagic -= this.Character.FuryMagic;
                        this.Character.Magic -= this.Character.FuryMagic;
                        this.Character.Defense -= this.Character.FuryDefense;
                    }
                    this.Character.CancelSkill();

                    CharacterID_List.Remove(this.Character.CharacterID);

                    Map Map = MapFactory.GetMap(this.Character.MapX, this.Character.MapY);

                    Character find = null;
                    foreach (Character findCharacter in MapFactory.AllCharacters)
                    {
                        if (this.Character.CharacterID == findCharacter.CharacterID)
                        {
                            find = findCharacter;
                            break;
                        }
                    }
                    if (find != null)
                        MapFactory.AllCharacters.Remove(find);

                    Character find2 = null;
                    foreach (Character findCharacter in Map.Characters)
                    {
                        if (this.Character.CharacterID == findCharacter.CharacterID)
                        {
                            find2 = findCharacter;
                            break;
                        }
                    }
                    if (find2 != null)
                    {
                        Map.Characters.Remove(find2);
                        foreach (Character All in Map.Characters)
                            MapPacket.removeUser(All.Client, this.Character.CharacterID);
                    }

                    this.Account.Save();
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
                    GameServerHandler.ServerHandlerReceive(ip, this);
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
