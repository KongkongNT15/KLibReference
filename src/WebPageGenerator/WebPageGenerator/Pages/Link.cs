using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class Link : Text
    {
        private const string s_tag = "a";

        private readonly StringAttribute m_href;
        public string Path
        {
            get => m_href.StringValue;
            set => m_href.StringValue = value;
        }

        public override string Tag => s_tag;

        public Link(string text, string path) : base(text)
        {
            m_href = new StringAttribute("href", path);

            m_attributes.Add(m_href);
        }

        public override void Write(TextWriter writer)
        {
            writer.Write($"<{s_tag} ");

            m_href.Write(writer);

            if (Class != null)
            {
                writer.Write($" class=\"{Class}\"");
            }
            writer.Write('>');

            writer.Write(XmlHelper.ToXmlString(InlineText));

            writer.Write($"</{s_tag}>");
        }
    }
}
