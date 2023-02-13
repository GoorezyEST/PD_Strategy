using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_PD
{
    // The 'Strategy' abstract class
    abstract class PaymentStrategy
    {
        public abstract void Pay(int amount);
    }
}
