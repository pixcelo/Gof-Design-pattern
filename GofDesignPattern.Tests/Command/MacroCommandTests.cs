using GofDesignPattern.Command;

namespace GofDesignPattern.Tests.Command
{
    public class MacroCommandTests
    {
        [Fact]
        public void MacroCommandTest()
        {
            // Arrange
            var history = new MacroCommand();
            history.Append(new PrintCommand("Hello, World!"));
            history.Append(new PrintCommand("This is a command pattern example."));
            history.Append(new PrintCommand("Goodbye!"));

            // Act
            history.Execute();
            history.Undo();
            history.Execute();
        }
    }
}
