namespace GofDesignPattern.Iterator
{
    public class Book
    {
        private readonly string name;

        public Book(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
