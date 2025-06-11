namespace ObserverDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("Coder Army");

            Subscriber subscriber1 = new Subscriber("Tarun", channel);
            Subscriber subscriber2 = new Subscriber("Varun", channel);

            channel.Subscribe(subscriber1);
            channel.Subscribe(subscriber2);

            channel.UploadVideo("Obserable Design Pattern");

            channel.Unsubscribe(subscriber2);

            channel.UploadVideo("Decorator Design Pattern");
        }
    }
}
