namespace GofDesignPattern.Visitor
{
    public abstract class Entry : IElement
    {
        public abstract string GetName();

        public abstract int GetSize();

        public abstract void Accept(Visitor visitor);

        public override string ToString()
        {
            return GetName() + " (" + GetSize() + ")";
        }
    }
}
