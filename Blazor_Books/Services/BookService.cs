using System;
using System.Collections.Generic;
using System.Linq;
using Blazor_Books.Models;

public class BookService
{
    private List<BookDto> books = new List<BookDto>();

    public List<BookDto> GetBooks()
    {
        return books;
    }

    public void AddBook(BookDto book)
    {
        book.Id = Guid.NewGuid();
        books.Add(book);
    }

    public void UpdateBook(BookDto book)
    {
        var index = books.FindIndex(b => b.Id == book.Id);
        if (index != -1)
        {
            books[index] = book;
        }
    }

    public void DeleteBook(Guid id)
    {
        var book = books.FirstOrDefault(b => b.Id == id);
        if (book != null)
        {
            books.Remove(book);
        }
    }
}
