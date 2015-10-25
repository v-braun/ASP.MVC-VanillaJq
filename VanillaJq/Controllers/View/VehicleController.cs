using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using VanillaJq.ViewModels;

namespace VanillaJq.Controllers.View
{
    public class VehicleController : Controller
    {

        public ActionResult VehicleTilePartial()
        {

            Thread.Sleep(5000);


            Api.VehicleController vehicleApi = new Api.VehicleController();

            var vehicleModel = vehicleApi.GetActive();
            var vm = Mapper.Map<VehicleTileVM>(vehicleModel);

            return PartialView("Partials/VehicleTile", vm);
        }
	}
}