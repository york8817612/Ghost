using System.Text;

namespace Server.Common.IO.Packet
{
    public abstract class PacketBase
    {
        public static LogLevel LogLevel { get; set; }

        public abstract int Position { get; set; }

        public abstract byte[] Content { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (byte b in this.Content)
            {
                sb.AppendFormat("{0:X2} ", b);
            }

            return sb.ToString();
        }
    }
}
