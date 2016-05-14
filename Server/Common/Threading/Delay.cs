using Server.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Server.Common.Threading
{
    public class Delay
    {
        public static async Task Execute(int delay, ThreadStart action)
        {
            await Task.Delay((int)delay).ContinueWith((x) => action());
        }

        public static async Task Execute(double delay, ThreadStart action)
        {
            await Task.Delay((int)delay).ContinueWith((x) => action());
        }

        public TimerPlus Timer { get; private set; }

        public Delay(int delay, bool auto, ThreadStart action)
        {
            this.Timer = new TimerPlus(delay);
            this.Timer.AutoReset = auto;
            this.Timer.Elapsed += new ElapsedEventHandler(delegate (object sender, ElapsedEventArgs e)
            {
                if (this.Timer != null)
                {
                    //t.Stop();
                    action();
                    //t.Dispose();
                }

                //t = null;
            });
        }

        public void Execute()
        {
            this.Timer.Start();
        }

        public void Cancel()
        {
            if (this.Timer != null)
            {
                this.Timer.Stop();
                this.Timer.Dispose();
            }

            this.Timer = null;
        }
    }
}
