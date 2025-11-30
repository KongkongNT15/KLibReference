using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageGenerator.Pages
{
    internal sealed class Text
    {
        public string En;
        public string Ja;

        public string Default
        {
            get
            {
                return PageData.DefaultLanguage switch
                {
                    Language.En => En,
                    Language.Ja => Ja,
                    _ => throw new NotSupportedException()
                };

            }
        }

        public Text()
        {
            En = Ja = string.Empty;
        }
    }
}
