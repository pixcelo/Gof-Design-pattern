namespace GofDesignPattern.Flyweight
{
    public class BigString
    {
        /// <summary>
        /// 大きな「文字列」の配列
        /// </summary>
        private readonly BigChar[] bigChars;

        public BigString(string str)
        {
            var factory = BigCharFactory.GetInstance();
            this.bigChars = new BigChar[str.Length];
            for (var i = 0; i < str.Length; i++)
            {
                this.bigChars[i] = factory.GetBigChar(str[i]);
            }
        }

        public void Print()
        {
            foreach (var bigChar in this.bigChars)
            {
                bigChar.Print();
            }
        }
    }
}
