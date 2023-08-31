using FactoryMethod.AnimalsExample.Products;

namespace FactoryMethod.AnimalsExample.Creators
{
    internal class LionCreator: AnimalCreator
    {
        public override IAnimal CreateAnimal()
            => new Lion();
    }
}
