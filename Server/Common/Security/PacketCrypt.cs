using Server.Common.IO.Packet;
using System;

namespace Server.Common.Security
{
    public class PacketCrypt
    {
        private byte[] privateKey = { 0x29, 0x6B, 0xD6, 0xEB, 0x2C, 0xA9, 0x03, 0x21 };
        private byte[] publicKey;

        public PacketCrypt(long key)
        {
            publicKey = BitConverter.GetBytes(key);
        }

        public byte[] Encrypt(byte[] buff)
        {
            int len = buff.Length;
            byte[] result = new byte[len];
            bool v8v9 = (len == 0 | len < 0);
            int v10 = 2157;
            int lena = (157 * len) & 0xFF;

            if (!v8v9)
            {
                for (int i = 0; i < len; i++)
                {
                    // mov bl, privatekey[i]
                    // xor bl, buff[i]
                    int v1 = ((privateKey[i % 8] ^ publicKey[i % 8]) ^ buff[i]);
                    // mov eax, edx
                    // mov eax, 8
                    // xor bl, al
                    int v2 = v1 ^ ((v10 >> 8) & 0xFF);
                    // mov al, lena
                    // xor bl, al
                    int v3 = v2 ^ lena;
                    // inc esi <== for i++
                    // mov edi, bl
                    result[i] = (byte)v3;
                    // lea eax, [edi+edi*8]
                    // lea edi, [edx+eax*8]
                    // lea eax, [edi+edi*4]

                    // lea edx, [edx+eax*2]
                    v10 *= 2171;
                }
            }

            return result;
        }

        public byte[] Decrypt(byte[] buff)
        {
            int len = (buff[4] + (buff[5] << 8)), v10 = 2157, lena = (157 * len) & 0xFF;
            byte[] result = new byte[len];
            bool v8v9 = (len == 0 | len < 0);

            if (!v8v9)
            {
                for (int i = 0; i < len; i++)
                {
                    result[i] = (byte) ((buff[12 + i] ^ lena) ^ (privateKey[i % 8] ^ publicKey[i % 8]) ^ ((v10 >> 8) & 0xFF));
                    v10 *= 2171;
                }
            }
            return result;
        }


    }
}
