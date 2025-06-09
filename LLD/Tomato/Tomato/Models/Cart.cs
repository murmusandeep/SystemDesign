namespace Tomato.Models
{
    public class Cart
    {
        private Restaurant _restaurant;
        private List<MenuItem> _items = new List<MenuItem>();

        public Cart()
        {
            _restaurant = null;
        }

        public void AddItem(MenuItem item)
        {
            if (_restaurant == null)
            {
                Console.Error.WriteLine("Cart: Set a restaurant before adding items.");
                return;
            }
            _items.Add(item);
        }

        public double GetTotalCost()
        {
            double sum = 0;
            foreach (var item in _items)
            {
                sum += item.Price;
            }
            return sum;
        }

        public bool IsEmpty()
        {
            return _restaurant == null || _items.Count == 0;
        }

        public void Clear()
        {
            _items.Clear();
            _restaurant = null;
        }

        public void SetRestaurant(Restaurant restaurant)
        {
            _restaurant = restaurant;
        }

        public Restaurant GetRestaurant()
        {
            return _restaurant;
        }

        public List<MenuItem> GetItems()
        {
            return _items;
        }
    }
}
