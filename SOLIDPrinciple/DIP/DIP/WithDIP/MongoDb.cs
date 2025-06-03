using DIP.WithDIP.Interfaces;

namespace DIP.WithDIP
{
    public class MongoDb : IDatabase
    {
        public void Save(string user)
        {
            Console.WriteLine("Save to Mongo Db " + user);
        }
    }
}
