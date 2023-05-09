using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators;

public class Library : IEnumerable<Book>
{
    private List<Book> books;

    public Library(params Book[] books)
    {
        this.books = new List<Book>(books);
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIterator(books);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}


public class LibraryIterator : IEnumerator<Book>
{

    private List<Book> books;
    int currentIndex = -1;

    public Book Current => books[currentIndex];

    object IEnumerator.Current => Current;
    public LibraryIterator(List<Book> books)
    {
        this.books = books;

    }

    public void Dispose()
    {

    }

    public bool MoveNext()
    {
        currentIndex++;

        return currentIndex < books.Count;
    }

    public void Reset()
    {
        currentIndex = -1;
    }
}
