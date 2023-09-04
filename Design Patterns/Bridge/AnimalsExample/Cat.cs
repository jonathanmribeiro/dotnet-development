namespace Bridge.AnimalsExample
{
    internal class Cat: AbstractAnimal
    {
        public Cat(IAction action) : base(action) { }

        public override void MakeSound()
        {
            Console.WriteLine("Cat makes a sound");
            _action.PerformAction();
        }
    }
}
