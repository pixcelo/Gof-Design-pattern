namespace GofDesignPattern.Proxy
{
    public class Printer : IPrintable
    {
        private string name;

        public Printer(string name)
        {
            this.name = name;
            this.HeavyJob($"Creating Printer instance({name})");
        }

        public void SetPrinterName(string name)
        {
            this.name = name;
        }

        public string GetPrinterName()
        {
            return this.name;
        }

        /// <summary>
        /// 名前付きで表示する
        /// </summary>
        /// <param name="text"></param>
        public void Print(string text)
        {
            Console.WriteLine($"=== {this.name} ===");
            Console.WriteLine(text);
        }

        /// <summary>
        /// ともて重い処理（時間が掛かる）
        /// </summary>
        /// <param name="msg"></param>
        private void HeavyJob(string msg)
        {
            Console.WriteLine(msg);
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine("Completed.");
        }
    }
}
