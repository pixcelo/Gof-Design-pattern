using System.Text.RegularExpressions;

namespace GofDesignPattern.Interpreter
{
    /// <summary>
    /// 構文解析に必要なメソッドを提供するクラス
    /// </summary>
    public class Context
    {
        private readonly string[] tokens;
        private string lastToken;
        private int index;

        public Context(string text)
        {
            // 空白文字で分割してトークンを取得
            this.tokens = Regex.Split(text, @"\s+");
            this.index = 0;
            this.NextToken();
        }

        public string NextToken()
        {
            if (this.index < this.tokens.Length)
            {
                this.lastToken = this.tokens[this.index++];
            }
            else
            {
                this.lastToken = null;
            }

            return this.lastToken;
        }

        public string CurrentToken()
        {
            return this.lastToken;
        }

        public void SkipToken(string token)
        {
            if (this.CurrentToken() is null)
            {
                throw new ParseException($"Error: {token} is expected, but no more token is found.");
            }
            else if (this.CurrentToken() != token)
            {
                throw new ParseException($"Error: {token} is expected, but {this.lastToken} is found.");
            }

            this.NextToken();
        }

        public int CurrentNumber()
        {
            if (this.CurrentToken() is null)
            {
                throw new ParseException("Error: No more token.");
            }

            int number;

            try
            {
                number = Convert.ToInt32(this.CurrentToken());
            }
            catch (FormatException ex)
            {
                throw new ParseException($"Error: {ex.Message}");
            }

            return number;
        }
    }
}