using FactoryMethod.AnimalsExample.Products;

namespace FactoryMethod.AnimalsExample.Creators
{
    internal class PenguinCreator : AnimalCreator
    {
        public override IAnimal CreateAnimal()
            => new Penguin();
    }
}
