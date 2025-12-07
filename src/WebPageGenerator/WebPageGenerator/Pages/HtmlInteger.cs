using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class HtmlInteger : SimpleNode
    {
        public long IntValue;

        public override HtmlInteger DeepCopy => new (IntValue);

        public override string Value
        {
            get => IntValue.ToString();
            set => IntValue = long.Parse(value);
        }

        public HtmlInteger() : this(0) { }

        public HtmlInteger(long intValue)
        {
            IntValue = intValue;
        }

        public override string ToHtmlString()
        {
            return IntValue.ToString();
        }
    }
}
