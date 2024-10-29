namespace GofDesignPattern.Command
{
    public class PrintCommand : ICommand
    {
        private readonly string message;

        public PrintCommand(string message)
        {
            this.message = message;
        }

        public void Execute()
        {
            Console.WriteLine(this.message);
        }
    }
}
