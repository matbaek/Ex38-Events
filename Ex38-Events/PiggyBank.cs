using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex38_Events
{
    public delegate void PiggyHandler(int saldo);
    public class PiggyBank
    {
        public event PiggyHandler Piggy;
        int saldo = 0;
        int amount = 100;

        public void Start()
        {
            while (true)
            {
                InsertAmount(amount);
            }
        }

        public void InsertAmount(double amount)
        {
            if(Piggy != null)
            {
                saldo += this.amount;
                Piggy(saldo);
            }
            System.Threading.Thread.Sleep(1000);
        }
    }
}
