namespace ProxyDesignPattern.BaseExample
{
    internal class RealSubject : ISubject
    {
        public void Request()
            => Console.WriteLine("RealSubject: Handling Request.");
    }
}
