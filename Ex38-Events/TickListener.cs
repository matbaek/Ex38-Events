using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex38_Events
{
    public class TickListener
    {
        public static void HeardYou()
        {
            Console.WriteLine("Heard you");
        }

        public static void IAmAlive(Object sender, EventArgs e)
        {
            Console.WriteLine("For the record: " + sender + " is alive!");
        }

        public static void Bip()
        {
            Console.WriteLine("BIIIIIP");
        }
        
        public static void InsertAmount(int saldo)
        {
            int count = saldo / 595;
            Console.WriteLine("Tillykke – du har nu penge nok til " + count + " sæsonkort til OBs kampe");
        }
    }
}
