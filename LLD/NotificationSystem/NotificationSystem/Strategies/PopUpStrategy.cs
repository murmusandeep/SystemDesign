using NotificationSystem.Interfaces;

namespace NotificationSystem.Strategies
{
    public class PopUpStrategy : INotificationStrategy
    {
        public void SendNotification(string content)
        {
            Console.WriteLine("Sending Popup Notification: \n" + content);
        }
    }
}
