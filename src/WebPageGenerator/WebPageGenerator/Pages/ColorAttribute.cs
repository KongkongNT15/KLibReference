using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public sealed class ColorAttribute : HtmlAttribute
    {
        public Color Color;
        public override string Value => Color.ToString();

        public ColorAttribute(string name, Color color) : base(name)
        {
            Color = color;
        }

        public ColorAttribute(string name, string color) : base(name)
        {
            Color = new Color(color);
        }
    }
}
