using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public abstract class HtmlNode : HtmlObject
    {
        public override HtmlNode DeepCopy => throw new NotImplementedException();
        protected HtmlNode() { }
    }
}
