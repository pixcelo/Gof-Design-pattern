using GofDesignPattern.Builder;
using System.Text;

namespace GofDesignPattern.Tests.Builder
{
    public class DirectorTests
    {
        [Fact]
        public void OkUseTextBuilder()
        {
            // Arrange
            var textBuilder = new TextBuilder();
            var director = new Director(textBuilder);
            director.Construct();            

            var expected = new StringBuilder();
            expected.Append("==============================\n");
            expected.Append(" [Greeting] \n\n");
            expected.Append("■General greetings\n\n");
            expected.Append(" ・How are you?\n");
            expected.Append(" ・Hello.\n");
            expected.Append(" ・Hi.\n\n");
            expected.Append("■Greetings according to the time of day\n\n");
            expected.Append(" ・Good morning.\n");
            expected.Append(" ・Good afternoon.\n");
            expected.Append(" ・Good evening.\n\n");
            expected.Append("==============================\n");

            // Act
            var actual = textBuilder.GetTextResult();

            // Assert
            Assert.Equal(expected.ToString(), actual);
        }

        [Fact]
        public void OkUseHTMLBuilder()
        {
            // Arrange
            var htmlBuilder = new HTMLBuilder();
            var director = new Director(htmlBuilder);
            director.Construct();

            var expected = "Greeting.html";

            // Act
            var actual = htmlBuilder.GetHTMLResult();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
