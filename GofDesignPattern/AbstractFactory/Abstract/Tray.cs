namespace GofDesignPattern.AbstractFactory.Abstract
{
    public abstract class Tray : Item
    {
        protected List<Item> tray = new List<Item>();

        protected Tray(string caption) : base(caption)
        {
        }

        public void Add(Item item)
        {
            tray.Add(item);
        }
    }
}
