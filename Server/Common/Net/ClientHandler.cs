using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using Server.Common.IO;
using Server.Common.Security;
using Server.Common.IO.Packet;

namespace Server.Common.Net
{
    public abstract class ClientHandler<TReceiveOP, TSendOP, TCryptograph>
        : NetworkConnector<TReceiveOP, TSendOP, TCryptograph>, IDisposable where TCryptograph : Cryptograph, new()
    {
        protected string Title { get; set; }

        protected virtual void Register() { }
        protected virtual void Unregister() { }

        public ClientHandler(Socket socket, string title = "Client", params object[] args)
        {
            this.Title = title;

            Log.Inform("Preparing {0}...", this.Title.ToLower());

            this.Socket = socket;
            this.Cryptograph = new TCryptograph();
            this.ReceivalBuffer = new InPacket() { Limit = 0 };
            this.IsAlive = true;

            this.Prepare(args);

            Log.Success(string.Format("{0} connected from {1}.", this.Title, this.RemoteEndPoint.Address));

            this.Initialize();

            this.Register();

            while (this.IsAlive && this.IsServerAlive)
            {
                this.ReceiveDone.Reset();

                try
                {
                    this.Socket.BeginReceive(this.ReceivalBuffer.Array, this.ReceivalBuffer.Limit, this.ReceivalBuffer.Capacity - this.ReceivalBuffer.Limit, SocketFlags.None, new AsyncCallback(this.OnReceive), null);
                }
                catch (Exception e)

                {
                    Log.Error(e);
                    this.Stop();
                }

                this.ReceiveDone.WaitOne();
            }

            this.Dispose();
        }

        private InPacket ReceivalBuffer { get; set; }

        private void Handle(byte[] rawPacket, bool fromCommand = false, InPacket packet = null)
        {
            InPacket inPacket = fromCommand ? packet : new InPacket(this.Cryptograph.Decrypt(rawPacket));

            if (Enum.IsDefined(typeof(TReceiveOP), inPacket.OperationCode))
            {
                switch (PacketBase.LogLevel)
                {
                    case LogLevel.Name:
                        Log.Inform("Received {0} packet from {1}.", Enum.GetName(typeof(TReceiveOP), inPacket.OperationCode), this.Title);
                        break;

                    case LogLevel.Full:
                        Log.Hex("Received {0} packet from {1}: ", inPacket.Content, Enum.GetName(typeof(TReceiveOP), inPacket.OperationCode), this.Title);
                        break;
                }
            }
            else
            {
                Log.Hex("Received unknown (0x{0:X2}) packet from {1}: ", inPacket.Content, inPacket.OperationCode, this.Title);
            }

            if (fromCommand)
            {
                inPacket.Position = 0;
                inPacket.ReadShort();
            }

            this.Dispatch(inPacket);
        }

        private void OnReceive(IAsyncResult ar)
        {
            if (this.IsAlive)
            {
                try
                {
                    int received = this.Socket.EndReceive(ar);

                    if (received == 0)
                    {
                        this.Stop();
                    }
                    else
                    {
                        this.ReceivalBuffer.Limit += received;


                            this.Handle(this.ReceivalBuffer.Content);
                            this.ReceivalBuffer.Limit = 0;
                            this.ReceivalBuffer.Position = 0;
                        
                    }

                    this.ReceiveDone.Set();
                }
                catch (Exception)
                {
                    this.Stop();
                }
            }
        }

        public void Send(OutPacket outPacket)
        {
            lock (this)
            {
                if (this.IsAlive)
                {
                    this.Socket.Send(this.Cryptograph.Encrypt(outPacket.Content));

                    if (Enum.IsDefined(typeof(TSendOP), outPacket.OperationCode))
                    {
                        switch (PacketBase.LogLevel)
                        {
                            case LogLevel.Name:
                                Log.Inform("Sent {0} packet to {1}.", Enum.GetName(typeof(TSendOP), outPacket.OperationCode), this.Title);
                                break;

                            case LogLevel.Full:
                                Log.Hex("Sent {0} packet to {1}: ", outPacket.Content, Enum.GetName(typeof(TSendOP), outPacket.OperationCode), this.Title);
                                break;
                        }
                    }
                    else
                    {
                        Log.Hex("Sent unknown (0x{0:X2}) packet to {1}: ", outPacket.Content, outPacket.OperationCode, this.Title);
                    }
                }
                else
                {
                    //Log.Warn("Tried to send {0} packet to dead client.", Enum.GetName(typeof(TSendOP), outPacket.OperationCode));
                }
            }
        }

        public void Dispose()
        {
            try
            {
                this.Terminate();
            }
            catch (Exception e)
            {
                Log.Error("Termination error on {0}: ", e, this.Title);
            }

            this.Socket.Dispose();
            this.Cryptograph.Dispose();
            //this.ReceiveDone.Dispose(); // TODO: Figure why this crashes.
           // this.ReceivalBuffer.Dispose();

            this.CustomDispose();

            this.Unregister();

            Log.Inform("{0} disposed.", this.Title);
        }

        public void HandlePacket(InPacket inPacket)
        {
            this.Handle(null, true, inPacket);
        }
    }
}
