// Copyright (c) 2024 CG Shared Services, LLC
// File: LCH.Web.Identity.Global.asax.cs
// ---------------------------------------------------------------------------------------------------
// Modifications:
// Date:                                       Name:                                  Description:

namespace LCH.Web.Identity
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
        }
    }
}