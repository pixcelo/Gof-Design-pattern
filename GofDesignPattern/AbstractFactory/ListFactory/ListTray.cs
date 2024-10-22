using GofDesignPattern.AbstractFactory.Abstract;
using System.Text;

namespace GofDesignPattern.AbstractFactory.ListFactory
{
    public class ListTray : Tray
    {
        public ListTray(string caption) : base(caption)
        {
        }

        public override string MakeHTML()
        {
            var sb = new StringBuilder();
            sb.Append($"<li>\n{base.caption}\n<ul>\n");
            foreach (Item item in base.tray)
            {
                sb.Append(item.MakeHTML());
            }
            sb.Append("</ul>\n</li>\n");
            return sb.ToString();
        }
    }
}
