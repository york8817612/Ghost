using System;

namespace Server.Ghost.Accounts
{
    public class NoAccountException : Exception
    {
        public override string Message
        {
            get
            {
                return "The specified account does not exist.";
            }
        }
    }
}
