using AbstractFactory.AnimalsExample.Factories.Interfaces;
using AbstractFactory.AnimalsExample.Products;
using AbstractFactory.AnimalsExample.Products.Interfaces;

namespace AbstractFactory.AnimalsExample.Factories
{
    internal class AnimalFactory1 : IAnimalFactory
    {
        public IAnimal CreateBird()
            => new Eagle();

        public IAnimal CreateMammal()
            => new Lion();

        public IAnimal CreateReptile()
            => new Snake();
    }
}
