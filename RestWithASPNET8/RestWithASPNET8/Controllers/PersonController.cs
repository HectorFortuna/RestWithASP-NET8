using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET8.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/")]
        public IActionResult Sum()
        {
            return BadRequest("Invalid Output");
        }
    }
}
