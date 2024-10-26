namespace GofDesignPattern.ChainOfResponsibility
{
    /// <summary>
    /// 何も解決しないクラス
    /// </summary>
    public class NoSupport : Support
    {
        public NoSupport(string name) : base(name)
        {
        }
                
        protected override bool Resolve(Trouble trouble)
        {
            return false;
        }
    }
}
