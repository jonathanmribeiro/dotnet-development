using AbstractFactory.BaseExample.Products.Interfaces;

namespace AbstractFactory.BaseExample.Products
{
    internal class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
            => $"UsefullFunctionA from ConcreteProductA1";
    }
}
