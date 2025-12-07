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

        public override string ToHtmlString()
        {
            StringBuilder stringBuilder = new();

            stringBuilder.Append($"<{Tag}");

            // クラス属性を追加
            if (Class != null)
            {
                stringBuilder.Append($" class={Class}");
            }

            // その他属性を追加
            foreach (var attribute in m_attributes)
            {
                stringBuilder.Append($" {attribute.ToHtmlString()}");
            }

            stringBuilder.Append(" >");

            foreach (var node in m_nodes)
            {
                stringBuilder.Append(node.ToHtmlString());
            }

            stringBuilder.Append($"</{Tag}>");

            return stringBuilder.ToString();
        }
    }
}
