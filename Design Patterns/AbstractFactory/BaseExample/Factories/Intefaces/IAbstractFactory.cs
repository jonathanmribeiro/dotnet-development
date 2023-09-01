using AbstractFactory.BaseExample.Products.Interfaces;

namespace AbstractFactory.BaseExample.Factories.Intefaces
{
    internal interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }
}
