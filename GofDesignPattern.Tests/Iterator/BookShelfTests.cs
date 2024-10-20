using GofDesignPattern.Iterator;

namespace GofDesignPattern.Tests.Iterator
{
    public class BookShelfTests
    {
        /// <summary>
        /// Iteratorパターンの振る舞いを確認する
        /// </summary>
        [Fact]
        public void OkIterator()
        {
            // Arrange
            var bookShelf = new BookShelf(3);
            bookShelf.AppendBook(new Book("Book1"));
            bookShelf.AppendBook(new Book("Book2"));
            bookShelf.AppendBook(new Book("Book3"));

            var books = new List<Book>();

            // Act
            foreach (var book in bookShelf)
            {
                books.Add(book);
            }

            // 明示的にIteratorを使う方法
            var iterator = bookShelf.GetEnumerator();
          
            while (iterator.MoveNext())
            {
                Book book = iterator.Current;
                Console.WriteLine(book.GetName());
            }
        }

        [Fact]
        public void OkGetBookAt()
        {
            // Arrange
            var bookShelf = new BookShelf(2);
            bookShelf.AppendBook(new Book("Book1"));
            bookShelf.AppendBook(new Book("Book2"));

            // Act
            var actual = bookShelf.GetBookAt(1);

            // Assert
            Assert.Equal("Book2", actual.GetName());
        }
    }
}
