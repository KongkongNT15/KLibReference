using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class HtmlText : SimpleNode
    {
        public string Text;
        public override string Value => Text;

        public HtmlText()
        {
            Text = string.Empty;
        }

        public HtmlText(string text)
        {
            Text = text; 
        }
    }
}
