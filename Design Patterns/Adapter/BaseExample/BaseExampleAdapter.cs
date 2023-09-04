namespace Adapter.BaseExample
{
    internal class BaseExampleAdapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public BaseExampleAdapter(Adaptee adaptee)
            => _adaptee = adaptee;

        public string GetRequest()
            => _adaptee.GetSpecificRequest();
    }
}
