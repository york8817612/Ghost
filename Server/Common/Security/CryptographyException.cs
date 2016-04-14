using System;

namespace Server.Common.IO
{
    public class CryptographyException : Exception
    {
        public CryptographyException() : base("A cryptography error occured.") { }

        public CryptographyException(string message) : base(message) { }
    }
}
