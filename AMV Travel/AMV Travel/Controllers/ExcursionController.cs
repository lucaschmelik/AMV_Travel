using AMV_Travel.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace AMV_Travel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExcursionController : ControllerBase
    {
        private readonly ILogger<ExcursionController> _logger;
        private readonly AMVContext _context;

        public ExcursionController(ILogger<ExcursionController> logger, AMVContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_context.Excursiones.ToList());
        }
    }
}
