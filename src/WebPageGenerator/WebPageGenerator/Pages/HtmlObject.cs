using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public abstract class HtmlObject
    {
        public abstract string Value { get; }

        protected HtmlObject() { }
    }
}
