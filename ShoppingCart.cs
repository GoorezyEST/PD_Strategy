using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_PD
{
    // The 'Context' class
    class ShoppingCart
    {
        private int amount;
        private PaymentStrategy paymentStrategy;

        public void SetAmount(int amount)
        {
            this.amount = amount;
        }

        public void SetPaymentStrategy(PaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void Pay()
        {
            paymentStrategy.Pay(amount);
        }
    }
}
