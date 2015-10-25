using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VanillaJq.ViewModels
{
    public class VehicleTileVM
    {

        public string VehicleType { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string FuelType { get; set; }

        public string DisplayText
        {
            get
            {
                return Make + " " + Model;
            }
        }

        public string DisplayDetailText
        {
            get
            {
                return VehicleType + " (" + FuelType + ")";
            }
        }

    }
}