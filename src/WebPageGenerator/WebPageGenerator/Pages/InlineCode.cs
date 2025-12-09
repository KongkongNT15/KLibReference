using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    /// <summary>
    /// インラインコード
    /// <see cref="このクラスでフィールド'Class'を設定しても無視されます"/>
    /// </summary>
    public class InlineCode : Text
    {
        public override InlineCode DeepCopy => new(InlineText);
        public InlineCode() { }

        public InlineCode(string value) : base(value) { }

        public override string ToHtmlString()
        {
            return $"<{Tag} class=\"{CssClasses.InlineCode}\">{XmlHelper.ToXmlString(InlineText)}</{Tag}>";
        }
    }
}
