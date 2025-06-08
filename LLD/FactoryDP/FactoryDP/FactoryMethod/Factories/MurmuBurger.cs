using FactoryDP.FactoryMethod.Interfaces;

namespace FactoryDP.FactoryMethod.Factories
{
    public class MurmuBurger : IBurgerFactory
    {
        public IBurger CreateBurger(string type)
        {
            if (type.ToLower() == "basic")
            {
                return new BasicBurger();
            }
            else if (type.ToLower() == "standard")
            {
                return new StandardBurger();
            }
            else if (type.ToLower() == "premium")
            {
                return new PremiumBurger();
            }
            else
            {
                throw new ArgumentException("You have enter wrong type");
            }
        }
    }
}
