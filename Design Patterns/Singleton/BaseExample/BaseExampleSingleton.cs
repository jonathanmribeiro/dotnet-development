namespace Singleton.BaseExample
{
    internal sealed class BaseExampleSingleton
    {
        private static BaseExampleSingleton? _instance;

        private BaseExampleSingleton()
        {

        }

        public static BaseExampleSingleton GetInstance()
        {
            _instance ??= new BaseExampleSingleton();
            return _instance;
        }
    }
}
