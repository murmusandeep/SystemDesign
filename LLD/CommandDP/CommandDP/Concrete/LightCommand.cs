using CommandDP.Interface;
using CommandDP.Receivers;

namespace CommandDP.Concrete
{
    public class LightCommand : ICommand
    {
        private readonly Light _light;

        public LightCommand(Light light)
        {
            _light = light;
        }

        public void Execute() => _light.On();
        public void Undo() => _light.Off();
    }
}
