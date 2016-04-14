using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Server.Common.Security;
using Server.Common.IO.Packet;

namespace Server.Common.Net
{
    public abstract class NetworkConnector<TReceiveOP, TSendOP, TCryptograph> : MarshalByRefObject where TCryptograph : Cryptograph, new()
    {
        protected bool isAlive;
        protected ManualResetEvent ReceiveDone = new ManualResetEvent(false);

        protected Socket Socket { get; set; }
        protected TCryptograph Cryptograph { get; set; }

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
            set
            {
                isAlive = value;

                if (!value)
                {
                    this.ReceiveDone.Set();
                }
            }
        }

        public IPEndPoint RemoteEndPoint
        {
            get
            {
                return (IPEndPoint)this.Socket.RemoteEndPoint;
            }
        }

        protected virtual void Prepare(params object[] args) { }
        protected virtual void Initialize() { }
        protected virtual void Terminate() { }
        protected virtual void CustomDispose() { }

        protected abstract bool IsServerAlive { get; }
        protected abstract void Dispatch(InPacket inPacket);

        public void Stop()
        {
            this.IsAlive = false;
        }
    }
}
