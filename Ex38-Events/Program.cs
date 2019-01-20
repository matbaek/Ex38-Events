using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex38_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metronome metronome = new Metronome();
            //metronome.Tick += TickListener.HeardYou;
            //metronome.Start();

            //LifeMeasure lifeMeasure = new LifeMeasure();
            //lifeMeasure.Pulse += TickListener.IAmAlive;
            //lifeMeasure.Bip += TickListener.Bip;
            //lifeMeasure.Start();

            PiggyBank piggyBank = new PiggyBank();
            piggyBank.Piggy += TickListener.InsertAmount;
            piggyBank.Start();
        }
    }
}
