namespace GofDesignPattern.TemplateMethod
{
    public class StringDisplay : AbstractDisplay
    {
        private readonly string value;
        private readonly int width;

        public StringDisplay(string value)
        {
            this.value = value;
            this.width = value.Length;
        }

        public override void Open()
        {
            this.PrintLine();
        }       

        public override void Print()
        {
            Console.WriteLine("|" + this.value + "|");
        }

        public override void Close()
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
