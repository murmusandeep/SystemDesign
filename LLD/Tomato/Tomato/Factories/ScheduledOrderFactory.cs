using Tomato.Models;
using Tomato.Strategies;

namespace Tomato.Factories
{
    public class ScheduledOrderFactory : IOrderFactory
    {
        private readonly string scheduleTime;

        public ScheduledOrderFactory(string scheduleTime)
        {
            this.scheduleTime = scheduleTime;
        }

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
            order.Scheduled = scheduleTime;
            order.Total = totalCost;

            return order;
        }
    }
}
