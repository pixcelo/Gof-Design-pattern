namespace GofDesignPattern.Composite
{
    public abstract class Entry
    {
        public abstract string GetName();

        public abstract int GetSize();

        public void PrintList()
        {
            this.PrintList("");
        }

        public abstract void PrintList(string prefix);

        public override string ToString()
        {
            return GetName() + " (" + GetSize() + ")";
        }
    }
}
