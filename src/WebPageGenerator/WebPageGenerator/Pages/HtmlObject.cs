using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public abstract class HtmlObject
    {
        public abstract HtmlObject DeepCopy { get; }
        public abstract string Value { get; set; }

        protected HtmlObject() { }

        public abstract string ToHtmlString();
    }
}
