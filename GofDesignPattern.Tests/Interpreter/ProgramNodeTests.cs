using GofDesignPattern.Interpreter;

namespace GofDesignPattern.Tests.Interpreter
{
    public class ProgramNodeTests
    {
        [Fact]
        public void OkParse()
        {            
            foreach (var text in File.ReadAllLines(Path.GetFileName("program.txt")))
            {
                // Arrange
                Console.WriteLine($"text = \"{text}\""); 
                Node node = new ProgramNode();

                // Act
                node.Parse(new Context(text));
                Console.WriteLine($"node = {node}");
            }
        }
    }
}
