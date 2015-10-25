using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using VanillaJq.Models;
using VanillaJq.ViewModels;

namespace VanillaJq
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutoMapper.Mapper.CreateMap<Customer, CustomerTileVM>();
            AutoMapper.Mapper.CreateMap<Customer, CustomerVM>();
            AutoMapper.Mapper.CreateMap<CustomerVM, Customer>();

            AutoMapper.Mapper.CreateMap<Vehicle, VehicleTileVM>();
        }
    }
}
