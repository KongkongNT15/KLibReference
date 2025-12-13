using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class HtmlHeader : HtmlElement
    {
        private readonly StringElement m_charset;
        private readonly StringElement m_description;
        private readonly StringElement m_title;
        
        public override HtmlHeader DeepCopy
        {
            get
            {
                HtmlHeader instance = new();

                DeepCopyTo(instance);

                return instance;
            }
        }

        public string Description
        {
            get => m_description.Value;
            set => m_description.Value = value;
        }

        public override string Tag => "head";

        public override string Value { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }

        public HtmlHeader()
        {
            m_charset = new("charset", "utf-8");
            m_description = new("description");
            m_title = new("title");

            m_nodes.Add(m_charset);
            m_nodes.Add(m_description);
        }
    }
}
