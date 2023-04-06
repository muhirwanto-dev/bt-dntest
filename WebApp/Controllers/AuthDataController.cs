using Microsoft.AspNetCore.Mvc;
using WebApp.Data;
using WebApp.Dto;
using WebApp.Model;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthDataController : ControllerBase
    {
        private readonly WebAppContext _context;

        public AuthDataController(WebAppContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterAuthDto dto)
        {
            var authData = _context.AuthData;
            var authList = authData.ToList();

            if (authList.Find(data => data.Email == dto.Email && data.Username == dto.Username) != null)
            {
                return Conflict();
            }

            var data = new AuthData { Email = dto.Email, Password = dto.Password, Username = dto.Username };
            authData.Add(data);

            return Ok(data);
        }

        [HttpPost("login")]
        public IActionResult RequestToken([FromBody] RequestTokenAuthDto dto)
        {
            var authData = _context.AuthData;
            var authList = authData.ToList();

            if (authList.Find(data => data.Username == dto.Username && data.Password == dto.Password) != null)
            {

            }

            return NotFound();
        }
    }
}
