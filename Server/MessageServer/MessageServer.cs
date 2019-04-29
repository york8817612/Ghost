using Server.Common.Data;
using Server.Interoperability;
using Server.Common.IO;
using Server.Common.Constants;
using Server.Ghost;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Server.Net;

namespace Server
{
    internal static class MessageServer
    {
        private static bool isAlive;
        private static byte worldID;
        private static ManualResetEvent AcceptDone = new ManualResetEvent(false);

        public static TcpListener Listener { get; private set; }
        public static IPEndPoint RemoteEndPoint { get; private set; }
        public static InteroperabilityClient LoginServerConnection { get; set; }
        public static List<Client> Clients { get; private set; }
        public static int AutoRestartTime { get; set; }

        public static bool IsAlive
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
                    MessageServer.AcceptDone.Set();
                }
            }
        }

        public static byte WorldID
        {
            get
            {
                return worldID;
            }
            set
            {
                worldID = value;

                Console.Title = string.Format("Message Server v.{0}.{1} ({2})",
                    10,
                    10,
                    ServerUtilities.WorldNameResolver.GetName(MessageServer.WorldID));
            }
        }

        [STAThread]
        private static void Main(string[] args)
        {
            Log.SetLogFile(".\\Logs\\MessageLog.log");

        start:
            MessageServer.Clients = new List<Client>();

        Log.Entitle("Message Server v.{0}.{1}", 10, 10);

            try
            {
                Settings.Initialize();

                MessageServer.AutoRestartTime = 15; // TODO: Get actual restart-time.
                Log.Inform("Automatic restart time set to {0} seconds.", MessageServer.AutoRestartTime);

                Database.Test();
                Database.Analyze(false); // NOTE: The shop server uses mcdb for information like items, etcetera.

                MessageServer.RemoteEndPoint = new IPEndPoint(Settings.GetIPAddress("ExternalIP", "Message"), Settings.GetInt("Port", "Message"));

                //MapleData.Initialize();

                MessageServer.Listener = new TcpListener(IPAddress.Any, MessageServer.RemoteEndPoint.Port);
                MessageServer.Listener.Start();
                Log.Inform("Initialized clients listener on {0}.", MessageServer.Listener.LocalEndpoint);

                MessageServer.IsAlive = true;

            }
            catch (Exception e)
            {
#if DEBUG
                Log.Error(e.ToString());
#else
                Log.Error(e);
#endif
            }

            if (MessageServer.IsAlive)
            {
                Log.Success("Server started on thread {0}.", Thread.CurrentThread.ManagedThreadId);

                new Thread(new ThreadStart(InteroperabilityClient.Main)).Start();
            }
            else
            {
                Log.Inform("Could not start server because of errors.");
            }

            while (MessageServer.IsAlive)
            {
                MessageServer.AcceptDone.Reset();

                MessageServer.Listener.BeginAcceptSocket(new AsyncCallback(MessageServer.OnAcceptSocket), null);

                MessageServer.AcceptDone.WaitOne();
            }

            Client[] remainingClients = MessageServer.Clients.ToArray();

            foreach (Client client in remainingClients)
            {
                client.Dispose();
            }

            MessageServer.Dispose();

            Log.Warn("Server stopped.");

            if (MessageServer.AutoRestartTime > 0)
            {
                Log.Inform("Attempting auto-restart in {0} seconds.", MessageServer.AutoRestartTime);

                Thread.Sleep(MessageServer.AutoRestartTime * 1000);

                goto start;
            }
            else
            {
                Console.Read();
            }
        }

        private static void OnAcceptSocket(IAsyncResult ar)
        {
            MessageServer.AcceptDone.Set();

            try
            {
                new Client(MessageServer.Listener.EndAcceptSocket(ar));
            }
            catch (ObjectDisposedException) { } // NOTE: Seems to be an issue with the ManualResetEvent or the TcpListener, most likely to be a disposal issue.
        }

        public static void Stop()
        {
            MessageServer.IsAlive = false;
        }

        private static void Dispose()
        {
            if (MessageServer.LoginServerConnection != null)
            {
                MessageServer.LoginServerConnection.Dispose();
            }

            if (MessageServer.Listener != null)
            {
                MessageServer.Listener.Stop();
            }

            Log.Inform("Server disposed.");
        }
    }
}
