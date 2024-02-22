// Copyright (c) 2024 CG Shared Services, LLC
// File: LCH.Web.Identity.HelpController.cs
// ---------------------------------------------------------------------------------------------------
// Modifications:
// Date:                                       Name:                                  Description:

using System.Web.Http;
using System.Web.Mvc;
using LCH.Web.Identity.Areas.HelpPage.ModelDescriptions;
using LCH.Web.Identity.Areas.HelpPage.Models;

namespace LCH.Web.Identity.Areas.HelpPage.Controllers
{
    /// <summary>
    /// The controller that will handle requests for the help page.
    /// </summary>
    public class HelpController : Controller
    {
        private const string ErrorViewName = "Error";

        public HelpController()
            : this(GlobalConfiguration.Configuration)
        {
        }

        public HelpController(HttpConfiguration config)
        {
            this.Configuration = config;
        }

        private HttpConfiguration Configuration { get; }

        public ActionResult Index()
        {
            this.ViewBag.DocumentationProvider = this.Configuration.Services.GetDocumentationProvider();
            return this.View(this.Configuration.Services.GetApiExplorer().ApiDescriptions);
        }

        public ActionResult Api(string apiId)
        {
            if (string.IsNullOrEmpty(apiId))
            {
                return this.View(ErrorViewName);
            }

            HelpPageApiModel apiModel = this.Configuration.GetHelpPageApiModel(apiId);
            return apiModel != null ? this.View(apiModel) : this.View(ErrorViewName);
        }

        public ActionResult ResourceModel(string modelName)
        {
            if (string.IsNullOrEmpty(modelName))
            {
                return this.View(ErrorViewName);
            }

            ModelDescriptionGenerator modelDescriptionGenerator = this.Configuration.GetModelDescriptionGenerator();
            return modelDescriptionGenerator.GeneratedModels.TryGetValue(modelName
                , out ModelDescription modelDescription)
                ? this.View(modelDescription)
                : this.View(ErrorViewName);
        }
    }
}