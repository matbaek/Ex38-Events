using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex38_Events
{
    public delegate void TickHandler();
    public class Metronome
    {
        public event TickHandler Tick;
        
        public void Start()
        {
            for (int i = 0; i < 5; i++)
            {
                if (Tick != null)
                {
                    Tick();
                }
                System.Threading.Thread.Sleep(3000);
            }
        }
    }
}
