using HotelSystem.Models;
using HotelSystem.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotelRoomsController : ControllerBase
    {
        private readonly HotelRoomService _service = new HotelRoomService();

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAllRooms());

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var room = _service.GetRoom(id);
            if (room == null) return NotFound();
            return Ok(room);
        }

        [HttpPost]
        public IActionResult Create([FromBody] HotelRoom room)
        {
            _service.AddRoom(room);
            return Ok(room);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] HotelRoom room)
        {
            room.Id = id;
            _service.UpdateRoom(room);
            return Ok(room);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeleteRoom(id);
            return Ok();
        }
    }
}