using GofDesignPattern.AbstractFactory;

namespace GofDesignPattern.Tests.AbstractFactory
{
    public class ListFactoryServiceTests
    {
        [Fact]
        public void OkUseFactory()
        {
            // Arrange
            var listFactoryService = new ListFactoryService();

            // Act
            listFactoryService.UseFactory();                        
        }
    }
}
