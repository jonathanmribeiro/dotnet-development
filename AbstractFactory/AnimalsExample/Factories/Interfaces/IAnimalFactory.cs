using AbstractFactory.AnimalsExample.Products.Interfaces;

namespace AbstractFactory.AnimalsExample.Factories.Interfaces
{
    internal interface IAnimalFactory
    {
        IAnimal CreateMammal();
        IAnimal CreateBird();
        IAnimal CreateReptile();
    }
}
