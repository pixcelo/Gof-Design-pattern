namespace GofDesignPattern.Strategy
{
    public class Hand
    {
        private readonly string name;
        private readonly int handValue;

        /// <summary>
        /// 手の値から定数を得るための配列
        /// </summary>
        private readonly static Hands[] hands =
        {
            Hands.ROCK,
            Hands.SCISSORS,
            Hands.PAPER
        };

        public int HandValue => this.handValue;

        public Hand(Hands h)
        {
            this.name = h.ToString();
            this.handValue = Convert.ToInt32(h);
        }

        /// <summary>
        /// 手の値からEnum定数を得る
        /// </summary>
        /// <param name="handValue"></param>
        /// <returns></returns>
        public static Hands GetHand(int handValue)
        {
            return hands[handValue];
        }

        public bool IsStrongerThan(Hand h)
        {
            return this.Fight(h) == 1;
        }

        public bool IsWeakerThan(Hand h)
        {
            return this.Fight(h) == -1;
        }

        /// <summary>
        /// 引き分けは0、勝ちは1、負けは-1を返す
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        private int Fight(Hand h)
        {
            if (this.name == h.ToString())
            {
                return 0;
            }
            else if ((this.handValue + 1) % 3 == h.HandValue)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return this.name;
        }              
    }
}
