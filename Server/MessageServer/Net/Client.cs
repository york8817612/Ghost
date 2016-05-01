using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Net;
using System;
using System.Net.Sockets;

namespace Server.Ghost
{
    public sealed class Client : Session
    {
        public Client(Socket socket) : base(socket) { }

        protected override void Register()
        {
            MessageServer.Clients.Add(this);
        }


        protected override void Unregister()
        {
            // TODO: Save character.
            MessageServer.Clients.Remove(this);
        }

        protected bool IsServerAlive
        {
            get
            {
                return MessageServer.IsAlive;
            }
        }

        protected override void Dispatch(InPacket inPacket)
        {
            try
            {
                switch ((ClientOpcode)inPacket.OperationCode)
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
