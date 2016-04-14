using System;

namespace Server.Characters
{
    public class HackException : Exception
    {
        public HackException() : base("Player operation is illegal.") { }

        public HackException(string message) : base(message) { }
    }
}
