using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCDomain.Data;
using EFCDomain.Models;

namespace EFCWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
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
    }
}
