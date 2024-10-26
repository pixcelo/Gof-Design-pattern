namespace GofDesignPattern.ChainOfResponsibility
{
    /// <summary>
    /// トラブルを解決するための連鎖を作るための抽象クラス
    /// </summary>
    public abstract class Support
    {
        /// <summary>
        /// このトラブルの解決者の名前
        /// </summary>
        private readonly string name;

        /// <summary>
        /// たらい回しの先
        /// </summary>
        private Support? next;

        public Support(string name)
        {
            this.name = name;
            this.next = null;
        }

        /// <summary>
        /// たらい回しの先を決める
        /// </summary>
        /// <param name="next"></param>
        /// <returns></returns>
        public Support SetNext(Support next)
        {
            this.next = next;
            return next;
        }

        /// <summary>
        /// トラブル解決の手順を定める
        /// </summary>
        /// <param name="trouble"></param>
        public void SupportTrouble(Trouble trouble)
        {
            if (this.Resolve(trouble))
            {
                this.Done(trouble);
            }
            else if (this.next != null)
            {
                this.next.SupportTrouble(trouble);
            }
            else
            {
                this.Fail(trouble);
            }
        }

        public override string ToString()
        {
            return $"[{this.name}]";
        }

        /// <summary>
        /// 解決しようとする
        /// </summary>
        /// <param name="trouble"></param>
        /// <returns></returns>
        protected abstract bool Resolve(Trouble trouble);

        /// <summary>
        /// 解決した
        /// </summary>
        /// <param name="trouble"></param>
        protected void Done(Trouble trouble)
        {
            Console.WriteLine($"{trouble} is resolved by {this}.");
        }

        /// <summary>
        /// 解決しなかった
        /// </summary>
        /// <param name="trouble"></param>
        protected void Fail(Trouble trouble)
        {
            Console.WriteLine($"{trouble} cannot be resolved.");
        }
    }
}
