using GofDesignPattern.TemplateMethod;

namespace GofDesignPattern.Tests.TemplateMethod
{
    public class CharDisplayTests
    {
        /// <summary>
        /// 抽象クラスの型に代入して、正しく動作するようにする（リスコフの置換原則）
        /// </summary>
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
