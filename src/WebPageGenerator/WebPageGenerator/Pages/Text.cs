using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public class Text : HtmlElement
    {
        public string InlineText;

        public override Text DeepCopy => new(InlineText);

        public override string Tag => "span";

        public override string Value
        {
            get => InlineText;
            set => InlineText = value;
        }

        protected Text()
        {
            InlineText = string.Empty;
        }

        protected Text(string inlineText)
        {
            InlineText = inlineText;
        }

        public override string ToHtmlString()
        {
            return $"<{Tag}>{XmlHelper.ToXmlString(InlineText)}</{Tag}>";
        }
    }
}
