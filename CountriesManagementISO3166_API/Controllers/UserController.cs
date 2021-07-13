using CountriesManagementISO3166_API.Dtos.Request;
using CountriesManagementISO3166_API.Dtos.Response;
using CountriesManagementISO3166_API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CountriesManagementISO3166_API.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Authenticate")]
        public ActionResult<AuthenticateMS> Authenticate(AuthenticateME model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }       
    }
}
