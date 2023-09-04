using DecoratorDesignPattern.AnimalsExample.BaseComponent;

namespace DecoratorDesignPattern.AnimalsExample.BaseDecorator
{
    internal abstract class AnimalDecorator: IAnimal
    {
        protected IAnimal _animal;

        public abstract string Name { get; }

        protected AnimalDecorator(IAnimal animal)
            => _animal = animal;

        public void MakeSound()
            => _animal.MakeSound();
    }
}
