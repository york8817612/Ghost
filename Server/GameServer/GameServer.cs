using Server.Common.Constants;
using Server.Common.Data;
using Server.Common.IO;
using Server.Interoperability;
using Server.Net;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using static Server.Common.Constants.ServerUtilities;

namespace Server
{
    internal static class GameServer
    {
        private static bool isAlive;
        private static byte channelID;
        private static ManualResetEvent AcceptDone = new ManualResetEvent(false);

        public static TcpListener Listener { get; private set; }
        public static IPEndPoint RemoteEndPoint { get; private set; }

        public static UdpClient UdpListener { get; private set; }
        public static IPEndPoint UdpRemoteEndPoint { get; private set; }

        public static InteroperabilityClient LoginServerConnection { get; set; }
        public static List<Client> Clients { get; private set; }
        public static byte WorldID { get; set; }
        public static int AutoRestartTime { get; set; }

        public static Rates Rates { get; set; }
        public static string ScrollingHeader { get; set; }

        public static bool AllowMultiLeveling
        {
            get
            {
                return true; // TODO: Load from settings.
            }
        }

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
                    GameServer.AcceptDone.Set();
                }
            }
        }

        public static byte ChannelID
        {
            get
            {
                return channelID;
            }
            set
            {
                channelID = value;

                Console.Title = string.Format("Game Server v.{0}.{1} ({2}-{3})",
                    10,
                    10,
                    WorldNameResolver.GetName(GameServer.WorldID),
                    GameServer.ChannelID);
            }
        }

        public static byte InternalChannelID
        {
            get
            {
                return (byte)(GameServer.ChannelID - 1);
            }
        }

        [STAThread]
        private static void Main(string[] args)
        {
            int port = 0;
            Log.SetLogFile(".\\Logs\\GameLog.log");

        start:
            GameServer.Clients = new List<Client>();

            Log.Entitle("Game Server v.{0}.{1}", 10, 10);

            try
            {
                if (port == 0)
                {
                    try
                    {
                        port = int.Parse(args[0]);
                    }
                    catch
                    {
                        port = Log.Input("Port: ", 14101);
                    }
                }

                Settings.Initialize();

                GameServer.AutoRestartTime = 15; // TODO: Get actual restart-time.
                Log.Inform("Automatic restart time set to {0} seconds.", GameServer.AutoRestartTime);

                Database.Test();
                Database.Analyze(true);

                GameServer.RemoteEndPoint = new IPEndPoint(IPAddress.Parse(ServerConstants.SERVER_IP), port); // TODO: Get actual host.
                //MapleData.Initialize();

                UdpRemoteEndPoint = new IPEndPoint(IPAddress.Any, 14199);
                UdpListener = new UdpClient(UdpRemoteEndPoint);
                Log.Inform("Initialized clients UDP listener on {0}.", UdpRemoteEndPoint.Address);

                GameServer.Listener = new TcpListener(IPAddress.Any, GameServer.RemoteEndPoint.Port);
                GameServer.Listener.Start();
                Log.Inform("Initialized clients listener on {0}.", GameServer.Listener.LocalEndpoint);

                GameServer.IsAlive = true;
            }
            catch (Exception e)
            {
                Log.Error(e);
            }

            if (GameServer.IsAlive)
            {
                Log.Success("Server started on thread {0}.", Thread.CurrentThread.ManagedThreadId);

                AppDomain.CurrentDomain.UnhandledException += (s, e) =>
                {
                    Log.Error("Unhandled exception from Server: \n{0}", e.ExceptionObject.ToString());
                };

                new Thread(new ThreadStart(InteroperabilityClient.Main)).Start();
            }
            else
            {
                Log.Inform("Could not start server because of errors.");
            }

            while (GameServer.IsAlive)
            {
                GameServer.AcceptDone.Reset();
                GameServer.Listener.BeginAcceptSocket(new AsyncCallback(GameServer.OnAcceptSocket), null);
                GameServer.AcceptDone.WaitOne();
            }

            Client[] remainingClients = GameServer.Clients.ToArray();

            foreach (Client client in remainingClients)
            {
                client.Dispose();
            }

            GameServer.Dispose();

            Log.Warn("Server stopped.");

            if (GameServer.AutoRestartTime > 0)
            {
                Log.Inform("Attempting auto-restart in {0} seconds.", GameServer.AutoRestartTime);

                Thread.Sleep(GameServer.AutoRestartTime * 1000);

                goto start;
            }
            else
            {
                Console.Read();
            }
        }

        private static void OnAcceptSocket(IAsyncResult ar)
        {
            GameServer.AcceptDone.Set();

            try
            {
                new Client(GameServer.Listener.EndAcceptSocket(ar), GameServer.UdpListener);
            }
            catch (ObjectDisposedException) { } // NOTE: Seems to be an issue with the ManualResetEvent or the TcpListener, most likely to be a disposal issue.
        }

        public static void Stop()
        {
            GameServer.IsAlive = false;
        }

        private static void Dispose()
        {
            if (GameServer.LoginServerConnection != null)
            {
                GameServer.LoginServerConnection.Dispose();
            }

            if (GameServer.Listener != null)
            {
                GameServer.Listener.Stop();
            }

            Log.Inform("Server disposed.");
        }
    }
}
