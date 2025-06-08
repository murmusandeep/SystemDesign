namespace SingletonDP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var simpleSingleton1 = SimpleSingleton.Singleton.Instance;
            var simpleSingleton2 = SimpleSingleton.Singleton.Instance;

            if (simpleSingleton1 == simpleSingleton2)
            {
                Console.WriteLine("Both are Simple Singleton equal");
            }

            var threadSingleton1 = ThreadSingleton.ThreadSingleton.Instance;
            var threadSingleton2 = ThreadSingleton.ThreadSingleton.Instance;

            if (threadSingleton1 == threadSingleton2)
            {
                Console.WriteLine("Both are Thread Singleton equal");
            }

            var eagerSingleton1 = EagerSingleton.EagerSingleton.Instance;
            var eagerSingleton2 = EagerSingleton.EagerSingleton.Instance;

            if (eagerSingleton1 == eagerSingleton2)
            {
                Console.WriteLine("Both are Eager Singleton equal");
            }

            var lazyeagerSingleton1 = LazySingleton.LazySingleton.Instance;
            var lazyEagerSingleton2 = LazySingleton.LazySingleton.Instance;

            if (lazyeagerSingleton1 == lazyEagerSingleton2)
            {
                Console.WriteLine("Both are Lazy Eager Singleton equal");
            }
        }
    }
}
