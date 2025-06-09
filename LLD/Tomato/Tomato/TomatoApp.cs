using Tomato.Factories;
using Tomato.Managers;
using Tomato.Models;
using Tomato.Services;
using Tomato.Strategies;

namespace Tomato
{
    public class TomatoApp
    {
        public TomatoApp()
        {
            InitializeRestaurants();
        }

        public void InitializeRestaurants()
        {
            var restaurant1 = new Restaurant("Bikaner", "Delhi");
            restaurant1.AddMenuItem(new MenuItem("P1", "Chole Bhature", 120));
            restaurant1.AddMenuItem(new MenuItem("P2", "Samosa", 15));

            var restaurant2 = new Restaurant("Haldiram", "Kolkata");
            restaurant2.AddMenuItem(new MenuItem("P1", "Raj Kachori", 80));
            restaurant2.AddMenuItem(new MenuItem("P2", "Pav Bhaji", 100));
            restaurant2.AddMenuItem(new MenuItem("P3", "Dhokla", 50));

            var restaurant3 = new Restaurant("Saravana Bhavan", "Chennai");
            restaurant3.AddMenuItem(new MenuItem("P1", "Masala Dosa", 90));
            restaurant3.AddMenuItem(new MenuItem("P2", "Idli Vada", 60));
            restaurant3.AddMenuItem(new MenuItem("P3", "Filter Coffee", 30));

            var restaurantManager = RestaurantManager.Instance;
            restaurantManager.AddRestaurant(restaurant1);
            restaurantManager.AddRestaurant(restaurant2);
            restaurantManager.AddRestaurant(restaurant3);
        }

        public List<Restaurant> SearchRestaurants(string location)
        {
            return RestaurantManager.Instance.SearchByLocation(location);
        }

        public void SelectRestaurant(User user, Restaurant restaurant)
        {
            Cart cart = user.Cart;
            cart.SetRestaurant(restaurant);
        }

        public void AddToCart(User user, string itemCode)
        {
            var restaurant = user.Cart.GetRestaurant();
            if (restaurant == null)
            {
                Console.WriteLine("Please select a restaurant first.");
                return;
            }

            foreach (var item in restaurant.GetMenu())
            {
                if (item.Code == itemCode)
                {
                    user.Cart.AddItem(item);
                    break;
                }
            }
        }

        public Order CheckoutNow(User user, string orderType, IPaymentStrategy paymentStrategy)
        {
            return Checkout(user, orderType, paymentStrategy, new NowOrderFactory());
        }

        public Order CheckoutScheduled(User user, string orderType, IPaymentStrategy paymentStrategy, string scheduleTime)
        {
            return Checkout(user, orderType, paymentStrategy, new ScheduledOrderFactory(scheduleTime));
        }

        public Order Checkout(User user, string orderType, IPaymentStrategy paymentStrategy, IOrderFactory orderFactory)
        {
            if (user.Cart.IsEmpty())
                return null;

            Cart userCart = user.Cart;
            Restaurant orderedRestaurant = userCart.GetRestaurant();
            List<MenuItem> itemsOrdered = userCart.GetItems();
            double totalCost = userCart.GetTotalCost();

            Order order = orderFactory.CreateOrder(user, userCart, orderedRestaurant, itemsOrdered, paymentStrategy, totalCost, orderType);
            OrderManager.Instance.AddOrder(order);
            return order;
        }

        public void PayForOrder(User user, Order order)
        {
            bool isPaymentSuccess = order.ProcessPayment();

            if (isPaymentSuccess)
            {
                NotificationService.Notify(order);
                user.Cart.Clear();
            }
        }

        public void PrintUserCart(User user)
        {
            Console.WriteLine("Items in cart:");
            Console.WriteLine("------------------------------------");
            foreach (var item in user.Cart.GetItems())
            {
                Console.WriteLine($"{item.Code} : {item.Name} : ₹{item.Price}");
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Grand total : ₹{user.Cart.GetTotalCost()}");
        }
    }
}
