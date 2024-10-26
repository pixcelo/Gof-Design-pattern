using System.Text;

namespace GofDesignPattern.Decorator
{
    public class FullBorder : Border
    {
        public FullBorder(Display display) : base(display)
        {
        }

        /// <summary>
        /// 文字数は中身の両側に飾り文字文を加えたもの
        /// </summary>
        /// <returns></returns>
        public override int GetColumns()
        {
            return 1 + this.display.GetColumns() + 1;
        }

        /// <summary>
        /// 行数は中身の行数と同じ
        /// </summary>
        /// <returns></returns>
        public override int GetRows()
        {
            return 1 + this.display.GetRows() + 1;
        }

        /// <summary>
        /// 指定行の内容は中身の両側に飾り文字をつけたもの
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>

        public override string GetRowText(int row)
        {
            if (row == 0)
            {
                // 上端の枠
                return "+" + this.MakeLine('-', this.display.GetColumns()) + "+";
            }
            else if (row == this.display.GetRows() + 1)
            {
                // 下端の枠
                return "+" + this.MakeLine('-', this.display.GetColumns()) + "+";
            }
            else
            {
                // それ以外
                return "|" + this.display.GetRowText(row - 1) + "|";
            }
        }

        /// <summary>
        /// 文字chをcount個連続させた文字列を作る
        /// </summary>
        /// <param name="ch"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        private string MakeLine(char ch, int count)
        {
            var buffer = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                buffer.Append(ch);
            }

            return buffer.ToString();
        }
    }
}
