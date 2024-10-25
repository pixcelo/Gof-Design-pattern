namespace GofDesignPattern.Composite
{
    public class Directory : Entry
    {
        private string name;

        private List<Entry> directory = new List<Entry>();

        public Directory(string name)
        {
            this.name = name;
        }

        public override string GetName()
        {
            return this.name;
        }

        public override int GetSize()
        {
            int size = 0;
            foreach (Entry entry in this.directory)
            {
                size += entry.GetSize();
            }
            return size;
        }

        public override void PrintList(string prefix)
        {
            Console.WriteLine(prefix + "/" + this);
            foreach (Entry entry in this.directory)
            {
                entry.PrintList(prefix + "/" + this.name);
            }
        }

        public Entry Add(Entry entry)
        {
            this.directory.Add(entry);
            return this;
        }
    }
}
