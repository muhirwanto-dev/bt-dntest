using Microsoft.AspNetCore.Mvc;
using WebApp.Dto;

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
        public IActionResult CreateChecklist([FromBody] CreateChecklistDto dto)
        {
            return Ok();
        }

        [HttpDelete("{checklistId}")]
        public IActionResult DeleteChecklist(int checklistId)
        {
            return Ok();
        }
    }
}
