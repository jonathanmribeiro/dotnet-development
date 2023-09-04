using DecoratorDesignPattern.AnimalsExample.BaseComponent;

namespace DecoratorDesignPattern.AnimalsExample.ConcreteComponents
{
    internal class Dog : IAnimal
    {
        public string Name => "Dog";

        public void MakeSound()
        {
            Console.WriteLine("Dog sounds");
        }
    }
}
