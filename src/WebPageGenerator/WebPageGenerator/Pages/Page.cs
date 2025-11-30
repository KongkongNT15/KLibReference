using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    internal class Page
    {
        protected readonly List<int> s;

        protected Page()
        {
            s = [];
        }

        public string PageName
        {
            get
            {
                return GetType().Name;
            }
        }

        public string PagePath
        {
            get
            {
                string? name = GetType().FullName;

                if (name == null) return string.Empty;

                return name.ToLower().Replace('.', '/');
            }
        }
    }
}
