using Microsoft.AspNetCore.Mvc;
using PhoneStore.Api.Models;
using PhoneStore.Api.Services;

namespace PhoneStore.Api.Controllers
{
    [ApiController]
    [Route("UsersController")]
    public sealed class UsersController : ControllerBase
    {
        private IUsersService _usersService;
        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet("all")]
        public ActionResult<IEnumerable<UserItem>> GetUsers()
        {
            var users = _usersService.GetAllUsers();
            return Ok(users);
        }

        //[HttpPost("add_user")]
        
    }
}
