namespace GofDesignPattern.Prototype
{
    public class Manager
    {
        private Dictionary<string, IProduct> showcase = new Dictionary<string, IProduct>();

        public void Register(string name, IProduct prototype)
        {
            this.showcase.Add(name, prototype);
        }

        public IProduct Create(string prototypeName)
        {
            IProduct product = this.showcase[prototypeName];
            return (IProduct)product.Clone();
        }
    }
}
