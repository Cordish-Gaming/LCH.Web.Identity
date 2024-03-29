// Copyright (c) 2024 CG Shared Services, LLC
// File: LCH.Web.Identity.TextSample.cs
// ---------------------------------------------------------------------------------------------------
// Modifications:
// Date:                                       Name:                                  Description:

using System;

namespace LCH.Web.Identity.Areas.HelpPage.SampleGeneration
{
    /// <summary>
    /// This represents a preformatted text sample on the help page. There's a display template named TextSample associated with this class.
    /// </summary>
    public class TextSample
    {
        public TextSample(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException("text");
            }

            this.Text = text;
        }

        public string Text { get; }

        public override bool Equals(object obj)
        {
            TextSample other = obj as TextSample;
            return other != null && this.Text == other.Text;
        }

        public override int GetHashCode()
        {
            return this.Text.GetHashCode();
        }

        public override string ToString()
        {
            return this.Text;
        }
    }
}