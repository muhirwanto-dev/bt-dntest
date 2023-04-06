using Microsoft.AspNetCore.Mvc;
using WebApp.Data;
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
        public IActionResult Register(string email, string password, string username)
        {
            var authData = _context.AuthData;
            var authList = authData.ToList();

            if (authList.Find(data => data.Email == email && data.Username == username) != null)
            {
                return Conflict();
            }

            var data = new AuthData { Email = email, Password = password, Username = username };
            authData.Add(data);

            return Ok(data);
        }

        [HttpPost("login")]
        public IActionResult RequestToken(string password, string username)
        {
            var authData = _context.AuthData;
            var authList = authData.ToList();

            if (authList.Find(data => data.Username == username && data.Password == password) != null)
            {

            }

            return NotFound();
        }
    }
}
