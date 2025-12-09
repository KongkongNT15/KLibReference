using System;
using System.Collections.Generic;
using System.Text;
using WebPageGenerator.Pages;

namespace WebPageGenerator.Codes
{
    /// <summary>
    /// ソースコードを読み込んで色付けするクラスなのぜ
    /// </summary>
    public abstract class SourceCodeReader
    {
       

        protected readonly List<SourceCodeElement> m_elements;

        public IReadOnlyList<SourceCodeElement> Elements => m_elements;

        public abstract string LanguageName { get; }

        protected SourceCodeReader()
        {
            m_elements = [];
        }

        public abstract void Load(TextReader reader);

        public HtmlTable ToHtmlTable()
        {
            HtmlTable table = new();
            HtmlTableRow row1 = new();
            HtmlTableRow row2 = new();
            HtmlTableData data = new();
            TextBlock textBlock = new();
            row1.Add(new(true, LanguageName));
            row1.Class = CssClasses.SourceTable;

            foreach (SourceCodeElement element in m_elements)
            {
                textBlock.Add(element.ToHtml());
            }

            data.Add(textBlock);
            row2.Add(data);
            row2.Class = CssClasses.SourceTable;
            table.Add(row1);
            table.Add(row2);

            return table;
        }
    }
}
