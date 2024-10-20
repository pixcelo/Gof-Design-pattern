using GofDesignPattern.TemplateMethod;

namespace GofDesignPattern.Tests.TemplateMethod
{
    public class StringDisplayTests
    {
        [Fact]
        public void OkDisplay()
        {
            // Arrange
            AbstractDisplay stringDisplay = new StringDisplay("Hello, world.");

            // Act
            stringDisplay.Display();

            /*
                +-------------+
                |Hello, world.|
                |Hello, world.|
                |Hello, world.|
                |Hello, world.|
                |Hello, world.|
                +-------------+
            */
        }
    }
}
