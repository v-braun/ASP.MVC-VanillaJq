using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VanillaJq.Extensions
{
    public static class HtmlHelperExtensions
    {

        public static MvcHtmlString Module(this HtmlHelper self, string module, object config = null)
        {
            var moduleAttr = "data-module=\"" + module + "\"";
            if (config != null)
            {
                var conf = self.AttributeEncode(JsonConvert.SerializeObject(config));
                var configAttr = "data-module-config=\"" + conf + "\" ";
                return new MvcHtmlString(moduleAttr + " " + configAttr + " ");
            }
            
            return new MvcHtmlString(moduleAttr + " ");
        }

    }
}