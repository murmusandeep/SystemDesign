using StrategyDP.Interfaces;

namespace StrategyDP.Strategys
{
    public class NoFly : IFlyableRobot
    {
        public void Fly()
        {
            Console.WriteLine("No Fly");
        }
    }
}
