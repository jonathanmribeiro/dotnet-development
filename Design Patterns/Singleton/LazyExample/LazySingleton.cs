namespace Singleton.LazyExample
{
    internal sealed class LazySingleton
    {
        private static readonly Lazy<LazySingleton> _lazyInstance = new(() => new LazySingleton());
        public static LazySingleton Instance => _lazyInstance.Value;

        private LazySingleton() { }

        public string? StringValue { get; set; }

        internal string GetStringValue(string defaultValue)
        {
            StringValue ??= defaultValue;
            return StringValue;
        }
    }
}
