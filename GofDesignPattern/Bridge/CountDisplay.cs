namespace GofDesignPattern.Bridge
{
    public class CountDisplay : Display
    {
        public CountDisplay(DisplayImpl impl) : base(impl)
        {
        }

        public void MultiDisplay(int times)
        {
            this.Open();
            for (int i = 0; i < times; i++)
            {
                this.Print();
            }
            this.Close();
        }
    }
}
