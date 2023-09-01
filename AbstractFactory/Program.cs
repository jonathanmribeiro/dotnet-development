using AbstractFactory.AnimalsExample.Factories;
using AbstractFactory.AnimalsExample.Factories.Interfaces;
using AbstractFactory.BaseExample.Factories;
using AbstractFactory.BaseExample.Factories.Intefaces;
using AbstractFactory.BaseExample.Products.Interfaces;

Console.Write("Animals examples\n");
BaseExamplesClient(new ConcreteFactory1());
BaseExamplesClient(new ConcreteFactory2());

Console.Write("\nAnimals examples\n");
AnimalsExample(new AnimalFactory1());
AnimalsExample(new AnimalFactory2());

void BaseExamplesClient(IAbstractFactory factory)
{
    IAbstractProductA productA = factory.CreateProductA();
    IAbstractProductB productB = factory.CreateProductB();

    Console.WriteLine(productA.UsefulFunctionA());
    Console.WriteLine(productB.UsefulFunctionB());
    Console.WriteLine(productB.AnotherUsefulFunctionB());
}

void AnimalsExample(IAnimalFactory factory)
{
    Console.WriteLine(factory.CreateMammal().Speak());
    Console.WriteLine(factory.CreateBird().Speak());
    Console.WriteLine(factory.CreateReptile().Speak());
}