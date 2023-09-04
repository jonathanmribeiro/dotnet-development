namespace DecoratorDesignPattern.AnimalsExample.BaseComponent
{
    internal interface IAnimal
    {
        string Name { get; }
        void MakeSound();
    }
}
