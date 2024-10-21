using System.Text;

namespace GofDesignPattern.Builder
{
    public class TextBuilder : Builder
    {
        private readonly StringBuilder sb = new StringBuilder();

        public override void MakeTitle(string title)
        {
            this.sb.Append("==============================\n");
            this.sb.Append(" [");
            this.sb.Append(title);
            this.sb.Append("] \n\n");
        }

        public override void MakeString(string str)
        {
            this.sb.Append("■");
            this.sb.Append(str);
            this.sb.Append("\n\n");
        }
        
        public override void MakeItems(string[] items)
        {
            foreach (var item in items)
            {
                this.sb.Append(" ・");
                this.sb.Append(item);
                this.sb.Append("\n");
            }
            this.sb.Append("\n");
        }

        public override void Close()
        {
            this.sb.Append("==============================\n");
        }

        public string GetTextResult()
        {
            return this.sb.ToString();
        }
    }
}
