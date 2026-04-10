using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPages.Primitives.InlineTexts
{
    public abstract class TextElement
    {
        public abstract void WriteHtml(TextWriter writer, string? attributes);
        public abstract void WriteXaml(TextWriter writer, string? attributes);

        public void WriteHtml(TextWriter writer) => WriteHtml(writer, null);
        public void WriteXaml(TextWriter writer) => WriteHtml(writer, null);

        protected static void WriteAttributes(TextWriter writer, string? attributes)
        {
            if (attributes == null) return;

            writer.Write(' ');
            writer.Write(attributes);
        }

        protected static void WriteAttribute(TextWriter writer, string attributeName, string attributeValue)
        {
            writer.Write(' ');
            writer.Write(attributeName);
            writer.Write("=\"");
            writer.Write(attributeValue);
            writer.Write('"');
        }
    }
}
