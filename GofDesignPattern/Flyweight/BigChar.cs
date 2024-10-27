using System.Text;

namespace GofDesignPattern.Flyweight
{
    /// <summary>
    /// 大きな文字を表すクラス
    /// </summary>
    public class BigChar
    {
        /// <summary>
        /// 文字の名前
        /// </summary>
        private readonly char charName;

        /// <summary>
        /// 大きな文字を表現する文字列（'#', '.', '\n'の列）
        /// </summary>
        private readonly string fontData;

        public BigChar(char charName)
        {
            this.charName = charName;

            try
            {
                var fileName = Path.Combine(AppContext.BaseDirectory, "Flyweight", $"big{charName}.txt");
                var sb = new StringBuilder();
                foreach (var line in File.ReadAllLines(fileName))
                {
                    sb.AppendLine(line);
                }
                this.fontData = sb.ToString();
            }
            catch (Exception)
            {
                this.fontData = charName + "?";
            }
        }

        /// <summary>
        /// 大きな文字を表示する
        /// </summary>
        public void Print()
        {
            Console.WriteLine(this.fontData);
        }
    }
}
