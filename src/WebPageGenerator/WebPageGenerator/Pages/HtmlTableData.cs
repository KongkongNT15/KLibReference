using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class HtmlTableData : HtmlElement
    {
        public bool IsHeader;

        public override HtmlTableData DeepCopy
        {
            get
            {
                HtmlTableData data = new();

                DeepCopyTo(data);

                data.IsHeader = IsHeader;

                return data;
            }
        }

        public override string Tag => IsHeader ? "th" : "td";

        public override string Value
        {
            get
            {
                StringBuilder sb = new();

                foreach (var node in m_nodes)
                {
                    if (node is HtmlText text)
                    {
                        sb.Append(text.Text);
                    }
                }

                return sb.ToString();
            }
            set
            {
                m_nodes.Clear();
                m_nodes.Add(new HtmlText(value));
            }
        }

        public HtmlTableData() : this(false) { }
        public HtmlTableData(string value) : this(false, value) { }

        public HtmlTableData(bool isHeader)
        {
            IsHeader = isHeader;
        }

        public HtmlTableData(bool isHeader, string value)
        {
            IsHeader = isHeader;
            Value = value;
        }

        public void Add(string value)
        {
            m_nodes.Add(new HtmlText(value));
        }

        public void Add(HtmlNode node)
        {
            m_nodes.Add(node);
        }
    }
}
