// Copyright (c) 2024 CG Shared Services, LLC
// File: LCH.Web.Identity.FilterConfig.cs
// ---------------------------------------------------------------------------------------------------
// Modifications:
// Date:                                       Name:                                  Description:

using System.Web.Mvc;

namespace LCH.Web.Identity
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}