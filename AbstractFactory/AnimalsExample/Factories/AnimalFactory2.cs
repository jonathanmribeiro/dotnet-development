using AbstractFactory.AnimalsExample.Factories.Interfaces;
using AbstractFactory.AnimalsExample.Products.Interfaces;
using AbstractFactory.AnimalsExample.Products;

namespace AbstractFactory.AnimalsExample.Factories
{
    internal class AnimalFactory2 : IAnimalFactory
    {
        public IAnimal CreateBird()
            => new Penguin();

        public IAnimal CreateMammal()
            => new Elephant();

        public IAnimal CreateReptile()
            => new Turtle();
    }
}
