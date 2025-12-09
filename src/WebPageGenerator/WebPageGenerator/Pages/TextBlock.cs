using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    internal sealed class TextBlock : HtmlElement
    {
        private readonly List<Text> m_inlines;
        public IReadOnlyList<Text> Inlines => m_inlines;

        public override HtmlElement DeepCopy
        {
            get
            {
                TextBlock copy = new();

                foreach (HtmlNode node in m_nodes)
                {
                    
                    if (node is Text text)
                    {
                        Text copyText = text.DeepCopy;
                        copy.m_nodes.Add(copyText);
                        copy.m_inlines.Add(copyText);
                    }
                    else
                    {
                        HtmlNode copyNode = node.DeepCopy;
                        copy.m_nodes.Add(copyNode);
                    }
                }

                return copy;
            }
        }

        public override string Tag => "pre";

        public override string Value
        {
            get
            {
                StringBuilder sb = new();

                foreach (HtmlNode node in m_nodes)
                {
                    sb.Append(node.Value);
                }

                return sb.ToString();
            }
            set
            {
                m_nodes.Clear();
                m_inlines.Clear();

                m_nodes.Add(new HtmlText(value));
            }
        }

        public TextBlock()
        {
            m_inlines = [];
        }

        public TextBlock(string text) : this()
        {
            m_nodes.Add(new HtmlText(text));
        }

        public void Add(Text text)
        {
            m_nodes.Add(text);
            m_inlines.Add(text);
        }

        public void Add(HtmlText text)
        {
            m_nodes.Add(text);
        }
    }
}
