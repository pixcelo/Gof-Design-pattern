using GofDesignPattern.Proxy;

namespace GofDesignPattern.Tests.Proxy
{
    public class PrinterProxyTests
    {
        [Fact]
        public void OkPrint()
        {
            // Arrange
            IPrintable printer = new PrinterProxy("Alice");

            // Act
            Console.WriteLine($"My name is {printer.GetPrinterName()}.");
            printer.SetPrinterName("Bob");
            Console.WriteLine($"My name is {printer.GetPrinterName()}.");
            printer.Print("Hello, world.");
        }
    }
}
