namespace GofDesignPattern.Strategy
{
    public class Player
    {
        private readonly string name;
        private readonly IStrategy strategy;
        private int winCount;
        private int loseCount;
        private int gameCount;

        public Player(string name, IStrategy strategy)
        {
            this.name = name;
            this.strategy = strategy;
        }

        /// <summary>
        /// 戦略にお伺いを立てて次の手を決める
        /// </summary>
        /// <returns></returns>
        public Hands NextHands()
        {
            return this.strategy.NextHand();
        }

        /// <summary>
        /// 勝った
        /// </summary>
        public void Win()
        {
            this.strategy.Study(true);
            this.winCount++;
            this.gameCount++;
        }

        /// <summary>
        /// 負けた
        /// </summary>
        public void Lose()
        {
            this.strategy.Study(false);
            this.loseCount++;
            this.gameCount++;
        }

        /// <summary>
        /// 引き分け
        /// </summary>
        public void Even()
        {
            this.gameCount++;
        }

        public override string ToString()
        {
            return $"[{this.name}:{this.gameCount} games, {this.winCount} win, {this.loseCount} lose]";
        }
    }
}
