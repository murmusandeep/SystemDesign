using FactoryDP.FactoryMethod.Interfaces;

namespace FactoryDP.FactoryMethod
{
    public interface IBurgerFactory
    {
        public IBurger CreateBurger(string type);
    }
}
