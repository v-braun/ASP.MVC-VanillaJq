using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VanillaJq.Models
{

    public enum CustomerKind
    {
        Private,
        Business
    }

    public class Customer
    {

        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public CustomerKind CustomerKind { get; set; }


        public bool IsActive { get; set; }
    }
}