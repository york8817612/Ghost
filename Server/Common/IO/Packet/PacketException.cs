using System;

namespace Server.Common.IO.Packet
{
    internal class PacketException : Exception
    {
        public PacketException(string message) : base(message) { }
    }
}
