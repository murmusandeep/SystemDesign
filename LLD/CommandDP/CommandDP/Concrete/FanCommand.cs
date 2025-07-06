using CommandDP.Interface;
using CommandDP.Receivers;

namespace CommandDP.Concrete
{
    public class FanCommand : ICommand
    {
        private readonly Fan _fan;

        public FanCommand(Fan fan)
        {
            _fan = fan;
        }

        public void Execute() => _fan.On();
        public void Undo() => _fan.Off();
    }
}
