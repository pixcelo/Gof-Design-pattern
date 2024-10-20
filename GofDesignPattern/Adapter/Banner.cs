namespace GofDesignPattern.Adapter
{
    public class Banner
    {
        private readonly string value;

        public Banner(string value)
        {
            this.value = value;
        }

        public void ShowWithParen()
        {
            Console.WriteLine($"({value})");
        }

        public void ShowWithAster()
        {
            Console.WriteLine($"*{value}*");
        }
    }
}