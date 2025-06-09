using Tomato.Models;
using Tomato.Strategies;

namespace Tomato
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Simulating a happy flow
            // Create TomatoApp Object
            TomatoApp tomato = new TomatoApp();

            // Simulate a user coming in (Happy Flow)
            User user = new User(101, "Aditya", "Delhi");
            Console.WriteLine("User: " + user.Name + " is active.");

            // User searches for restaurants by location
            List<Restaurant> restaurantList = tomato.SearchRestaurants("Delhi");

            if (restaurantList.Count == 0)
            {
                Console.WriteLine("No restaurants found!");
                return;
            }

            Console.WriteLine("Found Restaurants:");
            foreach (var restaurant in restaurantList)
            {
                Console.WriteLine(" - " + restaurant.Name);
            }

            // User selects a restaurant
            tomato.SelectRestaurant(user, restaurantList[0]);
            Console.WriteLine("Selected restaurant: " + restaurantList[0].Name);

            // User adds items to the cart
            tomato.AddToCart(user, "P1");
            tomato.AddToCart(user, "P2");

            tomato.PrintUserCart(user);

            // User checkout the cart
            Order order = tomato.CheckoutNow(user, "Delivery", new UpiPaymentStrategy("1234567890"));

            // User pays for the cart. If payment is successful, notification is sent.
            tomato.PayForOrder(user, order);
        }
    }
}
