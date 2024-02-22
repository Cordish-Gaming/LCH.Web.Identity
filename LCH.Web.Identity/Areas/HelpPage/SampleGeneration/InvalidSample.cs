// Copyright (c) 2024 CG Shared Services, LLC
// File: LCH.Web.Identity.InvalidSample.cs
// ---------------------------------------------------------------------------------------------------
// Modifications:
// Date:                                       Name:                                  Description:

using System;

namespace LCH.Web.Identity.Areas.HelpPage.SampleGeneration
{
    /// <summary>
    /// This represents an invalid sample on the help page. There's a display template named InvalidSample associated with this class.
    /// </summary>
    public class InvalidSample
    {
        public InvalidSample(string errorMessage)
        {
            if (errorMessage == null)
            {
                throw new ArgumentNullException("errorMessage");
            }

            this.ErrorMessage = errorMessage;
        }

        public string ErrorMessage { get; }

        public override bool Equals(object obj)
        {
            InvalidSample other = obj as InvalidSample;
            return other != null && this.ErrorMessage == other.ErrorMessage;
        }

        public override int GetHashCode()
        {
            return this.ErrorMessage.GetHashCode();
        }

        public override string ToString()
        {
            return this.ErrorMessage;
        }
    }
}