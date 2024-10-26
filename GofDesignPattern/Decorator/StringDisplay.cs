namespace GofDesignPattern.Decorator
{
    public class StringDisplay : Display
    {
        /// <summary>
        /// 表示文字列
        /// </summary>
        private readonly string value;

        public StringDisplay(string value)
        {
            this.value = value;
        }

        public override int GetColumns()
        {
            return this.value.Length;
        }

        public override int GetRows()
        {
            return 1; // 行数は1
        }

        public override string GetRowText(int row)
        {
            if (row != 0) throw new IndexOutOfRangeException();

            return this.value;
        }
    }
}
