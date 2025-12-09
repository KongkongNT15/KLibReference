using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class IntergerAttribute : HtmlAttribute
    {
        public long IntValue;

        public override IntergerAttribute DeepCopy => new(Name, IntValue);

        public override string Value
        {
            get => IntValue.ToString();
            set => IntValue = long.Parse(value);
        }

        public IntergerAttribute(string name) : this(name, 0) { }

        public IntergerAttribute(string name, long intValue) : base(name)
        {
            IntValue = intValue;
        }

        public override void Write(TextWriter writer)
        {
            writer.Write($"{Name}=\"{IntValue}\"");
        }
    }
}
