namespace GofDesignPattern.Strategy
{
    public class WinningStrategy : IStrategy
    {
        private Random random;
        private bool won = false;
        private Hands prevHand;

        public WinningStrategy(int seed)
        {
            this.random = new Random(seed);
        }

        /// <summary>
        /// 前回の勝負に勝っていた場合、同じ手を出す
        /// </summary>
        /// <returns></returns>
        public Hands NextHand()
        {
            if (!won)
            {
                this.prevHand = Hand.GetHand(random.Next(3));
            }
            return this.prevHand;
        }

        public void Study(bool win)
        {
            this.won = win;
        }
    }
}
