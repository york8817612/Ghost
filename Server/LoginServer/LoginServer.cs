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
using Timer = System.Timers.Timer;

namespace Server
{
    public static class LoginServer
    {
        private static bool isAlive;
        private static ManualResetEvent AcceptDone;
        private static Timer Pinger = new Timer();

        public static Worlds Worlds { get; private set; }
        public static List<Client> Clients { get; private set; }

        public static string SecurityCode { get; private set; }
        public static bool RequireStaffIP { get; private set; }

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
                    LoginServer.AcceptDone.Set();
                }
            }
        }

        public static void ServerLoop()
        {
            AcceptDone = new ManualResetEvent(false);
            Worlds = new Worlds();
            Clients = new List<Client>();

            Log.SetLogFile(".\\Logs\\LoginLog.log");

            Log.Entitle("Login Server v.{0}.{1}", 10, 10);

            try
            {

                Settings.Initialize();

                Database.Test();
                Database.Analyze(false);

                SecurityCode = Settings.GetString("SecurityCode", "Interconnection");
                Log.Inform("Cross-servers code '{0}' assigned.", Log.MaskString(LoginServer.SecurityCode));

                RequireStaffIP = Settings.GetBool("RequireStaffIP", "Login");
                Log.Inform("Staff will{0}be required to connect through a staff IP.", LoginServer.RequireStaffIP ? " " : " not ");

                TcpListener Listener = new TcpListener(IPAddress.Any, Settings.GetInt("Port", "Login"));
                Listener.Start();
                Log.Inform("Initialized clients listener on {0}.", Listener.LocalEndpoint);

                LoginServer.Pinger.Interval = Settings.GetInt("PingInterval");
                LoginServer.Pinger.Start();
                Log.Inform("Clients pinger set to {0}ms.", LoginServer.Pinger.Interval);

                foreach (string world in Settings.GetBlocksFromBlock("Worlds", 1))
                {
                    Worlds.Add(new World()
                    {
                        ID = Settings.GetByte("ID", world),
                        HostIP = Settings.GetIPAddress("Host", world),
                        Flag = Settings.GetEnum<ServerUtilities.ServerFlag>("Flag", world),
                        Channel = Settings.GetByte("Channel", world),
                        EventMessage = Settings.GetString("EventMessage", world),
                        DisableCreation = Settings.GetBool("DisableCreation", world),
                        ScrollingHeader = Settings.GetString("ScrollingHeader", world),
                        Rates = new ServerUtilities.Rates()
                        {
                            Experience = 6,
                            QuestExperience = 6,
                            PartyQuestExperience = 6,

                            Meso = 3,
                            Loot = 2
                        } // TODO: Actual rate load.
                    });
                }

                IsAlive = true;

                Log.Success("Server started on thread {0}.", Thread.CurrentThread.ManagedThreadId);

                AppDomain.CurrentDomain.UnhandledException += (s, e) =>
                {
                    Log.Error("Unhandled exception from Server: \n{0}", e.ExceptionObject.ToString());
                };

                new Thread(new ThreadStart(InteroperabilityServer.ServerLoop)).Start();

                while (IsAlive)
                {
                    AcceptDone.Reset();

                    Listener.BeginAcceptSocket((iar) =>
                    {
                        new Client(Listener.EndAcceptSocket(iar));

                        AcceptDone.Set();
                    }, null);

                    AcceptDone.WaitOne();
                }

                InteroperabilityServer.Stop();

                Client[] remainingClients = Clients.ToArray();

                foreach (Client client in remainingClients)
                {
                    client.Dispose();
                }

                Listener.Stop();

                Log.Warn("Login stopped.");
            }
            catch (Exception e)
            {
                Log.Error(e);
                Log.Inform("Could not start server because of errors.");
            }
            finally
            {
                Console.Read();
            }
        }

        public static void Stop()
        {
            IsAlive = false;
        }
    }
}
