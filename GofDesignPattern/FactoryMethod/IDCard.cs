namespace GofDesignPattern.FactoryMethod
{
    internal class IDCard : Product
    {
        private readonly string owner;

        public IDCard(string owner)
        {
            Console.WriteLine(owner + "のカードを作ります。");
            this.owner = owner;
        }

        public override void Use()
        {
            Console.WriteLine(this + "を使います。");
        }

        public override string ToString()
        {
            return $"[IDCard:{this.owner}]";
        }

        public string GetOwner()
        {
            return this.owner;
        }
    }
}
