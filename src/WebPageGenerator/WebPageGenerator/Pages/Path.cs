using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    /// <summary>
    /// テーブルの要素として動作
    /// </summary>
    public sealed class Path : HtmlElement
    {
        public readonly StringAttribute ValueAttribute;

        public override Path DeepCopy => new(ValueAttribute.StringValue);

        public override string Tag => "tr";

        public override string Value
        {
            get => ValueAttribute.StringValue;
            set => ValueAttribute.StringValue = value;
        }

        public Path() : this(string.Empty) { }

        public Path(string path)
        {
            ValueAttribute = new(path);
            m_attributes.Add(ValueAttribute);
        }
    }
}
