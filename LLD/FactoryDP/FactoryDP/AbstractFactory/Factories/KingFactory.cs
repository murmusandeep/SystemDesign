using FactoryDP.AbstractFactory.Factories.Interfaces;
using FactoryDP.AbstractFactory.Interfaces;

namespace FactoryDP.AbstractFactory.Factories
{
    public class KingFactory : IMealFactory
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

        public IGralicBread CreateGarlicBread(string type)
        {
            if (type.ToLower() == "basic")
            {
                return new BasicWheatGarlicBread();
            }
            else if (type.ToLower() == "premium")
            {
                return new PremiumWheatGarlicBread();
            }
            else
            {
                throw new ArgumentException("You have enter wrong type");
            }
        }
    }
}
