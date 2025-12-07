using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class HtmlText : SimpleNode
    {
        public string Text;
        public override string Value
        {
            get => Text;
            set => Text = value;
        }

        public HtmlText()
        {
            Text = string.Empty;
        }

        public HtmlText(string text)
        {
            Text = text; 
        }

        public override string ToHtmlString()
        {
            return XmlHelper.ToXmlString(Text);
        }
    }
}
