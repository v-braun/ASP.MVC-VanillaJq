using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using VanillaJq.Models;
using VanillaJq.ViewModels;
using Api = VanillaJq.Controllers.Api;

namespace VanillaJq.Controllers.View
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/
        public ActionResult Index()
        {
            
            Api.CustomerController customerApi = new Api.CustomerController();
            var customerModel = customerApi.GetActive();
            var vm = Mapper.Map<CustomerVM>(customerModel);

            return View(vm);
        }

        public ActionResult CustomerTilePartial()
        {
            Thread.Sleep(2000);
            Api.CustomerController customerApi = new Api.CustomerController();

            var customerModel = customerApi.GetActive();
            var vm = Mapper.Map<CustomerTileVM>(customerModel);

            return PartialView("Partials/CustomerTile", vm);
        }




        [HttpPost]
        public ActionResult Index(CustomerVM vm)
        {
            Api.CustomerController customerApi = new Api.CustomerController();            

            var customerModel = Mapper.Map<Customer>(vm);

            customerApi.Put(customerModel);

            return RedirectToAction("Index", "Home");

        }
	}
}