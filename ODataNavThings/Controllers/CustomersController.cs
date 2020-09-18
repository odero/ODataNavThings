using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataNavThings.Models;
using ODataNavThings.Repositories;
using System.Linq;

namespace ODataNavThings.Controllers
{
    [EnableQuery]
    public class CustomersController : ODataController
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomersController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IQueryable<Customer> Get()
        {
            return _customerRepository.GetCustomers();
        }

        public IActionResult Get([FromODataUri] int key)
        {
            return Ok(_customerRepository.GetCustomer(key));
        }
    }
}
