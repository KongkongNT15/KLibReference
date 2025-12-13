using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class HtmlBody : HtmlElement
    {
        public override HtmlBody DeepCopy
        {
            get
            {
                HtmlBody instance = new();

                DeepCopyTo(instance);

                return instance;
            }
        }

        public override string Tag => "body";

        public override string Value { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }

        public HtmlBody() { }

        public void Add(HtmlNode node)
        {
            m_nodes.Add(node);
        }
    }
}
