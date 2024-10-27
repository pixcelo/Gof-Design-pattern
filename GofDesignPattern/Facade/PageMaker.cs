namespace GofDesignPattern.Facade
{
    /// <summary>
    /// 複数のクラスをまとめて複雑な処理を行う想定のクラス
    /// </summary>
    /// <remarks>
    /// 複雑な実装は隠蔽し、外部には窓口だけを見せる
    /// </remarks>
    public class PageMaker
    {
        private PageMaker()
        {
        }

        /// <summary>
        /// 指定されたメールアドレスのユーザーのウェルカムページを作成する
        /// </summary>
        /// <param name="mailAddress"></param>
        /// <param name="filename"></param>
        /// <remarks>
        /// 何をどの順番で処理するか等は使う側は気にしないで使える
        /// </remarks>
        public static void MakeWelcomePage(string mailAddress, string filename)
        {
            try
            {
                var mailProp = Database.GetProperties("mailData");
                string username = mailProp[mailAddress];

                HtmlWriter writer = new HtmlWriter(new StreamWriter(filename));
                writer.Title(username + "'s web page");
                writer.Paragraph("Welcome to " + username + "'s web page!");
                writer.Paragraph("Nice to meet you!");
                writer.MailTo(mailAddress, username);
                writer.Close();

                Console.WriteLine(filename + " is created for " + mailAddress + " (" + username + ")");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
