using GofDesignPattern.Bridge;

namespace GofDesignPattern.Tests.Bridge
{
    public class DisplayTests
    {
        [Fact]
        public void UseDisplayTest()
        {
            // Arrange
            Display display = new Display(new StringDisplayImpl("Hello, Japan."));

            // Act
            display.DisplayMethod();
        }

        [Fact]
        public void UseDisplay2Test()
        {
            // Arrange
            Display display = new CountDisplay(new StringDisplayImpl("Hello, World."));

            // Act
            display.DisplayMethod();            
        }

        [Fact]
        public void UseCountDisplayTest()
        {
            // Arrange
            CountDisplay display = new CountDisplay(new StringDisplayImpl("Hello, Universe."));

            // Act
            display.DisplayMethod();
        }

        [Fact]
        public void UseMultiDisplayTest()
        {
            // Arrange
            CountDisplay display = new CountDisplay(new StringDisplayImpl("Hello, Universe."));

            // Act
            display.MultiDisplay(5);
        }
    }
}
