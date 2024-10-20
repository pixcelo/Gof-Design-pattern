using GofDesignPattern.TemplateMethod;

namespace GofDesignPattern.Tests.TemplateMethod
{
    public class CharDisplayTests
    {
        [Fact]
        public void OkDisplay()
        {
            // Arrange
            AbstractDisplay charDisplay = new CharDisplay('H');

            // Act
            charDisplay.Display();

            // <<HHHHH>>
        }
    }
}
