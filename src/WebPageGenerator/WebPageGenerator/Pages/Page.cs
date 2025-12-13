using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace WebPageGenerator.Pages
{
    public abstract class Page
    {
        protected XElement m_element;
        private HtmlNode? m_htmlNode;

        protected Page(XElement element)
        {
            m_element = element;
            m_htmlNode = null;
        }

        public abstract HtmlNode Load();

        public HtmlNode ToHtml()
        {
            if (m_htmlNode == null) return m_htmlNode = Load();
            return m_htmlNode;
        }
    }
}
