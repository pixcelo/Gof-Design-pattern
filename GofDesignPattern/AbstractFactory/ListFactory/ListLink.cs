using GofDesignPattern.AbstractFactory.Abstract;

namespace GofDesignPattern.AbstractFactory.ListFactory
{
    public class ListLink : Link
    {
        public ListLink(string caption, string url) : base(caption, url)
        {
        }

        public override string MakeHTML()
        {
            return $" <li><a href=\"{base.url}\">{base.caption}</a></li>\n";
        }
    }
}
