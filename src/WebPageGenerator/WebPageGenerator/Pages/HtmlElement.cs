using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public abstract class HtmlElement
    {
        /// <summary>
        /// &lt;Tag&gt;&lt;/Tag&gt;
        /// </summary>
        public abstract string Tag { get; }
    }
}
