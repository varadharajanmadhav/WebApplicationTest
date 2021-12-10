using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplicationTest
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup asdasdasd1 sdfdsfdsfdsf test2 test3 CR1 CR2 CR3 CR4
            RouteConfig.RegisterRoutes(RouteTable.Routes); //CR5
            BundleConfig.RegisterBundles(BundleTable.Bundles); //CR6


            //Savita change
        }
    }
}