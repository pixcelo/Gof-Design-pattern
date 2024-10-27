using GofDesignPattern.Observer;

namespace GofDesignPattern.Tests.Observer
{
    public class ObserverTests
    {
        [Fact]
        public void ObserverTest()
        {
            // Arrange
            NumberGenerator generator = new RandomNumberGenerator();
            IObserver observer1 = new DigitObserver();
            IObserver observer2 = new GraphObserver();
            generator.AddObserver(observer1);
            generator.AddObserver(observer2);

            // Act
            generator.Execute();
        }
    }
}
