using DIP.WithDIP.Interfaces;

namespace DIP.WithDIP
{
    public class UserService
    {
        private readonly IDatabase _database;

        public UserService(IDatabase database)
        {
            _database = database;
        }

        public void storeUser(string user)
        {
            _database.Save(user);
        }
    }
}
