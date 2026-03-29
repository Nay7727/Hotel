using HotelSystem.Models;
using HotelSystem.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentsController : ControllerBase
    {
        private readonly PaymentService _service = new PaymentService();

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetPayments());

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var payment = _service.GetPayment(id);
            if (payment == null) return NotFound();
            return Ok(payment);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Payment payment)
        {
            _service.Pay(payment);
            return Ok(payment);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Payment payment)
        {
            payment.Id = id;
            _service.UpdatePayment(payment);
            return Ok(payment);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeletePayment(id);
            return Ok();
        }
    }
}