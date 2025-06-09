namespace Tomato.Models
{
    public class Restaurant
    {
        private static int _nextRestaurantId = 0;
        public int RestaurantId { get; private set; }
        public string Name { get; set; }
        public string Location { get; set; }
        private List<MenuItem> _menu = new List<MenuItem>();

        public Restaurant(string name, string location)
        {
            Name = name;
            Location = location;
            RestaurantId = ++_nextRestaurantId;
        }

        public void AddMenuItem(MenuItem item)
        {
            _menu.Add(item);
        }

        public List<MenuItem> GetMenu()
        {
            return _menu;
        }
    }
}
