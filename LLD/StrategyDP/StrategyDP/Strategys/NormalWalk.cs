using StrategyDP.Interfaces;

namespace StrategyDP.Strategys
{
    public class NormalWalk : IWalkableRobot
    {
        public void Walk()
        {
            Console.WriteLine("Normal Walk");
        }
    }
}
