namespace CommandDesignPattern.AnimalsExample.Commands
{
    internal class GroomCommand : IAnimalCommand
    {
        private readonly AnimalReceiver _animalReceiver;

        public GroomCommand(AnimalReceiver animalReceiver)
            => _animalReceiver = animalReceiver;

        public void Execute()
            => _animalReceiver.Groom();
    }
}
