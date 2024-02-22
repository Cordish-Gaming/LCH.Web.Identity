// Copyright (c) 2024 CG Shared Services, LLC
// File: LCH.Web.Identity.KeyValuePairModelDescription.cs
// ---------------------------------------------------------------------------------------------------
// Modifications:
// Date:                                       Name:                                  Description:

namespace LCH.Web.Identity.Areas.HelpPage.ModelDescriptions
{
    public class KeyValuePairModelDescription : ModelDescription
    {
        public ModelDescription KeyModelDescription { get; set; }

        public ModelDescription ValueModelDescription { get; set; }
    }
}