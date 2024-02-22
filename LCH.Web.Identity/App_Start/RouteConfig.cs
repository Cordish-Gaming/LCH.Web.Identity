// Copyright (c) 2024 CG Shared Services, LLC
// File: LCH.Web.Identity.RouteConfig.cs
// ---------------------------------------------------------------------------------------------------
// Modifications:
// Date:                                       Name:                                  Description:

using System.Web.Mvc;
using System.Web.Routing;

namespace LCH.Web.Identity
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default"
                , url: "{controller}/{action}/{id}"
                , defaults: new
                {
                    controller = "Home"
                    , action = "Index"
                    , id = UrlParameter.Optional
                });
        }
    }
}