using Core.DTO.UserDTO;
using Core.Interfaces.CustomServices;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody] UserRegistrationDTO userData)
        {
            var callbackUrl = Request.GetTypedHeaders().Referer.ToString();
            await _authenticationService.RegisterAsync(userData);
            return Ok();
        }
    }
}
