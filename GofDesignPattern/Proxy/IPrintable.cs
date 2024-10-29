namespace GofDesignPattern.Proxy
{
    public interface IPrintable
    {
        void SetPrinterName(string name);

        string GetPrinterName();

        void Print(string text);
    }
}
