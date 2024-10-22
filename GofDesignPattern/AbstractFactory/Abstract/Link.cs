namespace GofDesignPattern.AbstractFactory.Abstract
{
    public abstract class Link : Item
    {
        protected string url;

        protected Link(string caption, string url) : base(caption)
        {
            this.url = url;
        }
    }
}
