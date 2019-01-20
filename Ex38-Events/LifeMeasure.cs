using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex38_Events
{
    public delegate void PulseHandler(Object sender, EventArgs e);
    public delegate void BipHandler();
    public class LifeMeasure
    {
        public event PulseHandler Pulse;
        public event BipHandler Bip;
        public EventArgs e = null;

        public void Start()
        {
            while(true)
            {
                if (Pulse != null && Bip != null)
                {
                    Pulse("Bob", e);
                    Bip();
                }
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
