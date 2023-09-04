using DecoratorDesignPattern.AnimalsExample.BaseComponent;

namespace DecoratorDesignPattern.AnimalsExample.ConcreteComponents
{
    internal class Eagle : IAnimal
    {
        public string Name => "Eagle";

        public void MakeSound()
        {
            Console.WriteLine("Eagle sounds");
        }
    }
}
