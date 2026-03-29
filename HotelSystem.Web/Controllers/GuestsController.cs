using HotelSystem.Models;
using HotelSystem.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuestsController : ControllerBase
    {
        private readonly GuestService _service = new GuestService();

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAllGuests());

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var guest = _service.GetGuest(id);
            if (guest == null) return NotFound();
            return Ok(guest);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Guest guest)
        {
            _service.RegisterGuest(guest);
            return Ok(guest);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Guest guest)
        {
            guest.Id = id;
            _service.UpdateGuest(guest);
            return Ok(guest);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeleteGuest(id);
            return Ok();
        }
    }
}