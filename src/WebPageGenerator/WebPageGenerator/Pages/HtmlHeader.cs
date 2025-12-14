using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class HtmlHeader : HtmlElement
    {
        private readonly HtmlMetaData m_charset;
        private readonly HtmlMetaData m_description;
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
            get => m_description.Content;
            set => m_description.Content = value;
        }

        public string Title
        {
            get => m_title.Value;
            set => m_title.Value = value;
        }

        public override string Tag => "head";

        public override string Value { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }

        public HtmlHeader()
        {
            m_charset = new HtmlMetaData{ Charset = "utf-8" };
            m_description = new HtmlMetaData { Name = "description" };
            m_title = new("title");

            m_nodes.Add(m_charset);
            m_nodes.Add(m_title);
            m_nodes.Add(m_description);
        }

        public override void Write(TextWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
