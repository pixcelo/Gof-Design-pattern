namespace GofDesignPattern.ChainOfResponsibility
{
    public class Trouble
    {
        /// <summary>
        /// トラブル番号
        /// </summary>
        private readonly int number;

        public Trouble(int number)
        {
            this.number = number;
        }

        public int GetNumber()
        {
            return this.number;
        }

        public override string ToString()
        {
            return $"[Trouble {this.number}]";
        }
    }
}
