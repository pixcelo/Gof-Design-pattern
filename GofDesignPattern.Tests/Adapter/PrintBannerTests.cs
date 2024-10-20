using GofDesignPattern.Adapter;

namespace GofDesignPattern.Tests.Adapter
{
    /// <summary>
    /// 継承を使ったAdapterパターンのテスト
    /// </summary>
    public class PrintBannerTests
    {
        /// <summary>
        /// printBannerを実行するクラスは、実装の詳細を知らなくても使える
        /// </summary>
        [Fact]
        public void OkPrintWeak()
        {
            // Arrange
            IPrint printBanner = new PrintBanner("Hello");

            // Act
            printBanner.PrintWeak();
        }

        [Fact]
        public void OkPrintStrong()
        {
            // Arrange
            IPrint printBanner = new PrintBanner("Hello");

            // Act
            printBanner.PrintStrong();
        }
    }
}
