using GofDesignPattern.AbstractFactory.Abstract;
using System.Text;

namespace GofDesignPattern.AbstractFactory.ListFactory
{
    public class ListPage : Page
    {
        public ListPage(string title, string author) : base(title, author)
        {            
        }

        public override string MakeHTML()
        {
            var sb = new StringBuilder();
            sb.Append($"<html><head><title>{base.title}</title></head>\n");
            sb.Append($"<body>\n");
            sb.Append($"<h1>{base.title}</h1>\n");
            sb.Append($"<ul>\n");
            foreach (var item in base.content)
            {
                sb.Append(item.MakeHTML());
            }
            sb.Append($"</ul>\n");
            sb.Append($"<hr><address>{base.author}</address>\n");
            sb.Append($"</body></html>\n");
            return sb.ToString();
        }
    }
}
