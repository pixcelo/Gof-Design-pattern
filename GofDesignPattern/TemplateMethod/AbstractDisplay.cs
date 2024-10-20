namespace GofDesignPattern.TemplateMethod
{
    public abstract class AbstractDisplay
    {
        // Open, Print, Close はサブクラスに実装を任せる

        public abstract void Open();

        public abstract void Print();

        public abstract void Close();

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
