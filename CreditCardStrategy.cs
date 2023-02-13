using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_PD
{
    // Concrete Strategies
    class CreditCardStrategy : PaymentStrategy
    {
        private string name;
        private string cardNumber;
        private string cvv;
        private string dateOfExpiry;

        public CreditCardStrategy(string name, string cardNumber, string cvv, string dateOfExpiry)
        {
            this.name = name;
            this.cardNumber = cardNumber;
            this.cvv = cvv;
            this.dateOfExpiry = dateOfExpiry;
        }

        public override void Pay(int amount)
        {
            Console.WriteLine("Paying $" + amount + " using Credit Card [Name: " + name + ", Card Number: " + cardNumber + ", CVV: " + cvv + ", Expiry: " + dateOfExpiry + "]");
        }
    }
}
