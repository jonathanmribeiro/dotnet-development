namespace Bridge.AnimalsExample
{
    internal abstract class AbstractAnimal
    {
        protected IAction _action;

        protected AbstractAnimal(IAction action)
        {
            _action = action;
        }

        public abstract void MakeSound();
    }
}
