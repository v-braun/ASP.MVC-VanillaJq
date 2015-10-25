using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VanillaJq.ViewModels;

namespace VanillaJq.Controllers.View
{
    public class FinanceController : Controller
    {


        public ActionResult FinanceTilePartial()
        {


            var vm = new FinancingTileVM();
            vm.IsEmpty = true;

            return PartialView("Partials/FinancingTile", vm);
        }
	}
}