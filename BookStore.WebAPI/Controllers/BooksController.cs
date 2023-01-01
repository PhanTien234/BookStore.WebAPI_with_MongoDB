using Microsoft.AspNetCore.Mvc;

namespace BookStore.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    public BooksController()
    {
        
    }

    [HttpGet]
    public IActionResult GetBooks()
    {
        
    }

}