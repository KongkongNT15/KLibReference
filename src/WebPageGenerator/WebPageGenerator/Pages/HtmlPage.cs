using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class HtmlPage : HtmlNode
    {
        private const string s_tag = "html";
        private const string s_doctype = "<!DOCTYPE html>";

        public readonly HtmlHeader Header;
        public readonly HtmlBody Body;

        public override HtmlPage DeepCopy
        {
            get
            {
                var header = Header.DeepCopy;
                var body = Body.DeepCopy;

                return new(header, body);
            }
        }

        public override string Value { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }

        private HtmlPage(HtmlHeader header, HtmlBody body)
        {
            Header = header;
            Body = body;
        }

        public HtmlPage() : this(new HtmlHeader(), new HtmlBody()) { }

        public override void Write(TextWriter writer)
        {
            writer.WriteLine(s_doctype);
            writer.Write($"<{s_tag}>");

            Header.Write(writer);
            Body.Write(writer);

            writer.Write($"</{s_tag}>");
        }
    }
}
