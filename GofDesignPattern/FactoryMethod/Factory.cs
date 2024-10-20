namespace GofDesignPattern.FactoryMethod
{
    public abstract class Factory
    {
        public Product Create(string owner)
        {
            Product product = this.CreateProduct(owner);
            this.RegisterProduct(product);
            return product;
        }

        protected abstract Product CreateProduct(string owner);

        protected abstract void RegisterProduct(Product product);
    }
}
