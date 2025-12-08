using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class HtmlTableRow : HtmlElement
    {
        public override HtmlTableRow DeepCopy
        {
            get
            {
                HtmlTableRow row = new();

                DeepCopyTo(row);

                return row;
            }
        }
        public override string Tag => "tr";

        public override string Value { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }

        public void Add(HtmlTableData data)
        {
            m_nodes.Add(data);
        }
    }
}
