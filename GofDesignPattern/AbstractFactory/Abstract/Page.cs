namespace GofDesignPattern.AbstractFactory.Abstract
{
    public abstract class Page
    {
        protected string title;
        protected string author;
        protected List<Item> content = new List<Item>();

        public Page(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public void Add(Item item)
        {
            this.content.Add(item);
        }

        public void Output(string fileName)
        {
            try
            {
                string filename = this.title + ".html";
                using (var writer = new StreamWriter(filename))
                {
                    writer.Write(MakeHTML());
                }
                Console.WriteLine(filename + "is created.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public abstract string MakeHTML();
    }
}
