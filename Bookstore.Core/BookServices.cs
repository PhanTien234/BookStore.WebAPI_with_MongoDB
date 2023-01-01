using MongoDB.Driver;

namespace Bookstore.Core;

public class BookServices :  IBookServices
{
    private readonly IMongoCollection<Book> _books;

    public BookServices(IDbClient dbClient)
    {
        _books = dbClient.GetBooksCollection();
    }

    public Book GetBook(string id) => _books.Find(book => book.Id == id).First();
    public Book AddBook(Book book)
    {
        _books.InsertOne(book);
        return book;
    }

    public List<Book> GetBooks() => _books.Find(book => true).ToList();

}