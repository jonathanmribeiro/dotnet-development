using FlyweightDesignPattern.AnimalsExample.FlyweightInterface;

namespace FlyweightDesignPattern.AnimalsExample.ConcreteFlyweights
{
    internal class LionFlyweight : IAnimal
    {
        private const string _speciesName = "Lion";
        private const string _commonSound = "Roar";

        public void Display(string name, string behavior)
        {
            Console.WriteLine($"Name: {name}, Species: {_speciesName}, Sound: {_commonSound}, Behavior: {behavior}");
        }
    }
}
