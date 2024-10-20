using System.Collections;

namespace GofDesignPattern.Iterator
{
    public class BookShelfIterator : IEnumerator<Book>
    {
        private BookShelf bookShelf;
        private int index;

        public BookShelfIterator(BookShelf bookShelf)
        {
            this.bookShelf = bookShelf;
            this.index = -1;
        }

        public Book Current
        {
            get
            {
                if (this.index < 0 || this.index >= this.bookShelf.GetLength())
                {
                    throw new InvalidOperationException();
                }
                return bookShelf.GetBookAt(this.index);
            }
        }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if (this.index < this.bookShelf.GetLength() - 1)
            {
                this.index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            this.index = -1;
        }

        public void Dispose()
        {
        }
    }
}
