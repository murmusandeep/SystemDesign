using Tomato.Models;
using Tomato.Strategies;
using Tomato.Utils;

namespace Tomato.Factories
{
    public class NowOrderFactory : IOrderFactory
    {
        public Order CreateOrder(
            User user,
            Cart cart,
            Restaurant restaurant,
            List<MenuItem> menuItems,
            IPaymentStrategy paymentStrategy,
            double totalCost,
            string orderType)
        {
            Order order;

            if (orderType == "Delivery")
            {
                var deliveryOrder = new DeliveryOrder();
                deliveryOrder.UserAddress = user.Address;
                order = deliveryOrder;
            }
            else
            {
                var pickupOrder = new PickupOrder();
                pickupOrder.RestaurantAddress = restaurant.Location;
                order = pickupOrder;
            }

            order.User = user;
            order.Restaurant = restaurant;
            order.Items = menuItems;
            order.PaymentStrategy = paymentStrategy;
            order.Scheduled = TimeUtils.GetCurrentTime();
            order.Total = totalCost;

            return order;
        }
    }
}
