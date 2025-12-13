using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public abstract class SimpleElement : HtmlNode
    {
        public string Name;

        protected SimpleElement(string name)
        {
            Name = name;
        }

        public override void Write(TextWriter writer)
        {
            writer.Write($"<{Name}>");
            writer.Write(XmlHelper.ToXmlString(Value));
            writer.Write($"</{Name}>");
        }
    }
}
