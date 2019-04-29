using Server.Common.Constants;
using Server.Common.Data;
using Server.Common.IO;
using Server.Interoperability;
using Server.Ghost;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    internal static class CharServer
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
                    CharServer.AcceptDone.Set();
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

                Console.Title = string.Format("Char Server v.{0}.{1} ({2})",
                    10,
                    10,
                    ServerUtilities.WorldNameResolver.GetName(CharServer.WorldID));
            }
        }

        [STAThread]
        private static void Main(string[] args)
        {
            Log.SetLogFile(".\\Logs\\CharLog.log");

        start:
            CharServer.Clients = new List<Client>();

            Log.Entitle("Char Server v.{0}.{1}", 10, 10);

            try
            {
                Settings.Initialize();

                CharServer.AutoRestartTime = 15; // TODO: Get actual restart-time.
                Log.Inform("Automatic restart time set to {0} seconds.", CharServer.AutoRestartTime);

                Database.Test();
                Database.Analyze(false); // NOTE: The shop server uses mcdb for information like items, etcetera.

                CharServer.RemoteEndPoint = new IPEndPoint(Settings.GetIPAddress("ExternalIP", "Char"), Settings.GetInt("Port", "Char"));

                //MapleData.Initialize();

                CharServer.Listener = new TcpListener(IPAddress.Any, CharServer.RemoteEndPoint.Port);
                CharServer.Listener.Start();
                Log.Inform("Initialized clients listener on {0}.", CharServer.Listener.LocalEndpoint);

                CharServer.IsAlive = true;

            }
            catch (Exception e)
            {
#if DEBUG
                Log.Error(e.ToString());
#else
                Log.Error(e);
#endif
            }

            if (CharServer.IsAlive)
            {
                Log.Success("Server started on thread {0}.", Thread.CurrentThread.ManagedThreadId);

                new Thread(new ThreadStart(InteroperabilityClient.Main)).Start();
            }
            else
            {
                Log.Inform("Could not start server because of errors.");
            }

            while (CharServer.IsAlive)
            {
                CharServer.AcceptDone.Reset();

                CharServer.Listener.BeginAcceptSocket(new AsyncCallback(CharServer.OnAcceptSocket), null);

                CharServer.AcceptDone.WaitOne();
            }

            Client[] remainingClients = CharServer.Clients.ToArray();

            foreach (Client client in remainingClients)
            {
                client.Dispose();
            }

            CharServer.Dispose();

            Log.Warn("Server stopped.");

            if (CharServer.AutoRestartTime > 0)
            {
                Log.Inform("Attempting auto-restart in {0} seconds.", CharServer.AutoRestartTime);

                Thread.Sleep(CharServer.AutoRestartTime * 1000);

                goto start;
            }
            else
            {
                Console.Read();
            }
        }

        private static void OnAcceptSocket(IAsyncResult ar)
        {
            CharServer.AcceptDone.Set();

            try
            {
                new Client(CharServer.Listener.EndAcceptSocket(ar));
            }
            catch (ObjectDisposedException) { } // NOTE: Seems to be an issue with the ManualResetEvent or the TcpListener, most likely to be a disposal issue.
        }

        public static void Stop()
        {
            CharServer.IsAlive = false;
        }

        private static void Dispose()
        {
            if (CharServer.LoginServerConnection != null)
            {
                CharServer.LoginServerConnection.Dispose();
            }

            if (CharServer.Listener != null)
            {
                CharServer.Listener.Stop();
            }

            Log.Inform("Server disposed.");
        }
    }
}
