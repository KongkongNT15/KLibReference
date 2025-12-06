using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public abstract class HtmlElement : HtmlNode
    {
        protected readonly List<HtmlNode> m_nodes;
        protected readonly List<HtmlAttribute> m_attributes;

        public IReadOnlyList<HtmlNode> Nodes => m_nodes;
        public IReadOnlyList<HtmlAttribute> Attributes => m_attributes;

        public override HtmlElement DeepCopy => throw new NotImplementedException();

        /// <summary>
        /// &lt;Tag&gt;&lt;/Tag&gt;
        /// </summary>
        public abstract string Tag { get; }

        protected HtmlElement()
        {
            m_nodes = [];
            m_attributes = [];
        }
    }
}
