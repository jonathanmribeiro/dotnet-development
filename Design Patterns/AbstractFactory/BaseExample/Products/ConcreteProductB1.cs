using AbstractFactory.BaseExample.Products.Interfaces;

namespace AbstractFactory.BaseExample.Products
{
    internal class ConcreteProductB1 : IAbstractProductB
    {
        public string UsefulFunctionB()
            => $"UsefullFunctionB from ConcreteProductB1";

        public string AnotherUsefulFunctionB()
            => $"AnotherUsefulFunctionB from ConcreteProductB1";
    }
}
