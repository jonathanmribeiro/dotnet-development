using FactoryMethod.AnimalsExample.Products;

namespace FactoryMethod.AnimalsExample.Creators
{
    internal class ElephantCreator : AnimalCreator
    {
        public override IAnimal CreateAnimal()
            => new Elephant();
    }
}
