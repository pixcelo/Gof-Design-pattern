using Directory = GofDesignPattern.Composite.Directory;
using File = GofDesignPattern.Composite.File;

namespace GofDesignPattern.Tests.Composite
{
    public class DirectoryTests
    {
        [Fact]
        public void DirectoryPrintTest()
        {
            // Arrange
            Console.WriteLine("Making root entries...");
            var root = new Directory("root");
            var bin = new Directory("bin");
            var tmp = new Directory("tmp");
            var usr = new Directory("usr");

            root.Add(bin);
            root.Add(tmp);
            root.Add(usr);

            bin.Add(new File("vi", 10000));
            bin.Add(new File("latex", 20000));

            // Act
            root.PrintList();
            Console.WriteLine();            

            // Arrange
            Console.WriteLine("Making user entries...");
            var tom = new Directory("tom");
            var ken = new Directory("ken");
            var john = new Directory("john");

            usr.Add(tom);
            usr.Add(ken);
            usr.Add(john);

            tom.Add(new File("diary.html", 100));
            tom.Add(new File("Composite.cs", 200));
            ken.Add(new File("memo.tex", 300));
            ken.Add(new File("index.html", 350));
            john.Add(new File("game.doc", 400));
            john.Add(new File("junk.mail", 500));

            // Act
            root.PrintList();
        }
    }
}
