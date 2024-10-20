using GofDesignPattern.Adapter;
using Moq;

namespace GofDesignPattern.Tests.Adapter
{
    /// <summary>
    /// 移譲を使ったAdapterパターンのテスト
    /// </summary>
    public class PrintBannerTransferTests
    {
        private readonly Mock<Banner> banner = new Mock<Banner>("Hello");

        [Fact]
        public void OkPrintWeak()
        {
            // Arrange
            IPrint printBanner = new PrintBannerTransfer(banner.Object);

            // Act
            printBanner.PrintWeak();
        }

        [Fact]
        public void OkPrintStrong()
        {
            // Arrange
            IPrint printBanner = new PrintBannerTransfer(banner.Object);

            // Act
            printBanner.PrintStrong();
        }
    }
}
