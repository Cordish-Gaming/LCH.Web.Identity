// Copyright (c) 2024 CG Shared Services, LLC
// File: LCH.Web.Identity.ParameterAnnotation.cs
// ---------------------------------------------------------------------------------------------------
// Modifications:
// Date:                                       Name:                                  Description:

using System;

namespace LCH.Web.Identity.Areas.HelpPage.ModelDescriptions
{
    public class ParameterAnnotation
    {
        public Attribute AnnotationAttribute { get; set; }

        public string Documentation { get; set; }
    }
}