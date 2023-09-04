using DecoratorDesignPattern.AnimalsExample.BaseComponent;
using DecoratorDesignPattern.AnimalsExample.BaseDecorator;

namespace DecoratorDesignPattern.AnimalsExample.ConcreteDecorators
{
    internal class FlyingAnimalDecorator : AnimalDecorator
    {
        public override string Name => _animal.Name + " with wings";

        public FlyingAnimalDecorator(IAnimal animal) : base(animal) { }

        public void Fly()
            => Console.WriteLine($"{Name} is flying!");
    }
}
