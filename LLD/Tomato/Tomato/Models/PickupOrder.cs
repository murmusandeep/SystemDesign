namespace Tomato.Models
{
    public class PickupOrder : Order
    {
        private string restaurantAddress;

        public PickupOrder()
        {
            restaurantAddress = string.Empty;
        }

        public override string GetTypeName()
        {
            return "Pickup";
        }

        public string RestaurantAddress
        {
            get => restaurantAddress;
            set => restaurantAddress = value;
        }
    }
}
