using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public class Text : HtmlElement
    {
        public string InlineText;

        public override string Tag => "span";

        public override string Value => InlineText;

        protected Text()
        {
            InlineText = string.Empty;
        }

        protected Text(string inlineText)
        {
            InlineText = inlineText;
        }
    }
}
