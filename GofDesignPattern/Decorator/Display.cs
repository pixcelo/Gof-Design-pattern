namespace GofDesignPattern.Decorator
{
    public abstract class Display
    {
        public abstract int GetColumns();
        public abstract int GetRows();
        public abstract string GetRowText(int row);

        public void Show()
        {
            for (int i = 0; i < this.GetRows(); i++)
            {
                Console.WriteLine(this.GetRowText(i));
            }
        }
    }
}
