namespace Bookstore.Core;

public interface IBookServices
{
    List<Book> GetBooks();
    Book GetBook(string id);
    Book AddBook(Book book);
    void DeleteBook(string id);
}