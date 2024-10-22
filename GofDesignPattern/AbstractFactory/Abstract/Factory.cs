namespace GofDesignPattern.AbstractFactory.Abstract
{
    public abstract class Factory
    {
        public static Factory? GetFactory(string className)
        {
            Factory? factory = null;
            try
            {
                factory = Activator.CreateInstance(Type.GetType(className)) as Factory;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return factory;
        }

        public abstract Link CreateLink(string caption, string url);

        public abstract Tray CreateTray(string caption);

        public abstract Page CreatePage(string title, string author);
    }
}
