using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("checklist")]
    public class ChecklistController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllChecklist()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateChecklist([FromBody] string name)
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult CreateChecklist([FromBody] int id)
        {
            return Ok();
        }
    }
}
