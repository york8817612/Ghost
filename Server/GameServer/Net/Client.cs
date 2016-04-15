using Server.Characters;
using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static Server.Common.Constants.ServerUtilities;

namespace Server.Net
{
    public sealed class Client : Session
    {
        public Character Character { get; private set; }

        public Client(Socket socket) : base(socket) { }

        protected override void Register()
        {
            GameServer.Clients.Add(this);

            Log.Inform("Accepted connection from {0}.", this.Title);
        }

        protected override void Unregister()
        {
            try
            {
                if (this.Character != null)
                {
                    //if (this.Character.IsInitialized)
                    //{
                    //    if (this.Character.Trade != null)
                    //    {
                    //        this.Character.Trade.Cancel(this.Character);
                    //    }

                    //    this.Character.Rebuyables.Clear();

                    //    var closestSpawnPoint = this.Character.ClosestSpawnPoint;

                    //    if (closestSpawnPoint != null)
                    //    {
                    //        this.Character.SpawnPoint = closestSpawnPoint.ID;
                    //    }

                    //    if (this.Character.Field.ForcedReturnID != 999999999)
                    //    {
                    //        this.Character.Field = MapleData.Fields[this.Character.Field.ForcedReturnID];
                    //    }

                    //    this.Character.Field.Characters.Remove(this.Character);

                    //    this.UpdateLoggedIn();
                    //}

                    //this.Character.Save();
                }

                GameServer.Clients.Remove(this);

                Log.Inform("Lost connection from {0}.", this.Title);
            }
            catch (Exception e)
            {
                Log.Error("Unregister exception from {0}: \n{1}", this.Title, e.ToString());
            }
        }

        protected override void Dispatch(InPacket inPacket)
        {
            try
            {
                if (this.Character != null)
                {
                    switch ((ClientMessage)inPacket.OperationCode)
                    {

                    }
                }
                else
                {
                    switch ((ClientMessage)inPacket.OperationCode)
                    {


                        // NOTE: Using other packets while not being loaded.
                        default:
                            this.Dispose();
                            break;
                    }
                }
            }
            catch (HackException e)
            {
                if (this.Character != null)
                {
                    // TODO: Register offense points in the database (?).

                    //Log.Warn("Taking Hack Action of {0} against {1}: \n{2}", e.Action, this.Character.Name, e.Message);

                    switch (e.Action)
                    {
                        case HackAction.Disconnection:
                            {
                                this.Dispose();
                            }
                            break;

                        case HackAction.ThirthyDays:
                            {

                            }
                            break;

                        case HackAction.NinetyDays:
                            {

                            }
                            break;

                        case HackAction.Permanent:
                            {

                            }
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error("Unhandled Packet Exception from {0}: \n{1}", this.Title, e.ToString());
            }
        }
    }
}
