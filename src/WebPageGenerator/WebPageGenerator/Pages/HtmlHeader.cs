using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class HtmlHeader : HtmlNode
    {
        private const string s_tag = "head";
        private readonly HtmlMetaData m_charset;
        private readonly HtmlMetaData m_description;
        private readonly StringElement m_title;
        private readonly HtmlMetaData[] m_metas;
        
        public override HtmlHeader DeepCopy
        {
            get
            {
                HtmlHeader instance = new();

                instance.m_title.Value = m_title.Value;

                var nodes = instance.m_metas;

                for (int i = 0; i < m_metas.Length; i++)
                {
                    nodes[i] = m_metas[i].DeepCopy;
                }

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

        public override string Value { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }

        public HtmlHeader()
        {
            m_charset = new HtmlMetaData{ Charset = "utf-8" };
            m_description = new HtmlMetaData { Name = "description" };
            m_title = new("title");

            m_metas = [
                m_charset,
                m_description
            ];
        }

        public override void Write(TextWriter writer)
        {
            writer.Write($"<{s_tag}>");

            m_title.Write(writer);

            foreach (var meta in m_metas)
            {
                meta.Write(writer);
            }

            writer.Write($"</{s_tag}>");
        }
    }
}
