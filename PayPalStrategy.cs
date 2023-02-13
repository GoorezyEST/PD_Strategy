using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_PD
{
    class PayPalStrategy : PaymentStrategy
    {
        private string email;
        private string password;

        public PayPalStrategy(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public override void Pay(int amount)
        {
            Console.WriteLine("Paying $" + amount + " using PayPal [Email: " + email + ", Password: " + password + "]");
        }
    }
}
