namespace Strategy_PD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.SetAmount(100);

            CreditCardStrategy creditCard = new CreditCardStrategy("John Doe", "1234567890123456", "123", "12/24");
            cart.SetPaymentStrategy(creditCard);
            cart.Pay();

            PayPalStrategy paypal = new PayPalStrategy("test@example.com", "password");
            cart.SetPaymentStrategy(paypal);
            cart.Pay();
        }
    }
}