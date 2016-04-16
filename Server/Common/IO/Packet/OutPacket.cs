using Server.Common.Net;
using System;
using System.Globalization;
using System.IO;

namespace Server.Common.IO.Packet
{
    public class OutPacket : PacketBase, IDisposable
    {
        private const int DefaultBufferSize = 32;

        private MemoryStream _stream;
        private bool _disposed;

        public ushort OperationCode { get; private set; }

        public override int Position
        {
            get
            {
                return (int)_stream.Position;
            }
            set
            {
                if (value <= 0)
                {
                    throw new PacketException("Position must be greater than 1.");
                }

                _stream.Position = value;
            }
        }

        public override byte[] Content
        {
            get
            {
                return this._stream.ToArray();
            }
        }

        public bool Disposed
        {
            get
            {
                return _disposed;
            }
        }

        public OutPacket(int size = OutPacket.DefaultBufferSize)
        {
            this._stream = new MemoryStream(size);
            this._disposed = false;
        }

        public OutPacket(byte operationCode, int size = OutPacket.DefaultBufferSize)
            : this(size)
        {
            this.OperationCode = operationCode;

            this.WriteByte(operationCode);
        }

        public OutPacket(ushort operationCode, int size = OutPacket.DefaultBufferSize)
            : this(size)
        {
            this.OperationCode = operationCode;

            this.WriteUShort(operationCode);
        }

        public OutPacket(ServerMessage operationCode) : this((ushort)operationCode) { }
        public OutPacket(LoginServerMessage operationCode) : this((byte)operationCode) { }
        public OutPacket(InteroperabilityMessage operationCode) : this((ushort)operationCode) { }

        private void Append(long value, int count)
        {
            for (int i = 0; i < count; i++)
            {
                this._stream.WriteByte((byte)value);

                value >>= 8;
            }
        }

        public void WriteBool(bool value = false)
        {
            this.ThrowIfDisposed();

            this.WriteByte(value ? (byte)1 : (byte)0);
        }

        public void WriteByte(byte value = 0)
        {
            this.ThrowIfDisposed();

            this._stream.WriteByte(value);
        }

        public void WriteByte(int value)
        {
            this.ThrowIfDisposed();

            this._stream.WriteByte((byte)value);
        }

        public void WriteBytes(params byte[] value)
        {
            this.ThrowIfDisposed();

            this._stream.Write(value, 0, value.Length);
        }

        public void WriteShort(short value = 0)
        {
            this.ThrowIfDisposed();

            this.Append(value, 2);
        }

        public void WriteUShort(ushort value = 0)
        {
            this.ThrowIfDisposed();

            this.Append(value, 2);
        }

        public void WriteInt(int value = 0)
        {
            this.ThrowIfDisposed();

            this.Append(value, 4);
        }

        public void WriteUInt(uint value = 0)
        {
            this.ThrowIfDisposed();

            this.Append(value, 4);
        }

        public void WriteLong(long value = 0)
        {
            this.ThrowIfDisposed();

            this.Append(value, 8);
        }

        public void WriteString(string value)
        {
            this.ThrowIfDisposed();

            this.WriteShort((short)value.Length);

            foreach (char c in value)
            {
                this.WriteByte((byte)c);
            }
        }

        public void WriteString(string value, int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (i < value.Length)
                {
                    this.WriteByte((byte)value[i]);
                }
                else
                {
                    this.WriteByte();
                }
            }
        }

        public void WriteHexString(string value)
        {
            value = value.Replace(" ", "");

            if (value.Length % 2 != 0)
            {
                throw new InvalidOperationException("Hex string size is not even.");
            }

            for (int i = 0; i < value.Length; i += 2)
            {
                this.WriteByte(byte.Parse(value.Substring(i, 2), NumberStyles.HexNumber));
            }
        }

        public void Skip(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this.WriteByte();
            }
        }

        public void WriteIntDateTime(DateTime item)
        {
            int value;
            string time = item.Year.ToString();

            time += item.Month < 10 ? ("0" + item.Month.ToString()) : item.Month.ToString();
            time += item.Day < 10 ? ("0" + item.Day.ToString()) : item.Day.ToString();
            time += item.Hour < 10 ? ("0" + item.Hour.ToString()) : item.Hour.ToString();

            value = int.Parse(time);

            this.WriteInt(value);
        }

        public void WriteLongDateTime(DateTime item)
        {
            long value = (long)((item.Ticks * 1000) + 116444592000000000L);

            this.WriteLong(value);
        }

        public void WriteReversedLong(long value = 0)
        {
            this.WriteByte((byte)((value >> 32) & 0xFF));
            this.WriteByte((byte)((value >> 40) & 0xFF));
            this.WriteByte((byte)((value >> 48) & 0xFF));
            this.WriteByte((byte)((value >> 56) & 0xFF));
            this.WriteByte((byte)((value & 0xFF)));
            this.WriteByte((byte)((value >> 8) & 0xFF));
            this.WriteByte((byte)((value >> 16) & 0xFF));
            this.WriteByte((byte)((value >> 24) & 0xFF));
        }

        public void SetUInt(int position, uint value)
        {
            int temp = this.Position;
            this.Position = position;
            this.WriteUInt(value);
            this.Position = temp;
        }

        private void ThrowIfDisposed()
        {
            if (this._disposed)
            {
                throw new ObjectDisposedException(GetType().FullName);
            }
        }

        public void Dispose()
        {
            this._disposed = true;

            if (this._stream != null)
            {
                this._stream.Dispose();
            }

            this._stream = null;
        }
    }
}
