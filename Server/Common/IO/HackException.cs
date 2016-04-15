using System;
using static Server.Common.Constants.ServerUtilities;

namespace Server.Common.IO
{
    public class HackException : Exception
    {
        public HackException() : base("Player operation is illegal.") { }

        public HackException(string message) : base(message) { }

        public HackAction Action { get; private set; }

        public HackException(HackAction action, string message)
            : base(message)
        {
            this.Action = action;
        }
    }
}
