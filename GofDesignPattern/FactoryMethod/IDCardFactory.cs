namespace GofDesignPattern.FactoryMethod
{
    public class IDCardFactory : Factory
    {
        protected override Product CreateProduct(string owner)
        {
            return new IDCard(owner);
        }

        protected override void RegisterProduct(Product product)
        {
            Console.WriteLine(product + "を登録しました。");
        }
    }
}
