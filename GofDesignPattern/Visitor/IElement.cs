namespace GofDesignPattern.Visitor
{
    public interface IElement
    {
        abstract void Accept(Visitor visitor);
    }
}
