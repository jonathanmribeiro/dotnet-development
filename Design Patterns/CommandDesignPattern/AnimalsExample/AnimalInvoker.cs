using CommandDesignPattern.AnimalsExample.Commands;

namespace CommandDesignPattern.AnimalsExample
{
    internal class AnimalInvoker
    {
        private readonly List<IAnimalCommand> _commands = new();

        public void AddCommand(IAnimalCommand command)
            => _commands.Add(command);

        public void ExecuteCommands()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void ClearCommands()
            => _commands.Clear();
    }
}
