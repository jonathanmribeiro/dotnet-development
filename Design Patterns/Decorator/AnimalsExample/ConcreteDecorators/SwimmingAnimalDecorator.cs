using DecoratorDesignPattern.AnimalsExample.BaseComponent;
using DecoratorDesignPattern.AnimalsExample.BaseDecorator;

namespace DecoratorDesignPattern.AnimalsExample.ConcreteDecorators
{
    internal class SwimmingAnimalDecorator : AnimalDecorator
    {
        public override string Name => _animal.Name + " in water";
        
        public SwimmingAnimalDecorator(IAnimal animal) : base(animal) { }
        
        public void Swim()
            => Console.WriteLine($"{Name} is swimming!");
    }
}
