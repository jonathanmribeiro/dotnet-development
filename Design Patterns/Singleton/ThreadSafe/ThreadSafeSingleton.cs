namespace Singleton.ThreadSafe
{
    internal class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton? _instance;
        private static readonly object _lock = new();
        public string? Value { get; set; }

        private ThreadSafeSingleton() { }

        public static ThreadSafeSingleton GetInstance(string value)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new ThreadSafeSingleton { Value = value };
                }
            }

            return _instance;
        }
    }
}
