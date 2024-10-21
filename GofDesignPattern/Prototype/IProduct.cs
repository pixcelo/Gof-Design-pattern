namespace GofDesignPattern.Prototype
{
    public interface IProduct : ICloneable
    {
        void Use(string value);

        new object Clone();
    }
}
