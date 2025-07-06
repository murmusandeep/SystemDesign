using NotificationSystem.Interfaces;

namespace NotificationSystem.Decorators
{
    public class TimestampDecorator : NotificationDecorator
    {
        public TimestampDecorator(INotification notification) : base(notification) { }

        public override string GetContent()
        {
            return "[2025-04-13 14:22:00] " + _notification.GetContent();
        }
    }
}
