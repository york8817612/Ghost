using Server.Common.IO;
using Server.Common.Net;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server.Interoperability
{
    public static class InteroperabilityServer
    {
        private static bool isAlive;
        private static ManualResetEvent AcceptDone;

        public static string SecurityCode { get; private set; }
        public static List<InteroperabilityClient> Servers { get; private set; }

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
                    AcceptDone.Set();
                }
            }
        }

        public static void ServerLoop()
        {
            AcceptDone = new ManualResetEvent(false);
            Servers = new List<InteroperabilityClient>();

            try
            {
                TcpListener Listener = new TcpListener(IPAddress.Any, Settings.GetInt("Port", "Interconnection"));
                Listener.Start();
                Log.Inform("Initialized interoperability listener on {0}.", Listener.LocalEndpoint);

                IsAlive = true;
                Log.Success("Interoperability started on thread {0}.", Thread.CurrentThread.ManagedThreadId);

                while (IsAlive)
                {
                    AcceptDone.Reset();

                    Listener.BeginAcceptSocket((iar) =>
                    {
                        AcceptDone.Set();

                        new InteroperabilityClient(Listener.EndAcceptSocket(iar));

                    }, null);

                    AcceptDone.WaitOne();
                }

                InteroperabilityClient[] remainingServers = Servers.ToArray();

                foreach (InteroperabilityClient server in remainingServers)
                {
                    server.Stop();
                }

                Listener.Stop();

                Log.Warn("Interoperability stopped.");
            }
            catch (Exception e)
            {
                Log.Error(e);
                Log.Inform("Could not start interoperability because of errors.");
            }
            finally
            {
                Console.Read();
            }
        }

        public static void Stop()
        {
            InteroperabilityServer.IsAlive = false;
        }
    }
}
