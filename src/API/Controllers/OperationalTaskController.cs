using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OperationalTaskService.Controllers
{
    public class TaskController : Controller 
    {
        public TaskController()
        {
            
        }

        [HttpGet("/")]
        public async Task<IActionResult> Get()
        {
            return Ok("I contain all tasks");
        }
    }
}
