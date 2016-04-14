using System;

namespace Server.Common.Net
{
    public class NetworkException : Exception
    {
        public NetworkException() : base("An network error occured.") { }

        public NetworkException(string message) : base(message) { }
    }
}
