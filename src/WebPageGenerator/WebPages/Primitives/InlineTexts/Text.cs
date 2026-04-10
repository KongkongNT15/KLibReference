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

        public Text(string value)
        {
            Value = value;
        }

        public override void WriteHtml(TextWriter writer, string? attributes)
        {
            writer.Write("<span style=\"color: ");
            writer.Write(Color.ToString());
            WriteAttributes(writer, attributes);

            throw new NotImplementedException();
        }
    }
}
