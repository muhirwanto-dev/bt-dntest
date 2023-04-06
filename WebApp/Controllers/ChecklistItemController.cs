using Microsoft.AspNetCore.Mvc;
using WebApp.Dto;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("checklist")]
    public class ChecklistItemController : ControllerBase
    {
        [HttpGet("{checklistId}/item")]
        public IActionResult GetAllChecklistItem(int checklistId)
        {
            return Ok();
        }

        [HttpPost("{checklistId}/item")]
        public IActionResult CreateNewChecklistItem([FromBody] CreateChecklistItemDto dto, int checklistId)
        {
            return Ok();
        }

        [HttpPost("{checklistId}/item/{checklistItemId}")]
        public IActionResult GetChecklistItemInChecklist(int checklistId, int checklistItemId)
        {
            return Ok();
        }

        [HttpPut("{checklistId}/item/{checklistItemId}")]
        public IActionResult UpdateStatusChecklistItem(int checklistId, int checklistItemId)
        {
            return Ok();
        }

        [HttpDelete("{checklistId}/item/{checklistItemId}")]
        public IActionResult DeleteItem(int checklistId, int checklistItemId)
        {
            return Ok();
        }

        [HttpPut("{checklistId}/item/rename/{checklistItemId}")]
        public IActionResult RenameItem([FromBody] RenameChecklistItemDto dto, int checklistId, int checklistItemId)
        {
            return Ok();
        }
    }
}
