using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;

namespace Website.Routes
{
    public class SubdomainRoute : RouteBase
    {
        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            var url = httpContext.Request.Headers["HOST"];
            var index = url.IndexOf(".");

            if (index < 0)
                return null;

            var subDomain = url.Substring(0, index);
            var routeData = new RouteData(this, new MvcRouteHandler());
            routeData.Values.Add("controller", "User"); //Goes to the UserController class
            routeData.Values.Add("action", "Index"); //Goes to the Index action on the UserController
            routeData.Values.Add("user", subDomain);

            return routeData;
        }

        public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
        {
            //Implement your formating Url formating here
            return null;
        }
    }
}