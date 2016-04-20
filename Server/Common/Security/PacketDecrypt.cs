using Server.Common.IO.Packet;
using System;

namespace Server.Common.Security
{
    public class PacketDecrypt
    {
        private byte[] privateKey = { 0x29, 0x6B, 0xD6, 0xEB, 0x2C, 0xA9, 0x03, 0x21 };
        private byte[] publicKey;
        private byte[] m_tkey = new byte[8];

        public PacketDecrypt(long key)
        {
            publicKey = BitConverter.GetBytes(key);
        }

        public byte[] Decrypt(byte[] packet)
        {
            int length = packet[4], rsk = 0, lkey = 0;
            byte[] packetOut = new byte[packet[0] + 5];

            for (int i = 0; i < 8; i++)
            {
                m_tkey[i] = (byte)(privateKey[i] ^ publicKey[i]);
            }
            byte[] pkey = m_tkey;

            int rkey = 2157;
            lkey = (length * 157) & 0xFF;

            for (int i = 0; i < packet[0] + 5; i++)
            {
                rsk = (rkey >> 8) & 0xFF;
                packetOut[i] = (byte)(((packet[i + 12] ^ rsk) ^ pkey[(i % 8)]) ^ lkey);
                rkey *= 2171;
            }
            return packetOut;
        } 


    }
}
