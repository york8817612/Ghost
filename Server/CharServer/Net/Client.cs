using Server.Interoperability;
using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Utilities;
using Server.Common.Net;
using Server.Characters;
using System;
using System.Net.Sockets;

namespace Server.Net
{
    public sealed class Client : Session
    {
        public Client(Socket socket) : base(socket) { }

        protected override void Register()
        {
            CharServer.Clients.Add(this);
        }


        protected override void Unregister()
        {
            // TODO: Save character.
            CharServer.Clients.Remove(this);
        }

        protected bool IsServerAlive
        {
            get
            {
                return CharServer.IsAlive;
            }
        }

        protected override void Dispatch(InPacket inPacket)
        {
            try
            {
                switch ((ClientMessage)inPacket.OperationCode)
                {

                }
            }
            catch (HackException e)
            {
                // TODO: Register offense using the exception's message.
            }
            catch (Exception e)
            {
                Log.Error("Unhandled exception from {0}: \n{1}", this.Title, e.ToString());
            }
        }
    }
}
