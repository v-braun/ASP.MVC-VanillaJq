using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VanillaJq.Models
{



    public class Vehicle
    {

        public string VehicleType { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string FuelType { get; set; }



        public bool IsActive { get; set; }
    }
}