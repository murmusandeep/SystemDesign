using FactoryDP.FactoryMethod.Interfaces;

namespace FactoryDP.FactoryMethod.Factories
{
    public class KingBurger : IBurgerFactory
    {
        public IBurger CreateBurger(string type)
        {
            if (type.ToLower() == "basic")
            {
                return new BasicWheatBurger();
            }
            else if (type.ToLower() == "standard")
            {
                return new StandardWheatBurger();
            }
            else if (type.ToLower() == "premium")
            {
                return new PremiumWheatBurger();
            }
            else
            {
                throw new ArgumentException("You have enter wrong type");
            }
        }
    }
}
