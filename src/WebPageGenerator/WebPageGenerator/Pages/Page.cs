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

        public static HtmlNode Parse(XElement element)
        {
            switch (element.Name.LocalName)
            {
                case "InlineCode":
                    return new InlineCode(element.Value);

                case "Line":
                    return new Line(element.Value);

                case "Run":
                    return new Run(element.Value);

                case "TextBlock":
                    TextBlock textBlock = new();

                    foreach (XNode node in element.Nodes())
                    {
                        if (node is XElement xElement)
                        {
                            textBlock.Add((Text)Parse(xElement));
                        }
                        else if (node is XText xText)
                        {
                            textBlock.Add(xText.Value);
                        }
                        else
                        {
                            throw new NotSupportedException();
                        }
                    }

                    return textBlock;

                default:
                    throw new NotSupportedException($"Page.Parse(): オブジェクト<{element.Name}>はサポートされていません。");
            }
        }

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
