using GofDesignPattern.Facade;

namespace GofDesignPattern.Tests.Facade
{
    public class FacadeTests
    {
        [Fact]
        public void Test()
        {
            // Arrange & Act
            PageMaker.MakeWelcomePage("example@eg.com", "welcome.html");
        }
    }
}
