using Tomato.Models;

namespace Tomato.Managers
{
    public class RestaurantManager
    {
        private static readonly Lazy<RestaurantManager> _instance = new Lazy<RestaurantManager>(() => new RestaurantManager());

        private readonly List<Restaurant> restaurants = new List<Restaurant>();

        private RestaurantManager()
        {
            // Private constructor
        }

        public static RestaurantManager Instance => _instance.Value;

        public void AddRestaurant(Restaurant r)
        {
            restaurants.Add(r);
        }

        public List<Restaurant> SearchByLocation(string loc)
        {
            if (string.IsNullOrEmpty(loc))
                return new List<Restaurant>();

            loc = loc.ToLowerInvariant();

            return restaurants
                .Where(r => r.Location != null && r.Location.ToLowerInvariant() == loc)
                .ToList();
        }
    }
}
