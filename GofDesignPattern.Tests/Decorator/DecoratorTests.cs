using GofDesignPattern.Decorator;

namespace GofDesignPattern.Tests.Decorator
{
    public class DecoratorTests
    {
        [Fact]
        public void DecoratorTest1()
        {
            // Arrange
            Display d1 = new StringDisplay("Hello, world.");
            Display d2 = new SideBorder(d1, '#');
            Display d3 = new FullBorder(d2);

            // Act
            d1.Show();
            d2.Show();
            d3.Show();
        }

        [Fact]
        public void DecoratorTest2()
        {
            // Arrange
            Display d4 = new SideBorder(
                new FullBorder(
                    new FullBorder(
                        new SideBorder(
                            new FullBorder(
                                new StringDisplay("Hello, world.")
                            ),
                            '*'
                        )
                    )
                ),
                '/'
            );

            // Act
            d4.Show();
        }
    }
}
