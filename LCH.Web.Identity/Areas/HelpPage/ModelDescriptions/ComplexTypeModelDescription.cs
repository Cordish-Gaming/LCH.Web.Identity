// Copyright (c) 2024 CG Shared Services, LLC
// File: LCH.Web.Identity.ComplexTypeModelDescription.cs
// ---------------------------------------------------------------------------------------------------
// Modifications:
// Date:                                       Name:                                  Description:

using System.Collections.ObjectModel;

namespace LCH.Web.Identity.Areas.HelpPage.ModelDescriptions
{
    public class ComplexTypeModelDescription : ModelDescription
    {
        public ComplexTypeModelDescription()
        {
            this.Properties = new Collection<ParameterDescription>();
        }

        public Collection<ParameterDescription> Properties { get; private set; }
    }
}