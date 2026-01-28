using HotelSystem.Models;
using HotelSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Services
{
    public class PaymentService
    {
        private readonly PaymentRepository repository = new();

        public void Pay(Payment payment)
        {
            if (payment.Amount <= 0)
                throw new Exception("Invalid amount");

            payment.PaymentDate = DateTime.Now;
            repository.Add(payment);
        }

        public List<Payment> GetPayments()
        {
            return repository.GetAll();
        }
    }
}
