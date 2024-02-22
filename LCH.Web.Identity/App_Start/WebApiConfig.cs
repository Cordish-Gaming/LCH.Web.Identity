// Copyright (c) 2024 CG Shared Services, LLC
// File: LCH.Web.Identity.WebApiConfig.cs
// ---------------------------------------------------------------------------------------------------
// Modifications:
// Date:                                       Name:                                  Description:

using System.Web.Http;

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
                "DefaultApi"
                , "api/{controller}/{id}"
                , new
                {
                    id = RouteParameter.Optional
                });
        }
    }
}