using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class ColorAttribute : HtmlAttribute
    {
        public Color Color;

        public override ColorAttribute DeepCopy => new(Name, Color);

        public override string Value
        {
            get => Color.ToString();
            set => Color = new Color(value);
        }

        public ColorAttribute(string name, Color color) : base(name)
        {
            Color = color;
        }

        public ColorAttribute(string name, string color) : base(name)
        {
            Color = new Color(color);
        }

        public override string ToHtmlString()
        {
            return $"{Name}=\"{Color}\"";
        }
    }
}
