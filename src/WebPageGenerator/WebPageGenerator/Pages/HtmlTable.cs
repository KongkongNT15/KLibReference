using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class HtmlTable : HtmlElement
    {
        public override HtmlTable DeepCopy
        {
            get
            {
                HtmlTable table = new();

                DeepCopyTo(table);

                return table;
            }
        }

        public override string Tag => "table";

        public override string Value { get => string.Empty; set => _ = value; }

        public void Add(HtmlTableRow tableRow)
        {
            m_nodes.Add(tableRow);
        }
    }
}
