using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class HtmlBoolean : SimpleNode
    {
        bool BoolValue;

        public override HtmlBoolean DeepCopy => new(BoolValue);

        public override string Value
        {
            get => BoolValue ? "true" : "false";
            set => BoolValue = bool.Parse(value);
        }

        public HtmlBoolean() : this(false) { }

        public HtmlBoolean(bool value)
        {
            BoolValue = value;
        }

        public override void Write(TextWriter writer)
        {
            writer.Write(BoolValue ? "true" : "false");
        }
    }
}
