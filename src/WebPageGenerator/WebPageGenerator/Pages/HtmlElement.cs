using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public abstract class HtmlElement : HtmlNode
    {
        private readonly List<HtmlNode> m_nodes;

        public IReadOnlyList<HtmlNode> Nodes => m_nodes;
        /// <summary>
        /// &lt;Tag&gt;&lt;/Tag&gt;
        /// </summary>
        public abstract string Tag { get; }

        protected HtmlElement()
        {
            m_nodes = [];
        }

        public HtmlNode Add(HtmlNode node)
        {

        }
    }
}
