using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OperationalTaskServiceAPI.Controllers
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
