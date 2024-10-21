using System.Text;

namespace GofDesignPattern.Builder
{
    public class HTMLBuilder : Builder
    {
        private string? fileName;
        private StringBuilder sb = new StringBuilder();

        public override void MakeTitle(string title)
        {
            this.fileName = title + ".html";
            this.sb.Append("<!DOCTYPE html>\n");
            this.sb.Append($"<html>\n<head><title>{title}</title></head>\n<body>");
            this.sb.Append($"<h1>{title}</h1>\n\n");
        }

        public override void MakeString(string str)
        {
            this.sb.Append($"<p>{str}</p>\n\n");
        }

        public override void MakeItems(string[] items)
        {
            this.sb.Append("<ul>");
            foreach (var item in items)
            {
                this.sb.Append($"<li>{item}</li>\n");
            }
            this.sb.Append("</ul>\n\n");
        }

        public override void Close()
        {
            this.sb.Append("</body></html>\n");

            try
            {
                using (var sw = new StreamWriter(this.fileName))
                {
                    sw.Write(this.sb.ToString());
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.StackTrace);                
            }
        }

        public string? GetHTMLResult()
        {
            return this.fileName;
        }
    }
}
