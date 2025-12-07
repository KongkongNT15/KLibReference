using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    public static class XmlHelper
    {
        /// <summary>
        /// 文字列をXML形式に変換
        /// </summary>
        /// <param name="value">元の文字列</param>
        /// <returns>変換された文字列</returns>
        public static string ToXmlString(string value)
        {
            StringBuilder sb = new();

            foreach (char c in value)
            {
                sb.Append(c switch
                {
                    '<' => "&lt;",
                    '>' => "&gt;",
                    '&' => "&amp;",
                    '"' => "&quot;",
                    '\'' => "&apos;",
                    _ => c,
                });
            }

            return sb.ToString();
        }
    }
}
