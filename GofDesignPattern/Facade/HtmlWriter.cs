namespace GofDesignPattern.Facade
{
    public class HtmlWriter
    {
        private readonly StreamWriter writer;

        public HtmlWriter(StreamWriter writer)
        {
            this.writer = writer;
        }

        /// <summary>
        /// タイトルの出力
        /// </summary>
        /// <param name="title"></param>
        public void Title(string title)
        {
            this.writer.WriteLine($"<!DOCTYPE html>");
            this.writer.WriteLine($"<html>");
            this.writer.WriteLine($"<head>");
            this.writer.WriteLine($"<title>{title}</title>");
            this.writer.WriteLine($"</head>");
            this.writer.WriteLine($"<body>");
            this.writer.WriteLine($"<h1>{title}</h1>");
        }

        /// <summary>
        /// 段落の出力
        /// </summary>
        /// <param name="msg"></param>
        public void Paragraph(string msg)
        {
            this.writer.WriteLine($"<p>{msg}</p>");
        }

        /// <summary>
        /// リンクの出力
        /// </summary>
        /// <param name="href"></param>
        /// <param name="caption"></param>
        public void Link(string href, string caption)
        {
            this.Paragraph($"<a href=\"{href}\">{caption}</a>");
        }

        /// <summary>
        /// メールアドレスの出力
        /// </summary>
        /// <param name="mailAddress"></param>
        /// <param name="username"></param>
        public void MailTo(string mailAddress, string username)
        {
            this.Link($"mailto:{mailAddress}", username);
        }

        public void Close()
        {
            this.writer.WriteLine($"</body>");
            this.writer.WriteLine($"</html>");
            this.writer.Close();
        }
    }
}
