using AMV_Travel.DataAccess.Context;
using AMV_Travel.Models.Clases;
using AMV_Travel.Models.DTOs;
using AMV_Travel.Services.Kafka.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace AMV_Travel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservaController : ControllerBase
    {
        private readonly ILogger<ReservaController> _logger;
        private readonly IKafkaProducer _kafkaProducer;
        private readonly AMVContext _context;

        public ReservaController(ILogger<ReservaController> logger, AMVContext context, IKafkaProducer kafkaProducer)
        {
            _logger = logger;
            _context = context;
            _kafkaProducer = kafkaProducer;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var reservas = await _context.Reservas
                .Include(r => r.Paquete)
                    .ThenInclude(p => p.Excursion)
                .Include(r => r.Paquete)
                    .ThenInclude(p => p.Hotel)
                .Include(r => r.Cliente)
                .ToListAsync();

            return Ok(reservas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var reserva = await _context.Reservas
                .Include(r => r.Cliente)
                .Include(r => r.Paquete)
                    .ThenInclude(p => p.Excursion)
                .Include(r => r.Paquete)
                    .ThenInclude(p => p.Hotel)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (reserva == null)
            {
                return NotFound();
            }

            return Ok(reserva);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ReservaCreateDto nuevaReserva)
        {
            if (ModelState.IsValid)
            {
                var reserva = new Reserva
                {
                    Estado = Models.Enumerables.EstadoReservaEnum.Creada,
                    ClienteId = nuevaReserva.ClienteId,
                    PaqueteId = nuevaReserva.PaqueteId,
                    FechaCreacion = DateTime.Now
                };

                var cliente = _context.Clientes.FirstOrDefault(x => x.Id == reserva.ClienteId);

                if (cliente == null)
                {
                    return NotFound("El cliente indicado no se encuentra registrado");
                }

                var paquete = _context.Paquetes.Include(x=>x.Hotel).Include(x=>x.Excursion).FirstOrDefault(x => x.Id == reserva.PaqueteId);

                if (paquete == null)
                {
                    return NotFound("El paquete indicado no se encuentra registrado");
                }

                _context.Reservas.Add(reserva);
                await _context.SaveChangesAsync();

                var hotelToKafkaDto = new HotelToKafkaDto
                {
                    Hotel = paquete.Hotel,
                    Cliente = cliente
                };

                var result = await _kafkaProducer.ProduceAsync("amv_travel", JsonSerializer.Serialize(hotelToKafkaDto));

                return CreatedAtAction(nameof(GetById), new { id = reserva.Id }, reserva);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Reserva reservaActualizada)
        {
            if (id != reservaActualizada.Id)
            {
                return BadRequest();
            }

            var reservaExistente = await _context.Reservas.FindAsync(id);

            if (reservaExistente == null)
            {
                return NotFound();
            }

            _context.Entry(reservaExistente).CurrentValues.SetValues(reservaActualizada);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return StatusCode(500, "Error: " + ex.Message);
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var reserva = await _context.Reservas.FindAsync(id);

            if (reserva == null)
            {
                return NotFound();
            }

            _context.Reservas.Remove(reserva);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
