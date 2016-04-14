using Server.Interoperability;
using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Accounts;
using Server.Common.Utilities;
using Server.Common.Net;
using System;
using System.Net.Sockets;

namespace Server.Net
{
    public sealed class Client : Session
    {
        public byte WorldID { get; private set; }
        public byte GameID { get; private set; }
        public Account Account { get; private set; }
        public string[] MacAddresses { get; private set; }
        public long SessionID { get; private set; }

        public World World
        {
            get
            {
                return LoginServer.Worlds[this.WorldID];
            }
            set
            {
                this.WorldID = value.ID;
            }
        }

        public InteroperabilityClient Game
        {
            get
            {
                return this.World[this.GameID];
            }
            set
            {
                this.GameID = value.InternalID;
            }
        }

        public Client(Socket socket)
            : base(socket)
        {
            this.SessionID = Randomizer.NextLong();
        }

        protected override void Register()
        {
            LoginServer.Clients.Add(this);

            Log.Inform("Accepted connection from {0}.", this.Title);
        }

        protected override void Unregister()
        {
            if (this.Account != null)
            {
                this.Account.LoggedIn = 0;

                this.Account.Save();
                this.Account.SaveHWID();
            }

            LoginServer.Clients.Remove(this);

            Log.Inform("Lost connection from {0}.", this.Title);
        }


        protected override void Dispatch(InPacket inPacket)
        {
            try
            {
                switch ((ClientMessage)inPacket.OperationCode)
                {
                    
                }
            }
            catch (Exception e)
            {
                Log.Error("Unhandled Packet Exception from {0}: \n{1}", this.Title, e.ToString());
            }
        }
    }
}