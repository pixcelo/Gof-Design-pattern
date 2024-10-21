using GofDesignPattern.Prototype;
using System.Text;

namespace GofDesignPattern.Tests.Prototype
{
    public class MessageBoxTests
    {
        [Fact]
        public void OkUse()
        {
            // Arrange
            var messageBox = new MessageBox('*');
            var expected = new StringBuilder();            
            expected.AppendLine("*******");
            expected.AppendLine("* Hello *");
            expected.AppendLine("*******");

            using (var sw = new StringWriter())
            {
                // Act
                Console.SetOut(sw);
                messageBox.Use("Hello");

                // Assert
                Assert.Equal(expected.ToString(), sw.ToString());
            }
        }

        [Fact]
        public void OkClone()
        {
            // Arrange
            var messageBox = new MessageBox('*');
            var expected = messageBox;

            // Act
            var actual = messageBox.Clone();

            // Assert
            Assert.Equivalent(expected, actual);
        }
    }
}
