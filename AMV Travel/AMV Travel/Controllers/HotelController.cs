using AMV_Travel.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace AMV_Travel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelController : ControllerBase
    {
        private readonly ILogger<HotelController> _logger;
        private readonly AMVContext _context;

        public HotelController(ILogger<HotelController> logger, AMVContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_context.Hoteles.ToList());
        }
    }
}
