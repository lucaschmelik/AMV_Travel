using AMV_Travel.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace AMV_Travel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly AMVContext _context;

        public ClienteController(ILogger<ClienteController> logger, AMVContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_context.Clientes.ToList());
        }
    }
}
