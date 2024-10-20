namespace GofDesignPattern.Adapter
{
    public class PrintBanner : Banner, IPrint
    {
        public PrintBanner(string value) : base(value)
        {
        }

        public void PrintWeak()
        {
            base.ShowWithParen();
        }

        public void PrintStrong()
        {
            base.ShowWithAster();
        }
    }
}
