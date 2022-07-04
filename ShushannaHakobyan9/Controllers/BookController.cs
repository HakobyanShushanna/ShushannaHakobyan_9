using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using ShushannaHakobyan9.Services;
using ShushannaHakobyan9.ViewModels;

namespace ShushannaHakobyan9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_bookService.GetAll());
        }


        [HttpPost]
        public IActionResult Add(BookViewModel book)
        {
            _bookService.Add(book);
            return Ok();
        }


    }
}