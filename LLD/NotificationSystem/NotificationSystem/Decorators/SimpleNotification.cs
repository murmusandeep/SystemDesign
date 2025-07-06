using NotificationSystem.Interfaces;

namespace NotificationSystem.Decorators
{
    public class SimpleNotification : INotification
    {
        private string _text;

        public SimpleNotification(string msg)
        {
            _text = msg;
        }

        public string GetContent()
        {
            return _text;
        }
    }
}
