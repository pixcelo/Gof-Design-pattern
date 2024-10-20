namespace GofDesignPattern.TemplateMethod
{
    public abstract class AbstractDisplay
    {
        // Open, Print, Close はサブクラスに実装を任せる

        public abstract void Open();

        public abstract void Print();

        public abstract void Close();

        // 抽象クラスで処理の流れを形作る
        public void Display()
        {
            this.Open();
            for (int i = 0; i < 5; i++)
            {
                this.Print();
            }
            this.Close();
        }
    }
}
