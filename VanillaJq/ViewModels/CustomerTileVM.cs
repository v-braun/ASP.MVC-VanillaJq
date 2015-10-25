using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VanillaJq.Models;

namespace VanillaJq.ViewModels
{
    public class CustomerTileVM
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public CustomerKind CustomerKind { get; set; }


    }
}