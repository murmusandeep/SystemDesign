using StrategyDP.Interfaces;

namespace StrategyDP
{
    public class Robot
    {
        private ITalkableRobot _talkableRobot;
        private IWalkableRobot _walkableRobot;
        private IFlyableRobot _flyableRobot;
        private IProjectable _projectable;

        public Robot() { }

        public Robot(ITalkableRobot talkableRobot, IWalkableRobot walkableRobot, IFlyableRobot flyableRobot, IProjectable projectable)
        {
            _talkableRobot = talkableRobot;
            _walkableRobot = walkableRobot;
            _flyableRobot = flyableRobot;
            _projectable = projectable;
        }

        public void SetRobot(ITalkableRobot talkableRobot, IWalkableRobot walkableRobot, IFlyableRobot flyableRobot, IProjectable projectable)
        {
            _talkableRobot = talkableRobot;
            _walkableRobot = walkableRobot;
            _flyableRobot = flyableRobot;
            _projectable = projectable;
        }

        public void Talk()
        {
            _talkableRobot.Talk();
        }

        public void Walk()
        {
            _walkableRobot.Walk();
        }

        public void Fly()
        {
            _flyableRobot.Fly();
        }

        public void Projection()
        {
            _projectable.Projection();
        }
    }
}
