namespace GofDesignPattern.Command
{
    public class MacroCommand : ICommand
    {
        private readonly Queue<ICommand> commands = new Queue<ICommand>();

        public void Execute()
        {
            foreach (var command in this.commands)
            {
                command.Execute();
            }
        }

        public void Append(ICommand command)
        {
            this.commands.Enqueue(command);
        }

        public void Undo()
        {
            if (this.commands.Count > 0)
            {
                this.commands.Dequeue();
            }
        }

        public void Clear()
        {
            this.commands.Clear();
        }
    }
}
