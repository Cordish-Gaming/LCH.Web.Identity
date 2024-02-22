// Copyright (c) 2024 CG Shared Services, LLC
// File: LCH.Web.Identity.HelpPageAreaRegistration.cs
// ---------------------------------------------------------------------------------------------------
// Modifications:
// Date:                                       Name:                                  Description:

using LCH.Web.Identity.Areas.HelpPage.App_Start;

namespace LCH.Web.Identity.Areas.HelpPage
{
    public class HelpPageAreaRegistration : AreaRegistration
    {
        public override string AreaName => "HelpPage";

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "HelpPage_Default"
                , "Help/{action}/{apiId}"
                , new
                {
                    controller = "Help"
                    , action = "Index"
                    , apiId = UrlParameter.Optional
                });

            HelpPageConfig.Register(GlobalConfiguration.Configuration);
        }
    }
}