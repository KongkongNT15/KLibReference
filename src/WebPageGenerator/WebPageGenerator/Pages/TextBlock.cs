using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    internal class TextBlock
    {
        private readonly List<int> m_inlines;
        public IReadOnlyList<int> Inlines => m_inlines;


    }
}
