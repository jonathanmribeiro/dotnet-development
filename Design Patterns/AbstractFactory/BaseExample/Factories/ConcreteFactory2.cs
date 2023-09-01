using AbstractFactory.BaseExample.Factories.Intefaces;
using AbstractFactory.BaseExample.Products;
using AbstractFactory.BaseExample.Products.Interfaces;

namespace AbstractFactory.BaseExample.Factories
{
    internal class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
            => new ConcreteProductA2();

        public IAbstractProductB CreateProductB()
            => new ConcreteProductB2();
    }
}
