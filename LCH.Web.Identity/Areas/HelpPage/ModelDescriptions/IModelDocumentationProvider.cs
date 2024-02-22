// Copyright (c) 2024 CG Shared Services, LLC
// File: LCH.Web.Identity.IModelDocumentationProvider.cs
// ---------------------------------------------------------------------------------------------------
// Modifications:
// Date:                                       Name:                                  Description:

using System;
using System.Reflection;

namespace LCH.Web.Identity.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}