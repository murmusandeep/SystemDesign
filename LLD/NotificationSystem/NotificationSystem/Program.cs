using NotificationSystem.Decorators;
using NotificationSystem.Engines;
using NotificationSystem.Interfaces;
using NotificationSystem.Observers;
using NotificationSystem.Services;
using NotificationSystem.Strategies;

namespace NotificationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var notificationService = NotificationService.Instance;

            //var observable = notificationService.GetObservable();

            //var logger = new Logger(observable);
            //var engine = new NotificationEngine(observable);

            //engine.AddNotificationStrategy(new EmailStrategy("random.person@gmail.com"));
            //engine.AddNotificationStrategy(new SMSStrategy("+91 9876543210"));
            //engine.AddNotificationStrategy(new PopUpStrategy());

            //observable.AddObserver(logger);
            //observable.AddObserver(engine);

            //INotification notification = new SimpleNotification("Your order has been shipped!");
            //notification = new TimestampDecorator(notification);
            //notification = new SignatureDecorator(notification, "Customer Care");

            //notificationService.SendNotification(notification);

            var service = NotificationService.Instance;

            var logger = new Logger();
            var engine = new NotificationEngine();
            engine.AddNotificationStrategy(new EmailStrategy("random.person@gmail.com"));
            engine.AddNotificationStrategy(new SMSStrategy("+91 9876543210"));
            engine.AddNotificationStrategy(new PopUpStrategy());

            INotification notification = new SimpleNotification("Your order has been shipped!");
            notification = new TimestampDecorator(notification);
            notification = new SignatureDecorator(notification, "Customer Care");

            service.SendNotification(notification);
        }
    }
}
