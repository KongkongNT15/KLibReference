using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class HtmlTableData : HtmlElement
    {
        public bool IsHeader;

        public override string Tag => IsHeader ? "th" : "td";

        public override string Value { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }

        public HtmlTableData() : this(false) { }

        public HtmlTableData(bool isHeader)
        {
            IsHeader = isHeader;
        }
    }
}
