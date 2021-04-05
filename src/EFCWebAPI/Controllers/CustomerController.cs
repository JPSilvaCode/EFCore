using EFCDomain.Data;
using EFCDomain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFCWebAPI.Controllers
{
    [Route("[controller]")]
    public class CustomerController : MainController
    {
        private readonly ICustomerData _customerData;

        public CustomerController(ICustomerData customerData)
        {
            _customerData = customerData;
        }

        [HttpGet]
        public async Task<IEnumerable<Customer>> Get()
        {
            return await _customerData.GetAll();
        }

        [HttpGet("{id:guid}")]
        public async Task<Customer> Get(Guid id)
        {
            return await _customerData.GetById(id);
        }

        [HttpGet("{email}")]
        public async Task<Customer> Get(string email)
        {
            return await _customerData.GetByEmail(email);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Customer customer)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            _customerData.Add(customer);
            await _customerData.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Customer customer)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            _customerData.Update(customer);
            await _customerData.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            var customer = await _customerData.GetById(id);

            if (customer == null)
                return BadRequest();

            _customerData.Remove(customer);
            await _customerData.SaveChanges();

            return Ok();
        }
    }
}
