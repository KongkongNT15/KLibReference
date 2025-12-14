using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    /// <summary>
    /// &lt;head&gt;に書く&lt;meta&gt;タグ
    /// </summary>
    public sealed class HtmlMetaData : HtmlNode
    {
        private const string s_tag = "meta";

        private readonly StringAttribute[] m_attributes;

        private readonly StringAttribute m_charset;
        private readonly StringAttribute m_content;
        private readonly StringAttribute m_name;
        private readonly StringAttribute m_property;

        public string Charset
        {
            get => m_charset.StringValue;
            set => m_charset.StringValue = value;
        }

        public string Content
        {
            get => m_content.StringValue;
            set => m_content.StringValue = value;
        }

        public bool HasAttribute
        {
            get
            {
                foreach (var attr in m_attributes)
                {
                    if (attr.StringValue.Length != 0) return true;
                }
                return false;
            }
        }

        public string Name
        {
            get => m_name.StringValue;
            set => m_name.StringValue = value;
        }

        public string Property
        {
            get => m_property.StringValue;
            set => m_property.StringValue = value;
        }

        public override string Value
        {
            get => m_content.StringValue;
            set => m_content.StringValue = value;
        }

        public override HtmlMetaData DeepCopy
        {
            get
            {
                HtmlMetaData meta = new();
                var attributes = meta.m_attributes;
                for (int i = 0; i < m_attributes.Length; i++)
                {
                    attributes[i].StringValue = m_attributes[i].StringValue;
                }

                return meta;
            }
        }

        public HtmlMetaData()
        {
            m_charset = new("charset");
            m_content = new("content");
            m_name = new("name");
            m_property = new("property");

            m_attributes = [
                m_charset,
                m_property,
                m_name,
                m_content,
            ];
        }

        public override void Write(TextWriter writer)
        {
            writer.Write($"<{s_tag} ");

            foreach (var attr in m_attributes)
            {
                if (attr.StringValue.Length != 0)
                {
                    attr.Write(writer);
                    writer.Write(' ');
                }
            }

            writer.Write(">");
        }
    }
}
