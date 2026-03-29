using HotelSystem.Models;
using HotelSystem.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationsController : ControllerBase
    {
        private readonly ReservationService _service = new ReservationService();

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetReservations());

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var reservation = _service.GetReservation(id);
            if (reservation == null) return NotFound();
            return Ok(reservation);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Reservation reservation)
        {
            _service.CreateReservation(reservation);
            return Ok(reservation);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Reservation reservation)
        {
            reservation.Id = id;
            _service.UpdateReservation(reservation);
            return Ok(reservation);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeleteReservation(id);
            return Ok();
        }
    }
}