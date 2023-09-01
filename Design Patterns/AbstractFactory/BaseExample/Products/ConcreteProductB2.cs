using AbstractFactory.BaseExample.Products.Interfaces;

namespace AbstractFactory.BaseExample.Products
{
    internal class ConcreteProductB2 : IAbstractProductB
    {
        public string UsefulFunctionB()
            => $"UsefullFunctionB from ConcreteProductB2";

        public string AnotherUsefulFunctionB()
            => $"AnotherUsefulFunctionB from ConcreteProductB2";
    }
}
