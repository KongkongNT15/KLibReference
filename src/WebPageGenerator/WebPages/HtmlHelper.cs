using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPages
{
    public static class HtmlHelper
    {
        public static string ToXamlString(string v)
        {
            StringBuilder sb = new();

            foreach (char c in v)
            {
                switch (c)
                {
                    case '&':
                        sb.Append("&amp;");
                        break;

                    case '<':
                        sb.Append("%lt;");
                        break;

                    case '>':
                        sb.Append("&gt;");
                        break;


                }
            }
        }
    }
}
