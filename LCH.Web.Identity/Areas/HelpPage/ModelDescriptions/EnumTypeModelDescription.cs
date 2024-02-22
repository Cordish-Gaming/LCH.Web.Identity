// Copyright (c) 2024 CG Shared Services, LLC
// File: LCH.Web.Identity.EnumTypeModelDescription.cs
// ---------------------------------------------------------------------------------------------------
// Modifications:
// Date:                                       Name:                                  Description:

using System.Collections.ObjectModel;

namespace LCH.Web.Identity.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            this.Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}