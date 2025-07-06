using CommandDP.Interface;

namespace CommandDP
{
    public class RemoteController
    {
        private const int NumButtons = 4;
        private ICommand[] _buttons;
        private bool[] _buttonPressed;

        public RemoteController()
        {
            _buttons = new ICommand[NumButtons];
            _buttonPressed = new bool[NumButtons];
        }

        public void SetCommand(int idx, ICommand cmd)
        {
            if (idx >= 0 && idx < NumButtons)
            {
                _buttons[idx] = cmd;
                _buttonPressed[idx] = false;
            }
        }

        public void PressButton(int idx)
        {
            if (idx >= 0 && idx < NumButtons && _buttons[idx] != null)
            {
                if (!_buttonPressed[idx])
                {
                    _buttons[idx].Execute();
                }
                else
                {
                    _buttons[idx].Undo();
                }
                _buttonPressed[idx] = !_buttonPressed[idx];
            }
            else
            {
                Console.WriteLine($"No command assigned at button {idx}");
            }
        }
    }
}
