namespace GofDesignPattern.Bridge
{
    public class Display
    {
        private readonly DisplayImpl impl;

        public Display(DisplayImpl impl)
        {
            this.impl = impl;
        }

        public void Open()
        {
            this.impl.RawOpen();
        }

        public void Print()
        {
            this.impl.RawPrint();
        }

        public void Close()
        {
            this.impl.RawClose();
        }

        public void DisplayMethod()
        {
            this.Open();
            this.Print();
            this.Close();
        }
    }
}
