using FactoryMethod.AnimalsExample.Products;

namespace FactoryMethod.AnimalsExample.Creators
{
    internal abstract class AnimalCreator
    {
        public abstract IAnimal CreateAnimal();

        public string MakeSound()
        {
            IAnimal animal = CreateAnimal();

            return animal.MakeSound();
        }
    }
}
