using NotificationSystem.Interfaces;

namespace NotificationSystem.Decorators
{
    public class SignatureDecorator : NotificationDecorator
    {
        private string _signature;

        public SignatureDecorator(INotification notification, string signature) : base(notification)
        {
            _signature = signature;
        }

        public override string GetContent()
        {
            return _notification.GetContent() + "\n-- " + _signature + "\n\n";
        }
    }
}
