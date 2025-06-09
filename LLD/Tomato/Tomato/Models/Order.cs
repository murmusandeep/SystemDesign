using Tomato.Strategies;

namespace Tomato.Models
{
    public abstract class Order
    {
        private static int _nextOrderId = 0;

        protected int orderId;
        protected User user;
        protected Restaurant restaurant;
        protected List<MenuItem> items;
        protected IPaymentStrategy paymentStrategy;
        protected double total;
        protected string scheduled;

        public Order()
        {
            user = null;
            restaurant = null;
            paymentStrategy = null;
            total = 0.0;
            scheduled = string.Empty;
            orderId = ++_nextOrderId;
        }

        public bool ProcessPayment()
        {
            if (paymentStrategy != null)
            {
                paymentStrategy.Pay(total);
                return true;
            }
            else
            {
                Console.WriteLine("Please choose a payment mode first");
                return false;
            }
        }

        public abstract string GetTypeName();

        // Properties and Methods
        public int OrderId => orderId;

        public User User
        {
            get => user;
            set => user = value;
        }

        public Restaurant Restaurant
        {
            get => restaurant;
            set => restaurant = value;
        }

        public List<MenuItem> Items
        {
            get => items;
            set
            {
                items = value;
                total = 0;
                foreach (var item in items)
                {
                    total += item.Price;
                }
            }
        }

        public IPaymentStrategy PaymentStrategy
        {
            set => paymentStrategy = value;
        }

        public string Scheduled
        {
            get => scheduled;
            set => scheduled = value;
        }

        public double Total
        {
            get => total;
            set => total = value;
        }
    }
}
