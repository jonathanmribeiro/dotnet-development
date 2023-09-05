namespace CommandDesignPattern.AnimalsExample.Commands
{
    internal class TrainCommand : IAnimalCommand
    {
        private readonly AnimalReceiver _animalReceiver;

        public TrainCommand(AnimalReceiver animalReceiver)
            => _animalReceiver = animalReceiver;

        public void Execute()
            => _animalReceiver.Train();
    }
}
