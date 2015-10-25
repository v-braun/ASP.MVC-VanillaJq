using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;

namespace VanillaJq.Controllers
{

    public class ApiEndpointModel
    {

        public class ApiEndpointParameterModel{
            public ApiEndpointParameterModel(ApiParameterDescription desc)
            {
                this.Documentation = desc.Documentation;
                this.Name = desc.Name;
                this.Optional = desc.ParameterDescriptor.IsOptional;
            }

            public ApiEndpointParameterModel(ParameterInfo desc)
            {
                this.Name = desc.Name;
                this.Optional = desc.IsOptional;
            }

            public string Documentation { get; set; }

            public string Name { get; set; }

            public bool Optional { get; set; }
        }

        public ApiEndpointModel(ApiDescription desc, UrlHelper url, HttpRequestBase request)
        {
            this.Documentation = desc.Documentation;
            this.Controller = desc.ActionDescriptor.ControllerDescriptor.ControllerName;
            this.Action = desc.ActionDescriptor.ActionName;
            this.Method = desc.HttpMethod.Method;

            this.Path = url.Action(this.Action, this.Controller, new { }, request.Url.Scheme);
            this.Parameters = desc.ParameterDescriptions.Select(p => new ApiEndpointParameterModel(p));
        }

        public ApiEndpointModel(MethodInfo desc, UrlHelper url, HttpRequestBase request)
        {
            this.Controller = desc.DeclaringType.Name.Remove(desc.DeclaringType.Name.LastIndexOf("Controller"));
            this.Action = desc.Name;
            this.Method = "GET";
            if (desc.GetCustomAttributes<System.Web.Mvc.HttpPostAttribute>().Count() > 0)
            {
                this.Method = "POST";
            }

            this.Path = url.Action(this.Action, this.Controller, new { }, request.Url.Scheme);
            this.Parameters = desc.GetParameters().Select(p => new ApiEndpointParameterModel(p));
        }
        



        public string Documentation { get; set; }

        public string Controller { get; set; }

        public string Method { get; set; }

        public string Action { get; set; }

        public string Path { get; set; }

        public IEnumerable<ApiEndpointParameterModel> Parameters { get; set; }
    }

    public class MetaDataController : Controller
    {
        //
        // GET: /MetaData/
        public ActionResult Api()
        {
            var explorer = GlobalConfiguration.Configuration.Services.GetApiExplorer();
            var endpoints = explorer.ApiDescriptions.Select(d => new ApiEndpointModel(d, this.Url, this.Request));      
            
            return PartialView(endpoints);
        }

        public ActionResult View()
        {

            var controller = GetType().Assembly.GetTypes().Where(type => typeof(Controller).IsAssignableFrom(type)).SelectMany(type => type.GetMethods(BindingFlags.DeclaredOnly));

            var actions = GetType().Assembly
                                          .GetTypes()
                                          .Where(type => typeof(Controller).IsAssignableFrom(type))
                                          .SelectMany(type => type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
                                          .Where(method => !method.IsSpecialName && (method.GetCustomAttributes<System.Web.Mvc.NonActionAttribute>().Count() <= 0));
            var endpoints = actions.Select(a => new ApiEndpointModel(a, this.Url, this.Request));

            return PartialView(endpoints);
        }

	}
}