using FlyweightDesignPattern.BaseExample.Container;
using FlyweightDesignPattern.BaseExample.Context;

namespace FlyweightDesignPattern.BaseExample.Factory
{
    internal class FlyweightFactory
    {
        private readonly List<Tuple<Flyweight, string>> _flyweights = new();

        public FlyweightFactory(params Car[] args)
        {
            foreach (var elem in args)
            {
                _flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), GetKey(elem)));
            }
        }

        public string GetKey(Car key)
        {
            List<string> elements = new()
            {
                key.Model,
                key.Color,
                key.Company
            };

            if (key.Owner != null && key.Number != null)
            {
                elements.Add(key.Number);
                elements.Add(key.Owner);
            }

            elements.Sort();

            return string.Join("_", elements);
        }

        public Flyweight GetFlyweight(Car sharedState)
        {
            string key = GetKey(sharedState);

            if (_flyweights.Where(t => t.Item2 == key).Count() == 0)
            {
                Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
                _flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
            }
            return _flyweights.Where(t => t.Item2 == key).FirstOrDefault().Item1;
        }

        public void ListFlyweights()
        {
            var count = _flyweights.Count;
            Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
            foreach (var flyweight in _flyweights)
            {
                Console.WriteLine(flyweight.Item2);
            }
        }
    }
}
