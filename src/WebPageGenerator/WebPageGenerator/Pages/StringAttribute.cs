using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class StringAttribute : HtmlAttribute
    {
        public string StringValue;
        public override StringAttribute DeepCopy => new(Name, StringValue);

        public override string Value
        {
            get => StringValue;
            set => StringValue = value;
        }

        public StringAttribute(string name) : this(name, string.Empty) { }

        public StringAttribute(string name, string value) : base(name)
        {
            StringValue = value;
        }
    }
}
