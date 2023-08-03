using BLL;
using BLL.Services.Users.Interfaces;
using DAL.Model;
using Microsoft.AspNetCore.Mvc;

namespace UrlShortener.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService? _userService;

        public UserController(IUserService? userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAllUserInfo")]
        public async Task<ActionResult<Response<User>>> GetInfoAboutUser(Guid id)
        {
            var response =await _userService.GetInfoAboutUser(id);
            if (response.Success != true)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
