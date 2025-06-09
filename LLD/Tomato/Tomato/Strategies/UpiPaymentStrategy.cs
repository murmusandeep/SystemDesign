namespace Tomato.Strategies
{
    public class UpiPaymentStrategy : IPaymentStrategy
    {
        private string mobile;

        public UpiPaymentStrategy(string mob)
        {
            mobile = mob;
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Paid ₹{amount} using UPI ({mobile})");
        }
    }
}
