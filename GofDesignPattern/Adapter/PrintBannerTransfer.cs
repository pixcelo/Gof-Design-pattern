namespace GofDesignPattern.Adapter
{
    public class PrintBannerTransfer : IPrint
    {
        private readonly Banner banner;

        public PrintBannerTransfer(Banner banner)
        {
            this.banner = banner;
        }

        public void PrintWeak()
        {
            this.banner.ShowWithParen();
        }

        public void PrintStrong()
        {
            this.banner.ShowWithAster();
        }
    }
}
