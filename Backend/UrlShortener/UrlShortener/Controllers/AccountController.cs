using BLL;
using BLL.Dtos;
using BLL.Services.Authorization.Interfaces;
using BLL.Services.Registration.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LearningService.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly IRegistrationService _registerService;

        public AccountController(ILoginService loginService, IRegistrationService registerService)
        {
            _loginService = loginService;
            _registerService = registerService;

        }

        [HttpPost("no-auth/registration-form")]
        public async Task<ActionResult<Response<Guid>>> Register(RegistrationUserDto registrationFormDto)
        {
            var response = await _registerService.Register(registrationFormDto, "User");
            if (!response.Success)
            {
                return BadRequest(response);
            }   

            return Ok(response);
        }

        [HttpPost("no-auth/login")]
        public async Task<ActionResult<Response<LoginDto>>> Login(LoginUserDto userDTO)
        {
            var response = await _loginService.Login(userDTO);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

    }
}
