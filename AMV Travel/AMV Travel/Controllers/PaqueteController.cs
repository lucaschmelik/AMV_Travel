using AMV_Travel.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace AMV_Travel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaqueteController : ControllerBase
    {
        private readonly ILogger<PaqueteController> _logger;
        private readonly AMVContext _context;

        public PaqueteController(ILogger<PaqueteController> logger, AMVContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var paquetes = _context.Paquetes.ToList();

            paquetes.ForEach(x =>
            {
                x.Excursion = _context.Excursiones.First(y => y.Id == x.ExcursionId);
                x.Hotel = _context.Hoteles.First(y => y.Id == x.HotelId);
            });

            return Ok(paquetes);
        }
    }
}
