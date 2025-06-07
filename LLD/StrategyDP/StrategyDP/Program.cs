using StrategyDP.Strategys;

namespace StrategyDP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Robot companionRobot = new Robot(new NormalTalk(), new NormalWalk(), new NoFly(), new CompanionProjection());

            companionRobot.Talk();
            companionRobot.Walk();
            companionRobot.Fly();
            companionRobot.Projection();
        }
    }
}
