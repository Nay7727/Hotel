using HotelSystem.Models;
using HotelSystem.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomTypesController : ControllerBase
    {
        private readonly RoomTypeService _service = new RoomTypeService();

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetRoomTypes());

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var roomType = _service.GetRoomType(id);
            if (roomType == null) return NotFound();
            return Ok(roomType);
        }

        [HttpPost]
        public IActionResult Create([FromBody] RoomType roomType)
        {
            _service.AddRoomType(roomType);
            return Ok(roomType);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] RoomType roomType)
        {
            roomType.Id = id;
            _service.UpdateRoomType(roomType);
            return Ok(roomType);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeleteRoomType(id);
            return Ok();
        }
    }
}