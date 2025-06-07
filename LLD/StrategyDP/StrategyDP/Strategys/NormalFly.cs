using StrategyDP.Interfaces;

namespace StrategyDP.Strategys
{
    public class NormalFly : IFlyableRobot
    {
        public void Fly()
        {
            Console.WriteLine("Normal Fly");
        }
    }
}
