using StrategyDP.Interfaces;

namespace StrategyDP.Strategys
{
    public class NormalTalk : ITalkableRobot
    {
        public void Talk()
        {
            Console.WriteLine("Normal Talk");
        }
    }
}
