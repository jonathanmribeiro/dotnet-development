namespace ProxyDesignPattern.BaseExample
{
    internal class Client
    {
        public void ClientCode(ISubject subject)
        {
            subject.Request();
        }
    }
}
