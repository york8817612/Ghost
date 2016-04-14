using System;
using System.Security.Cryptography;
using System.Text;

namespace Server.Common.Security
{
    public enum ShaMode
    {
        SHA1,
        SHA256,
        SHA512
    }

    public static class ShaCryptograph
    {
        public static string Encrypt(ShaMode mode, string input)
        {
            switch (mode)
            {
                case ShaMode.SHA1:
                    {
                        using (SHA1Managed sha = new SHA1Managed())
                        {
                            return BitConverter.ToString(sha.ComputeHash(Encoding.ASCII.GetBytes(input))).Replace("-", "").ToLower();
                        }
                    }

                case ShaMode.SHA256:
                    {
                        using (SHA256Managed sha = new SHA256Managed())
                        {
                            return BitConverter.ToString(sha.ComputeHash(Encoding.ASCII.GetBytes(input))).Replace("-", "").ToLower();
                        }
                    }

                case ShaMode.SHA512:
                    {
                        using (SHA512Managed sha = new SHA512Managed())
                        {
                            return BitConverter.ToString(sha.ComputeHash(Encoding.ASCII.GetBytes(input))).Replace("-", "").ToLower();
                        }
                    }

                default:
                    return string.Empty;
            }
        }
    }
}
