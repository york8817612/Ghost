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
                    result[i] = (byte)((buff[12 + i] ^ lena) ^ (privateKey[i % 8] ^ publicKey[i % 8]) ^ ((v10 >> 8) & 0xFF));
                    v10 *= 2171;
                }
            }
            result = Decrypt2(result);
            return result;
        }

        public byte[] Decrypt2(byte[] encryptPacket)
        {
            int i = 0; // v5
            int j = 0; // v7
            int k = 0; // v13
            int l = 0; // v14
            int v4 = 0;
            byte[] v5 = encryptPacket;
            int length = v5.Length;
            byte[] v7 = new byte[0x20000];
            int v8 = 0;
            int v9 = 0;
            int v10 = 0;
            int v11 = 0;
            int v12 = 0;
            byte[] v13 = new byte[0x20000];
            byte[] v14 = new byte[0x20000];
        label:
            if (j >= 0x20000 || i >= length)
            {
                goto label2;
            }
            while (true)
            {
                v8 = v5[i++];
                if (v8 >= 0x20)
                    break;
                v9 = v8 + 1;
                do
                {
                    v7[j++] = v5[i++];
                    --v9;
                } while (v9 > 0);
                goto label;
            }
            v10 = v8;
            v11 = (v8 & 0x1F) << 8;
            v12 = v10 >> 5;
            if (v12 == 7)
                v12 = v5[i++] + 7;

            k = j - v11 - 1 - v5[i++];

            if (k >= v4)
            {
                v7[j] = v7[k];
                v7[j + 1] = v7[k + 1];
                j += 2;
                l = k + 2;
                do
                {
                    v7[j++] = v7[l++];
                    --v12;
                } while (v12 > 0);
                goto label;
            }
        label2:
            byte[] ret = new byte[j];
            Array.Copy(v7, ret, ret.Length);
            return ret;
        }
    }
}