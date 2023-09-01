using AbstractFactory.BaseExample.Factories.Intefaces;
using AbstractFactory.BaseExample.Products;
using AbstractFactory.BaseExample.Products.Interfaces;

namespace AbstractFactory.BaseExample.Factories
{
    internal class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
            => new ConcreteProductA1();

        public IAbstractProductB CreateProductB()
            => new ConcreteProductB1();
    }
}
