using NotificationSystem.Interfaces;

namespace NotificationSystem.Decorators
{
    public abstract class NotificationDecorator : INotification
    {
        protected INotification _notification;

        protected NotificationDecorator(INotification notification)
        {
            _notification = notification;
        }

        public abstract string GetContent();
    }
}
