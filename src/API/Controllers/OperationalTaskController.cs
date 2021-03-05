using System.Threading.Tasks;
using Core.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace OperationalTaskServiceAPI.Controllers
{
    // [Route("tasks")]
    public class OperationalTaskController : Controller 
    {
        private readonly OperationalTaskService taskService;
        public OperationalTaskController(OperationalTaskService taskService)
        {
            this.taskService = taskService;
        }

        // [HttpGet("")]
        public async Task<IActionResult> Get()
        {
            if (!ModelState.IsValid) { return BadRequest(); }
            return Ok(await taskService.GetOperationalTask());
        }
    }
}
