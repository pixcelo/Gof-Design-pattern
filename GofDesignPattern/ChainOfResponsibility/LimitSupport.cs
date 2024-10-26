namespace GofDesignPattern.ChainOfResponsibility
{
    /// <summary>
    /// limitで指定された番号未満のトラブルを解決するクラス
    /// </summary>
    public class LimitSupport : Support
    {
        private readonly int limit;

        public LimitSupport(string name, int limit) : base(name)
        {
            this.limit = limit;
        }

        protected override bool Resolve(Trouble trouble)
        {
            return trouble.GetNumber() < this.limit;
        }
    }    
}
