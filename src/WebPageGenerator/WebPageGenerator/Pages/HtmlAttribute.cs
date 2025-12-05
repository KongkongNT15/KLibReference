using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public abstract class HtmlAttribute : HtmlObject
    {
        public string Name;

        protected HtmlAttribute(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}=\"{Value}\"";
        }
    }
}
