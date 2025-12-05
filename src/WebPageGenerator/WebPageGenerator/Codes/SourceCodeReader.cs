using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Codes
{
    /// <summary>
    /// ソースコードを読み込んで色付けするクラスなのぜ
    /// </summary>
    public abstract class SourceCodeReader
    {
       

        protected readonly List<SourceCodeElement> m_elements;

        public IReadOnlyList<SourceCodeElement> Elements => m_elements;

        protected SourceCodeReader()
        {
            m_elements = [];
        }

        public abstract void Load(TextReader reader);

        
    }
}
