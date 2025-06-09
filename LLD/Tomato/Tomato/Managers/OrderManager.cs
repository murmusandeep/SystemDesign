using Tomato.Models;

namespace Tomato.Managers
{
    public class OrderManager
    {
        private static readonly Lazy<OrderManager> _instance = new Lazy<OrderManager>(() => new OrderManager());

        private readonly List<Order> orders = new List<Order>();

        private OrderManager()
        {
            // Private constructor
        }

        public static OrderManager Instance => _instance.Value;

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public void ListOrders()
        {
            Console.WriteLine("\n--- All Orders ---");
            foreach (var order in orders)
            {
                Console.WriteLine($"{order.GetTypeName()} order for {order.User.Name} | Total: ₹{order.Total} | At: {order.Scheduled}");
            }
        }
    }
}
