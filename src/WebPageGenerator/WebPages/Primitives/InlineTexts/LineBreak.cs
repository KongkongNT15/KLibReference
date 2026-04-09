using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPages.Primitives.InlineTexts
{
    public class LineBreak : TextElement
    {
        public override void WriteHtml(TextWriter writer, string? attributes)
        {
            writer.Write("<br>");
        }
    }
}
