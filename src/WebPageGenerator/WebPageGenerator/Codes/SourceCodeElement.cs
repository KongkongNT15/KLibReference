using System;
using System.Collections.Generic;
using System.Text;
using WebPageGenerator.Pages;

namespace WebPageGenerator.Codes
{
    public sealed class SourceCodeElement
    {
        public static SourceCodeElement Space(int spaceCount)
        {
            return new SourceCodeElement(new string(' ', spaceCount));
        }

        public string Code;
        public WordType WordType;

        public SourceCodeElement(string code) : this(code, WordType.Other)
        {
        }

        public SourceCodeElement(string code, WordType type)
        {
            Code = code;
            WordType = type;
        }

        public Run ToHtml()
        {
            return new(Code)
            {
                Class = CssClasses.FromWordType(WordType)
            };
        }
    }
}
