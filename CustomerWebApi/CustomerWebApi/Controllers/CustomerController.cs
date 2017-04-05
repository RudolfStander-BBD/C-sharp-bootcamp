using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CustomerWebApi.Models;

namespace CustomerWebApi.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public IEnumerable<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetCustomer")]
        public IActionResult GetById(long id)
        {
            var item = _customerRepository.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }

            _customerRepository.Add(customer);

            return CreatedAtRoute("GetCustomer", new { id = customer.CustomerId }, customer);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Customer customer)
        {
            if (customer == null || customer.CustomerId != id)
            {
                return BadRequest();
            }

            var dbCustomer = _customerRepository.Find(id);

            if (dbCustomer == null)
            {
                return NotFound();
            }

            customer.CustomerId = dbCustomer.CustomerId;
            _customerRepository.Update(customer);

            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var customer = _customerRepository.Find(id);

            if (customer == null)
            {
                return NotFound();
            }

            _customerRepository.Remove(id);

            return new NoContentResult();
        }
    }
}
