namespace CommandDesignPattern.AnimalsExample.Commands
{
    internal class FeedCommand : IAnimalCommand
    {
        private readonly AnimalReceiver _animalReceiver;

        public FeedCommand(AnimalReceiver animalReceiver)
            => _animalReceiver = animalReceiver;

        public void Execute()
            => _animalReceiver.Feed();
    }
}
