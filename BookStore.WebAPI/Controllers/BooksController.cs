using Bookstore.Core;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    private readonly IBookServices _bookServices;
    public BooksController(IBookServices bookServices)
    {
        _bookServices = bookServices;
    }

    [HttpGet]
    public IActionResult GetBooks()
    {
        return Ok(_bookServices.GetBooks());
    }

    [HttpGet("{id}", Name = "GetBook")]
    public IActionResult GetBook(string id)
    {
       return Ok(_bookServices.GetBook(id));
    }
    
    [HttpPost]
    public IActionResult AddBook(Book book)
    {
        _bookServices.AddBook(book);
        return CreatedAtRoute("GetBook", new { id = book.Id }, book);
    }


}