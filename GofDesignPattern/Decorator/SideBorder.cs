namespace GofDesignPattern.Decorator
{
    public class SideBorder : Border
    {
        /// <summary>
        /// 飾り文字
        /// </summary>
        private readonly char borderChar;

        public SideBorder(Display display, char ch) : base(display)
        {
            this.borderChar = ch;
        }

        /// <summary>
        /// 文字数は中身の両側に飾り文字文を加えたもの
        /// </summary>
        /// <returns></returns>
        public override int GetColumns()
        {
            return 1 + this.display.GetColumns() + 1;
        }

        public override int GetRows()
        {
            return this.display.GetRows();
        }

        /// <summary>
        /// 指定行の内容は中身の両側に飾り文字をつけたもの
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public override string GetRowText(int row)
        {
            return this.borderChar + this.display.GetRowText(row) + this.borderChar;
        }
    }
}
