using StrategyDP.Interfaces;

namespace StrategyDP.Strategys
{
    public class NoTalk : ITalkableRobot
    {
        public void Talk()
        {
            Console.WriteLine("No Talk");
        }
    }
}
