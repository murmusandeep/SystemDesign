using Tomato.Models;
using Tomato.Strategies;

namespace Tomato.Factories
{
    public interface IOrderFactory
    {
        Order CreateOrder(
            User user,
            Cart cart,
            Restaurant restaurant,
            List<MenuItem> menuItems,
            IPaymentStrategy paymentStrategy,
            double totalCost,
            string orderType
        );
    }
}
