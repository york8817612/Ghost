using System;
using System.Collections.Generic;
using System.Threading;

namespace Server.Common.Collections
{
    public class PendingQueue<TValue> : Queue<TValue>, IDisposable
    {
        private ManualResetEvent QueueDone = new ManualResetEvent(false);

        public PendingQueue() : base() { }

        public new void Enqueue(TValue item)
        {
            base.Enqueue(item);

            this.QueueDone.Set();
        }

        public new TValue Dequeue()
        {
            this.QueueDone.WaitOne();

            TValue result = base.Dequeue();

            this.QueueDone.Reset();

            return result;
        }

        public void Dispose()
        {
            this.QueueDone.Dispose();
        }
    }
}
