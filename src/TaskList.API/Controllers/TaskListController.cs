using Microsoft.AspNetCore.Mvc;

namespace TaskList.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskListController : ControllerBase
    {
        private readonly ILogger<TaskListController> _logger;

        public TaskListController(ILogger<TaskListController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Initial Solution");
            return Ok(true);
        }
    }
}
