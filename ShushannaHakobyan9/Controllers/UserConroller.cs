using ShushannaHakobyan9.Services;
using ShushannaHakobyan9.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            this._userService = userService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_userService.GetAll());
        }

        [HttpPost]
        public IActionResult Add(UserViewModel user)
        {
            _userService.Add(user);

            return Ok();
        }


    }
}
