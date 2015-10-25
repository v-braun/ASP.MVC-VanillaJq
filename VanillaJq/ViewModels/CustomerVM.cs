using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VanillaJq.Models;

namespace VanillaJq.ViewModels
{
    public class CustomerVM
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public CustomerKind CustomerKind { get; set; }
        
    }
}