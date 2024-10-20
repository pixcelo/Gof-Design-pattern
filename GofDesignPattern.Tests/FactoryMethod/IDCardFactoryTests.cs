using GofDesignPattern.FactoryMethod;

namespace GofDesignPattern.Tests.FactoryMethod
{
    public class IDCardFactoryTests
    {
        [Fact]
        public void OkCreate()
        {
            // Arrange
            Factory factory = new IDCardFactory();
            Product card1 = factory.Create("Alice");
            Product card2 = factory.Create("Bob");
            Product card3 = factory.Create("Charlie");
            
            // internalで宣言しているため、Factory経由でしかインスタンス生成できない
            //var card = new IDCard("Tom");

            // Act
            card1.Use();
            card2.Use();
            card3.Use();
        }
    }
}
