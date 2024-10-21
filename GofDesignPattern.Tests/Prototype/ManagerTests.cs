using GofDesignPattern.Prototype;

namespace GofDesignPattern.Tests.Prototype
{
    public class ManagerTests
    {
        [Fact]
        public void OkRegisterAndCreate()
        {
            // Arrange
            var manager = new Manager();
            var messageBox = new MessageBox('*');
            var showcase = new Dictionary<string, IProduct>
            {
                { "messageBox", messageBox }
            };

            // Act
            manager.Register("messageBox", messageBox);

            // Assert
            Assert.Equivalent(showcase["messageBox"], manager.Create("messageBox"));
        }
    }
}
