using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VanillaJq.ViewModels;
using Api = VanillaJq.Controllers.Api;

namespace VanillaJq.Controllers.View
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            Api.CustomerController customerApi = new Api.CustomerController();
            Api.VehicleController vehicleApi = new Api.VehicleController();


            var customerModel = customerApi.GetActive();
            var vehicleModel = vehicleApi.GetActive();
            
            IndexVM vm = new IndexVM();
            vm.Customer = Mapper.Map<CustomerTileVM>(customerModel);
            vm.Vehicle = Mapper.Map<VehicleTileVM>(vehicleModel);
            vm.Financing = new FinancingTileVM();
            vm.Financing.IsEmpty = true;


            return View(vm);
        }
    }
}
