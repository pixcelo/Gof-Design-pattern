namespace GofDesignPattern.Bridge
{
    public class StringDisplayImpl : DisplayImpl
    {
        private readonly string str;
        private readonly int width;

        public StringDisplayImpl(string str)
        {
            this.str = str;
            this.width = str.Length;
        }

        public override void RawOpen()
        {
            this.PrintLine();
        }

        public override void RawPrint()
        {
            Console.WriteLine($"|{this.str}|");
        }

        public override void RawClose()
        {
            this.PrintLine();
        }

        private void PrintLine()
        {
            Console.Write("+");
            for (int i = 0; i < this.width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
