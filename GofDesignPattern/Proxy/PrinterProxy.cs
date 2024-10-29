namespace GofDesignPattern.Proxy
{
    public class PrinterProxy : IPrintable
    {
        private string name;

        /// <summary>
        /// 本人
        /// </summary>
        private Printer? real;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public PrinterProxy()
        {
            this.name = "No name";
            this.real = null;
        }

        /// <summary>
        /// コンストラクタ（名前指定）
        /// </summary>
        /// <param name="name"></param>
        public PrinterProxy(string name)
        {
            this.name = name;
            this.real = null;
        }

        public void SetPrinterName(string name)
        {
            if (this.real != null)
            {
                // 本人にも設定する
                this.real.SetPrinterName(name);
            }
            this.name = name;
        }

        public string GetPrinterName()
        {
            return this.name;
        }

        public void Print(string text)
        {
            this.Realize();
            this.real?.Print(text);
        }

        /// <summary>
        /// 本人を生成
        /// </summary>
        private void Realize()
        {
            if (this.real is null)
            {
                this.real = new Printer(this.name);
            }
        }
    }
}
