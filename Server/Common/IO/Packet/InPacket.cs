using System;
using System.Net;
using System.Text;

namespace Server.Common.IO.Packet
{
    public class InPacket : PacketBase
    {
        private int _index;

        public int Limit { get; set; }
        public int Offset { get; private set; }
        public int Capacity { get; private set; }
        public byte[] Array { get; private set; }
        public ushort OperationCode { get; set; }
        public bool HasFlipped { get; private set; }

        public int Available
        {
            get
            {
                return this.Limit - this.Position;
            }
        }

        public override int Position
        {
            get
            {
                return _index;
            }
            set
            {
                _index = value;
            }
        }

        public override byte[] Content
        {
            get
            {
                var final = new byte[this.Available];

                Buffer.BlockCopy(this.Array, this.Position + this.Offset, final, 0, this.Available);

                return final;
            }
        }

        public InPacket(int capacity = Application.DefaultBufferSize)
        {
            this.Capacity = capacity;
            this.Array = new byte[this.Capacity];

            this.Limit = this.Capacity;
            this.Offset = 0;
            this.Position = 0;
        }

        public InPacket(byte[] buffer, bool operationCode = true)
        {
            this.Capacity = buffer.Length;
            this.Array = buffer;

            this.Limit = this.Capacity;
            this.Offset = 0;
            this.Position = 0;

            if (operationCode)
            {
                this.OperationCode = this.ReadUShort();
            }
        }

        private void CheckLength(int length)
        {
            if (this._index + length > this.Array.Length || length < 0)
            {
                throw new PacketException("Insufficient space.");
            }
        }

        public bool ReadBool()
        {
            return this.ReadByte() == 1;
        }

        public byte ReadByte()
        {
            this.CheckLength(1);

            return this.Array[this._index++];
        }

        public byte[] ReadBytes(int count)
        {
            this.CheckLength(count);

            var value = new byte[count];

            Buffer.BlockCopy(this.Array, this._index, value, 0, count);

            this._index += count;

            return value;
        }

        public unsafe short ReadShort()
        {
            this.CheckLength(2);

            short value;

            fixed (byte* ptr = this.Array)
            {
                value = *(short*)(ptr + this._index);
            }

            this._index += 2;

            return value;
        }

        public unsafe ushort ReadUShort()
        {
            this.CheckLength(2);

            ushort value;

            fixed (byte* ptr = this.Array)
            {
                value = *(ushort*)(ptr + this._index);
            }

            this._index += 2;

            return value;
        }

        public unsafe int ReadInt()
        {
            this.CheckLength(4);

            int value;

            fixed (byte* ptr = this.Array)
            {
                value = *(int*)(ptr + this._index);
            }

            this._index += 4;

            return value;
        }

        public unsafe uint ReadUInt()
        {
            this.CheckLength(4);

            uint value;

            fixed (byte* ptr = this.Array)
            {
                value = *(uint*)(ptr + this._index);
            }

            this._index += 4;

            return value;
        }

        public unsafe long ReadLong()
        {
            this.CheckLength(8);

            long value;

            fixed (byte* ptr = this.Array)
            {
                value = *(long*)(ptr + this._index);
            }

            this._index += 8;

            return value;
        }

        public string ReadString(int count = -1)
        {
            if (count == -1)
            {
                count = this.ReadShort();
            }

            this.CheckLength(count);

            byte[] value = new byte[count];

            for (int i = 0; i < count; i++)
            {
                value[i] = this.ReadByte();
            }
            var nullIndex = System.Array.IndexOf(value, (byte)0);
            nullIndex = (nullIndex == -1) ? value.Length : nullIndex;

            return Encoding.GetEncoding("Big5").GetString(value, 0, nullIndex);
        }

        public IPAddress ReadIPAddress()
        {
            return new IPAddress(this.ReadBytes(4));
        }

        public void Skip(int count)
        {
            this.CheckLength(count);

            this._index += count;
        }

        public void Flip()
        {
            this.Limit = this.Position;
            this.Position = 0;
            this.HasFlipped = true;
        }

        public void SafeFlip()
        {
            if (!this.HasFlipped)
            {
                this.Flip();
            }
        }
    }
}
