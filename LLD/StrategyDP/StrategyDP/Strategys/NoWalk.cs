using StrategyDP.Interfaces;

namespace StrategyDP.Strategys
{
    public class NoWalk : IWalkableRobot
    {
        public void Walk()
        {
            Console.WriteLine("No Walk");
        }
    }
}
