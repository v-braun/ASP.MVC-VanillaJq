using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VanillaJq.ViewModels
{
    public class IndexVM
    {

        public CustomerTileVM Customer { get; set; }


        public VehicleTileVM Vehicle { get; set; }

        public FinancingTileVM Financing { get; set; }
    }
}