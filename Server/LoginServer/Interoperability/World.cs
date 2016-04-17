using Server.Common.Collections;
using Server.Common.IO.Packet;
using Server.Common.Net;
using Server.Common.Utilities;
using Server.Common.Constants;
using System.Collections.Generic;
using System.Net;

namespace Server.Interoperability
{
    public class World : DynamicKeyedCollection<byte, InteroperabilityClient>
    {
        public byte ID { get; set; }
        public IPAddress HostIP { get; set; }
        public short Channel { get; set; }
        public string EventMessage { get; set; }
        public ServerUtilities.Rates Rates { get; set; }
        public ServerUtilities.ServerFlag Flag { get; set; }
        public bool DisableCreation { get; set; }
        public string ScrollingHeader { get; set; }

        public InteroperabilityClient CharServer { get; set; }
        public InteroperabilityClient MessageServer { get; set; }
        public InteroperabilityClient ShopServer { get; set; }

        public PendingKeyedQueue<int, List<byte[]>> CharacterListPool = new PendingKeyedQueue<int, List<byte[]>>();
        public PendingKeyedQueue<string, bool> CharacterNamePool = new PendingKeyedQueue<string, bool>();
        public PendingKeyedQueue<int, byte[]> CharacterCreationPool = new PendingKeyedQueue<int, byte[]>();

        public string Name
        {
            get
            {
                return ServerUtilities.WorldNameResolver.GetName(this.ID);
            }
        }

        public bool IsFull
        {
            get
            {
                return this.Count == this.Channel;
            }
        }

        public ServerUtilities.ServerStatus Status
        {
            get
            {
                int loadProportion = 0;

                foreach (InteroperabilityClient channel in this)
                {
                    loadProportion += channel.LoadProportion;
                }

                ServerUtilities.ServerStatus status;

                if (loadProportion > 400)
                {
                    status = ServerUtilities.ServerStatus.Full;
                }
                else if (loadProportion > 200)
                {
                    status = ServerUtilities.ServerStatus.HighlyPopulated;
                }
                else
                {
                    status = ServerUtilities.ServerStatus.Normal;
                }

                return status;
            }
        }

        public InteroperabilityClient RandomChannel
        {
            get
            {
                return this[Randomizer.Next(this.Count)];
            }
        }

        public InteroperabilityClient LeastLoadedChannel
        {
            get
            {
                return this[0]; // TODO: Get the least loaded channel using every channel's load.
            }
        }

        public World() : base() { }

        protected override byte GetKeyForItem(InteroperabilityClient item)
        {
            return item.InternalID;
        }

        public List<byte[]> GetCharacters(int accountId, byte worldId, bool fromViewAll)
        {
            using (OutPacket outPacket = new OutPacket(InteroperabilityMessage.CharacterEntriesRequest))
            {
                outPacket.WriteInt(accountId);
                outPacket.WriteByte(worldId);
                outPacket.WriteBool(fromViewAll);

                this.RandomChannel.Send(outPacket);
            }

            return this.CharacterListPool.Dequeue(accountId);
        }

        public bool IsNameTaken(string name)
        {
            using (OutPacket outPacket = new OutPacket(InteroperabilityMessage.CharacterNameCheckRequest))
            {
                outPacket.WriteString(name);

                this.RandomChannel.Send(outPacket);
            }

            return this.CharacterNamePool.Dequeue(name);
        }

        public byte[] CreateCharacter(int accountId, byte worldId, bool isMaster, byte[] data)
        {
            using (OutPacket outPacket = new OutPacket(InteroperabilityMessage.CharacterCreationRequest))
            {
                outPacket.WriteInt(accountId);
                outPacket.WriteByte(worldId);
                outPacket.WriteBool(isMaster);
                outPacket.WriteBytes(data);

                this.RandomChannel.Send(outPacket);
            }

            return this.CharacterCreationPool.Dequeue(accountId);
        }

        public void DeleteCharacter(int characterId)
        {
            using (OutPacket outPacket = new OutPacket(InteroperabilityMessage.CharacterDeletionRequest))
            {
                outPacket.WriteInt(characterId);

                this.RandomChannel.Send(outPacket);
            }
        }
    }
}
