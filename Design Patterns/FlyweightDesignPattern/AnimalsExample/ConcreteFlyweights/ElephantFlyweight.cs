using FlyweightDesignPattern.AnimalsExample.FlyweightInterface;

namespace FlyweightDesignPattern.AnimalsExample.ConcreteFlyweights
{
    internal class ElephantFlyweight: IAnimal
    {
        private const string _speciesName = "Elephant";
        private const string _commonSound = "Trumpet";

        public void Display(string name, string behavior)
        {
            Console.WriteLine($"Name: {name}, Species: {_speciesName}, Sound: {_commonSound}, Behavior: {behavior}");
        }
    }
}
