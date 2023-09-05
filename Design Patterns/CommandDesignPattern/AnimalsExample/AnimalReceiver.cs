namespace CommandDesignPattern.AnimalsExample
{
    internal class AnimalReceiver
    {
        private readonly string _name;

        public AnimalReceiver(string name)
            => _name = name;

        public void Feed()
            => Console.WriteLine($"{_name} is being fed.");

        public void Groom()
            => Console.WriteLine($"{_name} is being groomed.");

        public void Train()
            => Console.WriteLine($"{_name} is being trained.");
    }
}
