using Microsoft.AspNetCore.Mvc;
using WebAppProject8.Data;

namespace WebAppProject8.Controllers
{
    //Modupeoluwa Daniel
    [ApiController]
    [Route("[controller]")]
    public class FootballTeamsController : ControllerBase
    {

        private readonly ILogger<FootballTeamsController> _logger;
        private readonly FootballTeamsContext _context;

        public FootballTeamsController(ILogger<FootballTeamsController> logger, FootballTeamsContext context )
        {
            _logger = logger;
            _context = context; 
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.FootballTeams.ToList());
        }
    }
}