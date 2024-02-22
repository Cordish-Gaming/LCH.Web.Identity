// Copyright (c) 2024 CG Shared Services, LLC
// File: LCH.Web.Identity.WebApiConfig.cs
// ---------------------------------------------------------------------------------------------------
// Modifications:
// Date:                                       Name:                                  Description:

namespace LCH.Web.Identity
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi"
                , routeTemplate: "api/{controller}/{id}"
                , defaults: new
                {
                    id = RouteParameter.Optional
                });
        }
    }
}