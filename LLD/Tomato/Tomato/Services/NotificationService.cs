using Tomato.Models;

namespace Tomato.Services
{
    public static class NotificationService
    {
        public static void Notify(Order order)
        {
            Console.WriteLine($"\nNotification: New {order.GetTypeName()} order placed!");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Order ID: {order.OrderId}");
            Console.WriteLine($"Customer: {order.User.Name}");
            Console.WriteLine($"Restaurant: {order.Restaurant.Name}");
            Console.WriteLine("Items Ordered:");

            List<MenuItem> items = order.Items;
            foreach (var item in items)
            {
                Console.WriteLine($"   - {item.Name} (₹{item.Price})");
            }

            Console.WriteLine($"Total: ₹{order.Total}");
            Console.WriteLine($"Scheduled For: {order.Scheduled}");
            Console.WriteLine("Payment: Done");
            Console.WriteLine("---------------------------------------------");
        }
    }
}
