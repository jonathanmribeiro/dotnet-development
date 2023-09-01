using AbstractFactory.AnimalsExample.Products.Interfaces;
using System.Reflection;

namespace AbstractFactory.AnimalsExample.Products
{
    internal class Elephant : IAnimal
    {
        public string Speak()
            => $"{MethodBase.GetCurrentMethod()?.DeclaringType?.Name} sounds";
    }
}
