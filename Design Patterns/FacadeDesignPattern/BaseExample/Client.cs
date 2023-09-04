namespace FacadeDesignPattern.BaseExample
{
    internal class Client
    {
        public static void ClientCode(Facade facade)
        {
            Console.WriteLine(facade.Operation());
        }
    }
}
