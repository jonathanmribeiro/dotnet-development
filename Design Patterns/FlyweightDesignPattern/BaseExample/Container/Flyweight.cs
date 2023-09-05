using FlyweightDesignPattern.BaseExample.Context;
using Newtonsoft.Json;

namespace FlyweightDesignPattern.BaseExample.Container
{
    internal class Flyweight
    {
        private Car _sharedState;

        public Flyweight(Car uniqueState)
        {
            string s = JsonConvert.SerializeObject(_sharedState);
            string u = JsonConvert.SerializeObject(uniqueState);

            Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state");
        }

        public void Operation(Car uniqueState)
        {
            string s = JsonConvert.SerializeObject(this._sharedState);
            string u = JsonConvert.SerializeObject(uniqueState);
            Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
        }
    }
}
