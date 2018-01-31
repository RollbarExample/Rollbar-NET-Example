using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Rollbar;
using RollBar;

namespace RollbarDotnetExample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            RouteConfig.RegisterRoutes(RouteTable.Routes);

            const string postServerItemAccessToken = "69609226b4014ef39f62d4b2008c56ed";
            RollbarLocator.RollbarInstance.Configure(new RollbarConfig(postServerItemAccessToken)
            {
                Environment = "production"
            });


        }
    }
}
