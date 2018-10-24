using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestCustomerServiceCore.Model;

namespace RestCustomerServiceCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        private static List<Customer> cList = new List<Customer>
        {
            new Customer(){FirstName = "Kokot", Id = 1,LastName = "Demovic", YearOfRegistration = 15112018},
            new Customer(){FirstName = "Robot", Id = 2,LastName = "Genovic", YearOfRegistration = 24051235},
            new Customer(){FirstName = "Chobot", Id = 3,LastName = "Lenovic", YearOfRegistration = 44531532},
        };

        

        // GET: api/Customers
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return cList;
        }

        // GET: api/Customers/5
        [HttpGet("{id}", Name = "Get")]
        public Customer Get(int id)
        {
            return cList[id-1];
        }

        // POST: api/Customers
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Customers/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(Customer id)
        {
            cList.Remove(id);
        }
    }
}
