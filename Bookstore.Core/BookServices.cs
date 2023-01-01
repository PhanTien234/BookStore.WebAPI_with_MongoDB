using MongoDB.Driver;

namespace Bookstore.Core;

public class BookServices :  IBookServices
{
    private readonly IMongoCollection<Book> _books;
    public BookServices(IDbClient dbClient)
    {
        _books = dbClient.GetBooksCollection();
    }

    public List<Book> GetBooks() => _books.Find(book => true).ToList();
}