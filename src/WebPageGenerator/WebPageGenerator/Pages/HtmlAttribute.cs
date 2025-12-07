using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public abstract class HtmlAttribute : HtmlObject
    {
        public string Name;

        public override HtmlAttribute DeepCopy => throw new NotImplementedException();

        protected HtmlAttribute(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}=\"{XmlHelper.ToXmlString(Value)}\"";
        }
    }
}
