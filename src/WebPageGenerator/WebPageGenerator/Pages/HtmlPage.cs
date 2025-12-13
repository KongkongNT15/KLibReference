using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class HtmlPage : HtmlElement
    {
        public readonly HtmlHeader Header;
        public readonly HtmlBody Body;

        public override string Tag => "html";

        public override string Value { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }

        public HtmlPage()
        {
            Header = new();
            Body = new();
        }
    }
}
