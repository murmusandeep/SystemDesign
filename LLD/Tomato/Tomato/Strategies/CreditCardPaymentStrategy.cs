namespace Tomato.Strategies
{
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        private string cardNumber;

        public CreditCardPaymentStrategy(string card)
        {
            cardNumber = card;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Paid ₹{amount} using Credit Card ({cardNumber})");
        }
    }
}
