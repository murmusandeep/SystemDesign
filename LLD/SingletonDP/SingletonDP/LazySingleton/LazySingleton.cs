namespace SingletonDP.LazySingleton
{
    public class LazySingleton
    {
        private static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton());

        private LazySingleton()
        {
            Console.WriteLine("Lazy Eager Singleton Constructor Called");
        }

        public static LazySingleton Instance => _instance.Value;
    }

}
