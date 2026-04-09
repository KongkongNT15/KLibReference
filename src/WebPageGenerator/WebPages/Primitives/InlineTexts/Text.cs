using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPages.Primitives.InlineTexts
{
    public class Text : TextElement
    {
        public FontWeight FontWeight;
        public double FontSize;
        public RgbColor Color;
        public string Value;

        public override void WriteHtml(TextWriter writer, string? attributes)
        {
            writer.Write("<span style=\"");
            
            WriteAttributes(writer, attributes);

            throw new NotImplementedException();
        }
    }
}
