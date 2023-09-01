using AbstractFactory.AnimalsExample.Products.Interfaces;
using System.Reflection;

namespace AbstractFactory.AnimalsExample.Products
{
    internal class Snake : IAnimal
    {
        public string Speak()
            => $"{MethodBase.GetCurrentMethod()?.DeclaringType?.Name} sounds";
    }
}
