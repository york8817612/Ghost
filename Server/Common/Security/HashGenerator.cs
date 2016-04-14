using Server.Common.Utilities;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Server.Common.Security
{
    public static class HashGenerator
    {
        public static string GenerateMD5(string input = null)
        {
            if (input == null)
            {
                input = Randomizer.Next().ToString();
            }

            return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(input))).Replace("-", "").ToLower();
        }
    }
}