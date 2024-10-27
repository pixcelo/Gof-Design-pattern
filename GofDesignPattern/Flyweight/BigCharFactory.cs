namespace GofDesignPattern.Flyweight
{
    public class BigCharFactory
    {
        /// <summary>
        /// すでに作成したBigCharのインスタンスを管理する
        /// </summary>
        private readonly Dictionary<char, BigChar> pool = new Dictionary<char, BigChar>();

        private static readonly BigCharFactory singleton = new BigCharFactory();

        private BigCharFactory()
        {
        }

        public static BigCharFactory GetInstance()
        {
            return singleton;
        }

        /// <summary>
        /// BigCharのインスタンス生成（共有）
        /// </summary>
        /// <param name="charName"></param>
        /// <returns></returns>
        public BigChar GetBigChar(char charName)
        {
            if (!this.pool.ContainsKey(charName))
            {
                // ここでBigCharのインスタンスを生成
                this.pool[charName] = new BigChar(charName);
            }

            return this.pool[charName];
        }
    }
}
