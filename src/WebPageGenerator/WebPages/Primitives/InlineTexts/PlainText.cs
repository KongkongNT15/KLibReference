using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPages.Primitives.InlineTexts
{
    public class PlainText : TextElement
    {
        public string Value;

        public override void WriteHtml(TextWriter writer, string? attributes)
        {
            writer.Write("<span");
            WriteAttributes(writer, attributes);
            writer.Write('>');

            writer.Write(Value);
            writer.Write("</span>");
        }
    }
}
