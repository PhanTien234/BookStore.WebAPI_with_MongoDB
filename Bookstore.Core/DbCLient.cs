using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Bookstore.Core;

public class DbCLient : IDbClient
{
    private readonly IMongoCollection<Book> _books;
    public DbCLient(IOptions<BookstoreDbConfig> bookstoreDbConfig)
    {
        var client = new MongoClient(bookstoreDbConfig.Value.Connection_String);
        var database = client.GetDatabase(bookstoreDbConfig.Value.Database_Name);
        _books = database.GetCollection<Book>(bookstoreDbConfig.Value.Books_Collection_Name);
    }

    public IMongoCollection<Book> GetBooksCollection() => _books;
}