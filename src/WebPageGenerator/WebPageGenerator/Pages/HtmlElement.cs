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

        /// <summary>
        /// class="Class"
        /// </summary>
        public string? Class;

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

        protected void DeepCopyTo(HtmlElement element)
        {
            element.m_attributes.Clear();
            element.m_nodes.Clear();

            foreach (var attribute in m_attributes)
            {
                element.m_attributes.Add(attribute.DeepCopy);
            }

            foreach (var node in m_nodes)
            {
                element.m_nodes.Add(node.DeepCopy);
            }
        }

        public override void Write(TextWriter writer)
        {

            writer.Write($"<{Tag}");

            // クラス属性を追加
            if (Class != null)
            {
                writer.Write($" class={Class}");
            }

            // その他属性を追加
            foreach (var attribute in m_attributes)
            {
                writer.Write(' ');
                attribute.Write(writer);
            }

            writer.Write(" >");

            foreach (var node in m_nodes)
            {
                node.Write(writer);
            }

            writer.Write($"</{Tag}>");
        }
    }
}
