using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class StringElement : SimpleElement
    {   
        public override string Value { get; set; }

        public StringElement(string name) : this(name, string.Empty) { }

        public StringElement(string name, string value) : base(name)
        {
            Value = value;
        }
    }
}
