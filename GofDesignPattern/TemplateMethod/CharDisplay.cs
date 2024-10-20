namespace GofDesignPattern.TemplateMethod
{
    public class CharDisplay : AbstractDisplay
    {
        private readonly char ch;

        public CharDisplay(char ch)
        {
            this.ch = ch;
        }

        public override void Open()
        {
            // 開始文字列として"<<"を表示
            Console.Write("<<");
        }

        public override void Print()
        {
            // フィールドで指定されている文字を1回表示
            Console.Write(this.ch.ToString());
        }

        public override void Close()
        {
            // 終了文字列として">>"を表示
            Console.Write(">>");
        }
    }
}
