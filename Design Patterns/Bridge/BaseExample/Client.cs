namespace Bridge.BaseExample
{
    internal class Client
    {
        public void ClientCode(Abstraction abstraction)
            => Console.Write(abstraction.Operation());
    }
}
