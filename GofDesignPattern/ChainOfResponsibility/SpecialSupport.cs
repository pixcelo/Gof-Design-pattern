namespace GofDesignPattern.ChainOfResponsibility
{
    /// <summary>
    /// 指定した番号のトラブルを解決するクラス
    /// </summary>
    public class SpecialSupport : Support
    {
        private readonly int number;

        public SpecialSupport(string name, int number) : base(name)
        {
            this.number = number;
        }

        protected override bool Resolve(Trouble trouble)
        {
            return trouble.GetNumber() == this.number;
        }
    }
}
