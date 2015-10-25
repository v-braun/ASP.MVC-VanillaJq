using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VanillaJq.Models;

namespace VanillaJq.Controllers.Api
{
    public class VehicleController : ApiController
    {

        private static List<Vehicle> vehicles = new List<Vehicle>();
        static VehicleController()
        {
            vehicles.Add(new Vehicle()
            {
                FuelType = "Benzin",
                Make = "Volkswagen",
                Model = "Golf",
                VehicleType = "Auto",
                IsActive = true
            });
        }

        // GET api/vehicle
        public IEnumerable<Vehicle> Get()
        {
            return vehicles;
        }

        // GET api/vehicle/5
        public Vehicle GetActive()
        {
            return vehicles.FirstOrDefault(v => v.IsActive);
        }
    }
}
