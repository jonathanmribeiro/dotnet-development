using DecoratorDesignPattern.AnimalsExample.BaseComponent;

namespace DecoratorDesignPattern.AnimalsExample.ConcreteComponents
{
    internal class Cat : IAnimal
    {
        public string Name => "Cat";

        public void MakeSound()
        {
            Console.WriteLine("Cat sounds");
        }
    }
}
