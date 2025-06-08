namespace SingletonDP.EagerSingleton
{
    public class EagerSingleton
    {
        private static readonly EagerSingleton _instance = new EagerSingleton();
        private EagerSingleton()
        {
            Console.WriteLine("Eager Singleton Constructor Called");
        }
        public static EagerSingleton Instance => _instance;
    }

}
