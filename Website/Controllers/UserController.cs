using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            var user = this.ControllerContext.RouteData.Values["user"] as string;
            if (string.IsNullOrEmpty(user))
            {
                return new RedirectResult("/Content/Index");
            }

            return new RedirectResult(string.Format("http://nuget.org/profiles/{0}", user));
        }

    }
}
