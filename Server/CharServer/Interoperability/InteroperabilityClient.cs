using Server.Common.Constants;
using Server.Common.IO;
using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Common.Security;
using System;
using System.Net;

namespace Server.Interoperability
{
    public sealed class InteroperabilityClient : ServerHandler<InteroperabilityMessage, InteroperabilityMessage, BlankCryptograph>
    {
        public InteroperabilityClient(IPEndPoint remoteEP, string code) : base(remoteEP, "Login server", new object[] { code }) { }


        protected override bool IsServerAlive
        {
            get
            {
                return CharServer.IsAlive;
            }
        }

        protected override void StopServer()
        {
            CharServer.Stop();
        }

        public static void Main()
        {
            try
            {
                CharServer.LoginServerConnection = new InteroperabilityClient(new IPEndPoint(
                    Settings.GetIPAddress("IP", "Interconnection"),
                    Settings.GetInt("Port", "Interconnection")),
                    Settings.GetString("SecurityCode", "Interconnection"));

                CharServer.LoginServerConnection.Loop();
            }
            catch (Exception e)
            {
                Log.Error("Server connection failed: \n{0}", e.ToString());

                CharServer.Stop();
            }
        }

        protected override void Initialize(params object[] args)
        {
            using (OutPacket outPacket = new OutPacket(InteroperabilityMessage.RegistrationRequest))
            {
                outPacket.WriteByte((byte)ServerUtilities.ServerType.Char);
                outPacket.WriteString((string)args[0]);
                outPacket.WriteBytes(CharServer.RemoteEndPoint.Address.GetAddressBytes());
                outPacket.WriteUShort((ushort)CharServer.RemoteEndPoint.Port);

                this.Send(outPacket);
            }
        }

        protected override void Dispatch(InPacket inPacket)
        {
            switch ((InteroperabilityMessage)inPacket.OperationCode)
            {
                case InteroperabilityMessage.RegistrationResponse:
                    this.OnRegistrationResponse(inPacket);
                    break;
            }
        }

        private void OnRegistrationResponse(InPacket inPacket)
        {
            var response = (ServerUtilities.ServerRegistrationResponse)inPacket.ReadByte();

            switch (response)
            {
                case ServerUtilities.ServerRegistrationResponse.Valid:
                    {
                        CharServer.WorldID = inPacket.ReadByte();

                        Log.Success("Registered Char as {0} at {1}.", ServerUtilities.WorldNameResolver.GetName(CharServer.WorldID), CharServer.RemoteEndPoint);
                    }
                    break;

                default:
                    throw new NetworkException(ServerUtilities.RegistrationResponseResolver.Explain(response));
            }
        }
    }
}
