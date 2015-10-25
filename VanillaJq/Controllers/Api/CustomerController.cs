using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VanillaJq.Models;

namespace VanillaJq.Controllers.Api
{
    public class CustomerController : ApiController
    {

        private static List<Customer> customers = new List<Customer>();

        static CustomerController()
        {
            customers.Add(new Customer()
            {
                FirstName = "Max",
                LastName = "Mustermann",
                Id = Guid.NewGuid(),
                CustomerKind = CustomerKind.Private,
                IsActive = true
            });
        }

        public IEnumerable<Customer> Get()
        {
            return customers;
        }

        public Customer GetActive()
        {
            return customers.FirstOrDefault(c => c.IsActive);
        }

        public void Put(Customer updatedCustomer)
        {
            var old = customers.First(c => c.Id == updatedCustomer.Id);
            customers.Remove(old);
            updatedCustomer.IsActive = old.IsActive;
            customers.Add(updatedCustomer);

        }
    }
}
