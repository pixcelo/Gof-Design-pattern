namespace GofDesignPattern.ChainOfResponsibility
{
    /// <summary>
    /// 奇数番号のトラブルを解決するクラス
    /// </summary>
    public class OddSupport : Support
    {
        public OddSupport(string name) : base(name)
        {
        }

        protected override bool Resolve(Trouble trouble)
        {
            return trouble.GetNumber() % 2 == 1;
        }
    }
}
