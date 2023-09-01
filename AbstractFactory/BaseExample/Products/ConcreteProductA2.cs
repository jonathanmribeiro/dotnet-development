using AbstractFactory.BaseExample.Products.Interfaces;

namespace AbstractFactory.BaseExample.Products
{
    internal class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
            => $"UsefullFunctionA from ConcreteProductA2";
    }
}
