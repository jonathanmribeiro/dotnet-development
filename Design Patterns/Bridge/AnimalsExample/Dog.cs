namespace Bridge.AnimalsExample
{
    internal class Dog: AbstractAnimal
    {
        public Dog(IAction action) : base(action) { }

        public override void MakeSound()
        {
            Console.WriteLine("Dog makes a sound.");
            _action.PerformAction();
        }
    }
}
