namespace Adapter.AnimalsExample
{
    internal class LionAdapter : IAnimal
    {
        private readonly Lion _lion;

        public LionAdapter(Lion lion)
        {
            _lion = lion;
        }

        public void MakeSound()
        {
            _lion.Roar();
        }
    }
}
