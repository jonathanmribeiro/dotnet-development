using FlyweightDesignPattern.AnimalsExample.ConcreteFlyweights;
using FlyweightDesignPattern.AnimalsExample.FlyweightInterface;

namespace FlyweightDesignPattern.AnimalsExample.Factory
{
    internal class Zoo
    {
        private readonly Dictionary<string, IAnimal> _animals = new();

        public IAnimal GetAnimal(string species)
        {
            if (!_animals.ContainsKey(species))
            {
                switch (species.ToLower())
                {
                    case "lion":
                        _animals[species] = new LionFlyweight();
                        break;
                    case "elephant":
                        _animals[species] = new ElephantFlyweight();
                        break;
                    default:
                        throw new ArgumentException("Unknown species.");
                }
            }

            return _animals[species];
        }
    }
}
