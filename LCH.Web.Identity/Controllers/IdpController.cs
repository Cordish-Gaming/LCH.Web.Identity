// Copyright (c) 2024 CG Shared Services, LLC
// File: LCH.Web.Identity.IdpController.cs
// ---------------------------------------------------------------------------------------------------
// Modifications:
// Date:                                       Name:                                  Description:

using System.Web.Mvc;

namespace LCH.Web.Identity.Controllers
{
    public class IdpController : Controller
    {
        public ActionResult ViewIdpTokens()
        {
            this.ViewBag.Title = "Tokens";

            return this.View();
        }
    }
}