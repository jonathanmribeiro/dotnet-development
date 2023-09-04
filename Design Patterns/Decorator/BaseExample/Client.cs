namespace DecoratorDesignPattern.BaseExample
{
    internal class Client
    {
        public void ClientCode(Component component)
            => Console.WriteLine($"RESULT: {component.Operation()}");
    }
}
