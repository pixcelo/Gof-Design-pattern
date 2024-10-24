namespace GofDesignPattern.Strategy
{
    public class ProbStrategy : IStrategy
    {
        private Random random;
        private int prevHandValue = 0;
        private int currentHandValue = 0;
        private int[,] history = new int[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };

        public ProbStrategy(int seed)
        {
            this.random = new Random(seed);
        }

        /// <summary>
        /// 過去の勝敗から次の手を決定する
        /// </summary>
        /// <returns></returns>
        public Hands NextHand()
        {
            int bet = random.Next(GetSum(currentHandValue));
            int handValue = 0;
            if (bet < this.history[currentHandValue, 0])
            {
                handValue = 0;
            }
            else if (bet < this.history[currentHandValue, 0] + this.history[currentHandValue, 1])
            {
                handValue = 1;
            }
            else
            {
                handValue = 2;
            }
            this.prevHandValue = this.currentHandValue;
            this.currentHandValue = handValue;
            return Hand.GetHand(handValue);
        }

        private int GetSum(int handValue)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += this.history[handValue, i];
            }
            return sum;
        }

        public void Study(bool win)
        {
            if (win)
            {
                this.history[this.prevHandValue, this.currentHandValue]++;
            }
            else
            {
                this.history[this.prevHandValue, (this.currentHandValue + 1) % 3]++;
                this.history[this.prevHandValue, (this.currentHandValue + 2) % 3]++;
            }
        }
    }
}
