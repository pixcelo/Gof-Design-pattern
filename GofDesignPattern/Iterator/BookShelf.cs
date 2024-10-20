using System.Collections;

namespace GofDesignPattern.Iterator
{
    public class BookShelf : IEnumerable<Book>
    {
        private readonly Book[] books;
        private int last = 0;

        public BookShelf(int maxSize)
        {
            this.books = new Book[maxSize];
        }

        public Book GetBookAt(int index)
        {
            return this.books[index];
        }

        public void AppendBook(Book book)
        {
            this.books[last] = book;
            last++;
        }

        public int GetLength()
        {
            return last;
        }

        public IEnumerator<Book> GetEnumerator()
        {
            //for (int i = 0; i < this.last; i++)
            //{
            //    yield return this.books[i];
            //}

            return new BookShelfIterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
