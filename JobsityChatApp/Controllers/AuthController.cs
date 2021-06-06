using JobsityChatApp.Data;
using JobsityChatApp.DTO.Users;
using JobsityChatApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JobsityChatApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;
        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginDto request)
        {
            ServiceResponse<string> response = await _authRepository.Login(request.UserName, request.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterDto request)
        {
            ServiceResponse<int> response = await _authRepository
                .Register(new User
                {
                    UserName = request.UserName,
                    Email = request.Email,
                    Name = request.Name
                }, request.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}