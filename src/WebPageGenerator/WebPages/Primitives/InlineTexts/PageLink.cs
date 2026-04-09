using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPages.Primitives.InlineTexts
{
    public class PageLink : TextElement
    {
        public Uri Link;
        public string? Value;

        public override void WriteHtml(TextWriter writer, string? attributes)
        {
            string link = Link.ToString();
            writer.Write("<a href=\"");
            writer.Write(link);
            writer.Write('"');
            WriteAttributes(writer, attributes);
            writer.Write('>');

            if (Value != null)
            {
                writer.Write(Value);
            }
            else
            {
                writer.Write(link);
            }
            writer.Write("</a>");
        }
    }
}
