using GofDesignPattern.Flyweight;

namespace GofDesignPattern.Tests.Flyweight
{
    public class FlyweightTests
    {
        [Fact]
        public void FlyweightTest()
        {
            // Arrange
            var bs = new BigString("1212123");

            // Act
            bs.Print();
        }
    }
}
