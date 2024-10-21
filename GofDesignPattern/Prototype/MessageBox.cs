namespace GofDesignPattern.Prototype
{
    public class MessageBox : IProduct
    {
        private readonly char decoChar;

        public MessageBox(char decoChar)
        {
            this.decoChar = decoChar;
        }

        public void Use(string value)
        {
            int decoLen = 1 + value.Length + 1;
            for (int i = 0; i < decoLen; i++)
            {
                Console.Write(this.decoChar);
            }
            Console.WriteLine();
            Console.WriteLine($"{this.decoChar} {value} {this.decoChar}");
            for (int i = 0; i < decoLen; i++)
            {
                Console.Write(this.decoChar);
            }
            Console.WriteLine();
        }

        public　object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
